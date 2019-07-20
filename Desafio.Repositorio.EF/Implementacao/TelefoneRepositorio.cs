using Desafio.Repositorio.Abstrato.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio.Repositorio.EF.Implementacao
{
    public class TelefoneRepositorio : Repositorio<Telefone>
    {
        public TelefoneRepositorio(DbContext context) : base(context)
        {
        }
    }
}
