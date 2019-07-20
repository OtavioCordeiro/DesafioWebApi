using Desafio.Repositorio.Abstrato.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio.Repositorio.EF.Implementacao
{
    public class TelefoneRepositorio : Repositorio<Telefone>
    {
        public TelefoneRepositorio(DesafioContexto desafioContexto) : base(desafioContexto)
        {
        }
    }
}
