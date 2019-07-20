using Desafio.Repositorio.Abstrato.Entidades;
using Desafio.Repositorio.Abstrato.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio.Repositorio.EF.Implementacao
{
    public class EnderecoRepositorio : Repositorio<Endereco>, IEnderecoRepositorio
    {
        public EnderecoRepositorio(DbContext context) : base(context)
        {
        }
    }
}
