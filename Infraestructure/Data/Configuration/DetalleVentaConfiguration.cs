using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestructure.Data.Configuration
{
    public class DetalleVentaConfiguration : IEntityTypeConfiguration<DetalleVenta>
    {
        public void Configure(EntityTypeBuilder<DetalleVenta> builder)
        {
            builder.ToTable(" DetalleVenta");

            builder.HasKey(i => i.Id);
            builder.Property(i => i.Id);

            builder.HasOne(p => p.Ventas)
            .WithMany(p => p.DetalleVentas)
            .HasForeignKey(p => p.IdVenta);

            builder.HasOne(p => p.Inventarios)
            .WithMany(p => p.DetalleVentas)
            .HasForeignKey(p => p.IdInventario);

            builder.HasOne(p => p.Tallas)
            .WithMany(p => p.DetalleVentas)
            .HasForeignKey(p => p.IdTalla);

            builder.Property(p => p.Cantidad)
            .HasColumnType("int");

            builder.Property(p => p.ValorUnitario)
            .HasColumnType("double");

        }
    }
}