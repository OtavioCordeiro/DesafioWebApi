using Desafio.Repositorio.Abstrato.Entidades;
using GeradorDeDadosAleatorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio.API.Contexto
{
    public static class DesafioDbApiContextoExtensions
    {
        public static void EnsureSeedDataForContext(this DesafioDbApiContexto context)
        {
            if (context.Usuarios.Count() == 0)
            {
                var usuarios = UsuariosBuilder.CreateUsuarios();

                context.Usuarios.AddRange(usuarios);
                context.SaveChanges();
            }
        }

    }
}
