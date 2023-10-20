using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestructure.Data.Configuration
{
    public class TallaConfiguration : IEntityTypeConfiguration<Talla>
    {
        public void Configure(EntityTypeBuilder<Talla> builder)
        {
           builder.ToTable("Talla");

            builder.HasKey(i => i.Id);
            builder.Property(i => i.Id);

            builder.Property(d => d.Descripcion)
            .IsRequired()
            .HasMaxLength(50);


        }
    }
}