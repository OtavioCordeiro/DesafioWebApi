using Desafio.Repositorio.Abstrato.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio.Repositorio.EF.Implementacao
{
    public class UsuarioRepositorio : Repositorio<Usuario>
    {
        public UsuarioRepositorio(DesafioContexto desafioContexto) : base(desafioContexto)
        {
        }
    }
}
