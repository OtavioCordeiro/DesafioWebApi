using Desafio.Repositorio.Abstrato.Entidades;
using Desafio.Repositorio.Abstrato.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio.Repositorio.EF.Implementacao
{
    public class TelefoneRepositorio : Repositorio<Telefone>, ITelefoneRepositorio
    {
        public TelefoneRepositorio(DbContext context) : base(context)
        {
        }
    }
}
