using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestructure.Data.Configuration
{
    public class ProveedorConfiguration : IEntityTypeConfiguration<Proveedor>
    {
        public void Configure(EntityTypeBuilder<Proveedor> builder)
        {
            builder.ToTable("Proveedor");

            builder.HasKey(i => i.Id);
            builder.Property(i => i.Id);

            builder.HasIndex(i => i.NitProveedor)
            .IsUnique();
            
            builder.Property(n => n.Nombre)
            .IsRequired()
            .HasMaxLength(100);

            builder.HasOne(t => t.TipoPersonas)
            .WithMany(t => t.Proveedores)
            .HasForeignKey(t => t.IdTipoPersona);

            builder.HasOne(t => t.Municipios)
            .WithMany(t => t.Proveedores)
            .HasForeignKey(p => p.IdMunicipio);

        }
    }
}