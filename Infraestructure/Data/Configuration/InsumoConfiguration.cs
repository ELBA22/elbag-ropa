using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestructure.Data.Configuration
{
    public class InsumoConfiguration : IEntityTypeConfiguration<Insumo>
    {
        public void Configure(EntityTypeBuilder<Insumo> builder)
        {
            builder.ToTable("Insumo");

            builder.HasKey(i => i.Id);
            builder.Property(i => i.Id);

            builder.HasIndex( N => N.Nombre)
            .IsUnique();

            builder.Property(v => v.ValorUn)
            .HasColumnType("double");

            builder.Property(v => v.StockMin)
            .HasColumnType("int");

            builder.Property(v => v.StockMax)
            .HasColumnType("double");
        }
    }
}