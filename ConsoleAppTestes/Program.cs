using Desafio.Repositorio.Abstrato.Entidades;
using Desafio.Repositorio.Abstrato.Interfaces;
using Desafio.Repositorio.EF;
using Desafio.Repositorio.EF.Implementacao;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleAppTestes
{
    class Program
    {
        static void Main(string[] args)
        {
            DesafioDbContexto contexto = new DesafioDbContexto();

            IUsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio(contexto);

            Usuario usuario = new Usuario()
            {
                Nome = "Otavio",
                CPF = 12345678901,
                RG = 123456789,
                Endereco = GetEndereco(),
                Telefones = GetTelefones()

            };

            usuarioRepositorio.Add(usuario);
        }

        private static Endereco GetEndereco()
        {
            return new Endereco()
            {
                Bairro = "Santa Cruz"
                            ,
                CEP = 23565310
                            ,
                Logradouro = "Rua Irineu Paiva Sodré"
                            ,
                Municipio = "Rio de Janeiro"
                            ,
                Numero = 70
                            ,
                UF = "RJ"
            };
        }

        private static List<Telefone> GetTelefones()
        {
            List<Telefone> telefones = new List<Telefone>();

            Telefone t1 = new Telefone()
            {
                Numero = 02123526548,
                Tipo = "Celular"
            };

            Telefone t2 = new Telefone()
            {
                Numero = 02133956585,
                Tipo = "Telefone"
            };

            telefones.Add(t1);
            telefones.Add(t2);

            return telefones;
        }
    }
}
