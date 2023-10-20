using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestructure.Data.Configuration
{
    public class ColorConfiguration : IEntityTypeConfiguration<Color>
    {
        public void Configure(EntityTypeBuilder<Color> builder)
        {
            builder.ToTable("Color");

            builder.HasKey(i => i.Id);
            builder.Property(i => i.Id);

            builder.Property(f => f.Descripcion)
            .IsRequired()
            .HasMaxLength(100);
            


        }
    }
}