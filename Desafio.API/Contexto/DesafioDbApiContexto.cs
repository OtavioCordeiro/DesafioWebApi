using Desafio.Repositorio.Abstrato.Entidades;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio.API.Contexto
{
    public class DesafioDbApiContexto : DbContext
    {
        public DesafioDbApiContexto(DbContextOptions<DesafioDbApiContexto> options) : base(options)
        {
            base.Database.Migrate();
        }

        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<Endereco> Enderecos { get; set; }

        public DbSet<Telefone> Telefones { get; set; }
    }
}
