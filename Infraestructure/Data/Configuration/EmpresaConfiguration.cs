using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestructure.Data.Configuration
{
    public class EmpresaConfiguration : IEntityTypeConfiguration<Empresa>
    {
        public void Configure(EntityTypeBuilder<Empresa> builder)
        {
            builder.ToTable("Empesa");

            builder.HasKey(i => i.Id);
            builder.Property(i => i.Id);

            builder.HasIndex(f => f.Nit)
            .IsUnique();

            builder.Property(p => p.RazonSocial)
            .IsRequired()
            .HasMaxLength(100);
            
            builder.Property(m => m.RepresentanteLegal)
            .IsRequired()
            .HasMaxLength(100);

            builder.Property(f => f.FechaCreacion)
            .HasColumnType("Date");
        }
    }
}