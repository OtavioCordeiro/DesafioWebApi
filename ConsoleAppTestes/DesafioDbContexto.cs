using Desafio.Repositorio.Abstrato.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTestes
{
    public class DesafioDbContexto : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<Endereco> Enderecos { get; set; }

        public DbSet<Telefone> Telefones { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source = otavio\sqlexpress; Initial Catalog = DesafioDB; Integrated Security = True; Pooling = False");
        }
    }
}
