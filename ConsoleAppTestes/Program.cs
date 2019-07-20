using Desafio.Repositorio.Abstrato.Entidades;
using Desafio.Repositorio.EF;
using Desafio.Repositorio.EF.Implementacao;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace ConsoleAppTestes
{
    class Program
    {
        static void Main(string[] args)
        {
            var connectionString = @"Data Source = otavio\sqlexpress; Initial Catalog = DesafioDB; Integrated Security = True; Pooling = False";

            var serviceProvider = new ServiceCollection()
                .AddEntityFrameworkSqlServer()
                .BuildServiceProvider();

            var builder = new DbContextOptionsBuilder<DesafioContexto>();
            builder.UseSqlServer(connectionString).UseInternalServiceProvider(serviceProvider);

            var contexto = new DesafioContexto(builder.Options);

            var repositorio = new UsuarioRepositorio(contexto);

            Usuario usuario = new Usuario()
            {
                CPF = 12345678901,
                RG = 123456789,
                Nome = "Otavio"
            };
            repositorio.Add(usuario);
        }
    }
}
