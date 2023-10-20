using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Core.Entities;

namespace Infraestructure.Data.Configuration
{
    public class CargoConfiguration : IEntityTypeConfiguration<Cargo>
    {
        public void Configure(EntityTypeBuilder<Cargo> builder)
        {
            builder.ToTable("Cargo");

            builder.HasKey(i => i.Id);
            builder.Property(i => i.Id);

            builder.Property( f=> f.Descripcion)
            .IsRequired()
            .HasMaxLength(80);

            builder.Property(f => f.Sueldo)
            .HasColumnType("double");
        }

    }

    
}