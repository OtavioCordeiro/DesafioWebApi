using Desafio.Repositorio.Abstrato.Entidades;
using FizzWare.NBuilder;
using System;
using System.Collections.Generic;
using System.Text;

namespace GeradorDeDadosAleatorio
{
    public class UsuariosBuilder
    {
        public static IEnumerable<Usuario> CreateUsuarios()
        {
            var usuarios = Builder<Usuario>.CreateListOfSize(5)
                                .All()
                                    .With(u => u.Endereco = Builder<Endereco>.CreateNew().Build())
                                    .With(u => u.Telefones = Builder<Telefone>.CreateListOfSize(2).Build())
                                    .Build();

            //int enderecoId = 1;
            int telefoneId = 1;

            foreach (var usuario in usuarios)
            {
                usuario.Endereco.EnderecoId = 0;
                usuario.Endereco.UsuarioId = 0;
                usuario.UsuarioId = 0;

                foreach (var telefone in usuario.Telefones)
                {
                    telefone.TelefoneId = 0;
                    telefone.UsuarioId = 0;
                    SetTelefoneType(telefoneId, telefone);
                }
            }

            return usuarios;
        }

        private static void SetTelefoneType(int telefoneId, Telefone telefone)
        {
            if ((telefoneId / 3) == 0)
            {
                telefone.Tipo = "TEL";
            }
            else if ((telefoneId / 2) == 0)
            {
                telefone.Tipo = "CEL";
            }
            else
            {
                telefone.Tipo = null;
            }

            telefoneId++;
        }
    }
}
