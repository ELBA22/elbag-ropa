using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestructure.Data.Configuration
{
    public class PrendaConfiguration : IEntityTypeConfiguration<Proveedor>
    {
        public void Configure(EntityTypeBuilder<Proveedor> builder)
        {
            builder.ToTable("Prenda");

            builder.HasKey(i => i.Id);
            builder.Property(i => i.Id);

            
            builder.HasIndex(p => p.)
            .IsUnique();

            builder.Property(p => p.Nombre)
            .IsRequired()
            .HasMaxLength(20);

            builder.Property( p => p.ValorUniCop)
            .HasColumnType("double");

            builder.Property(p => p.ValorUniUsd)
            .HasColumnType("double");

            builder.HasOne(p => p.Estados)
            .WithMany(p => p.Prendas)
            .HasForeignKey(p => p.IdEstado);

           

            



        }

        
    }
}