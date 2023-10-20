using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestructure.Data.Configuration
{
    public class InventarioConfiguration : IEntityTypeConfiguration<Inventario>
    {
        public void Configure(EntityTypeBuilder<Inventario> builder)
        {
            builder.HasKey(i => i.Id);
            builder.Property(i => i.Id);

            builder.HasIndex(p => p.CodIventario)
            .IsUnique();

            builder.HasOne(p => p.Prendas)
            .WithMany(p => p.Inventarios)
            .HasForeignKey(p => p.IdPrenda);

            builder.Property(p => p.ValorVtaCop)
            .HasColumnType("double");

            builder.Property(p => p.ValorVtaCop)
            .HasColumnType("double");
        }
    }
}