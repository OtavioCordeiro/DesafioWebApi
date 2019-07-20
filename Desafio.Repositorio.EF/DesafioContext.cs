using Desafio.Repositorio.Abstrato.Entidades;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio.Repositorio.EF
{
    public class DesafioContexto : DbContext
    {
        public DesafioContexto(DbContextOptions<DesafioContexto> options) : base(options)
        {
        }

        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<Endereco> Enderecos { get; set; }

        public DbSet<Telefone> Telefones { get; set; }
    }
}
