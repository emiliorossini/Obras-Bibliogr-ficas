using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TesteConquest.Domain.Entities;
using TesteConquest.Domain.Extensions;

namespace TesteConquest.Infra.Data.EntityConfig
{
    public class AutorConfig : EntityTypeConfiguration<Autor>
    {
        public override void Map(EntityTypeBuilder<Autor> builder)
        {
            builder.Property(e => e.Id)
                .HasColumnType("int")
                .IsRequired()
                .ValueGeneratedOnAdd();


            builder.Property(e => e.NomeCompleto)
                .HasColumnType("nvarchar(100)")
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(e => e.NomeExibicao)
              .HasColumnType("nvarchar(100)")
              .HasMaxLength(100)
              .IsRequired();

            //builder.Ignore(e => e.NomeExibicao);

            builder.ToTable("Autor");

        }
    }
}
