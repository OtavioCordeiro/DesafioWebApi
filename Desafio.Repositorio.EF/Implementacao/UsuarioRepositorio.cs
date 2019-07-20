using Desafio.Repositorio.Abstrato.Entidades;
using Desafio.Repositorio.Abstrato.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio.Repositorio.EF.Implementacao
{
    public class UsuarioRepositorio : Repositorio<Usuario>, IUsuarioRepositorio
    {
        public UsuarioRepositorio(DbContext context) : base(context)
        {
        }
    }
}
