using Desafio.Repositorio.Abstrato.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio.Repositorio.EF.Implementacao
{
    public class EnderecoRepositorio : Repositorio<Endereco>
    {
        public EnderecoRepositorio(DesafioContexto desafioContexto) : base(desafioContexto)
        {
        }
    }
}
