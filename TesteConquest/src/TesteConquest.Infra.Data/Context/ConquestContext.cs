using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TesteConquest.Domain.Entities;
using TesteConquest.Domain.Extensions;
using TesteConquest.Infra.Data.EntityConfig;

namespace TesteConquest.Infra.Data.Context
{
    public class ConquestContext : DbContext
    {

        public ConquestContext(DbContextOptions<ConquestContext> options)
            : base(options)
        {
        }

        public DbSet<Autor> Autores { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.AddConfiguration(new AutorConfig());

            modelBuilder.Entity<Autor>().HasData(
                new Autor(1, "Paulo Coelho"));

            modelBuilder.Entity<Autor>().HasData(
                new Autor(2, "Monteiro Lobato"));

            modelBuilder.Entity<Autor>().HasData(
               new Autor(3, "José de Alencar"));

            modelBuilder.Entity<Autor>().HasData(
               new Autor(4, "João Cabral de Melo Neto"));

            modelBuilder.Entity<Autor>().HasData(
               new Autor(5, "Cecília Meireles"));

            modelBuilder.Entity<Autor>().HasData(
               new Autor(6, "Guimarães"));
        }
    }
}
