using Desafio.Repositorio.Abstrato.Entidades;
using Desafio.Repositorio.Abstrato.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Desafio.Repositorio.EF.Implementacao
{
    public class UsuarioRepositorio : Repositorio<Usuario>, IUsuarioRepositorio
    {
        public UsuarioRepositorio(DbContext context) : base(context)
        {
        }

        public IEnumerable<Usuario> GetFull()
        {
            return Context.Set<Usuario>()
                            .Include(u => u.Endereco)
                            .Include(u => u.Telefones);
        }
    }
}
