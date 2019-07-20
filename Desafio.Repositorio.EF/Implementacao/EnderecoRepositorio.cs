using Desafio.Repositorio.Abstrato.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio.Repositorio.EF.Implementacao
{
    public class EnderecoRepositorio : Repositorio<Endereco>
    {
        public EnderecoRepositorio(DbContext context) : base(context)
        {
        }
    }
}
