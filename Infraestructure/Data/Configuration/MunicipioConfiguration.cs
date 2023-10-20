using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestructure.Data.Configuration
{
    public class MunicipioConfiguration : IEntityTypeConfiguration<Municipio>
    {
        public void Configure(EntityTypeBuilder<Municipio> builder)
        {
            builder.ToTable("Municipio");

            builder.HasKey(i => i.Id);
            builder.Property(i => i.Id);

            builder.Property(p => p.Nombre)
            .IsRequired()
            .HasMaxLength(20);

            builder.HasOne(p => p.Departamentos)
            .WithMany(p => p.Municipios)
            .HasForeignKey(p => p.IdDepartamento);

        }
    }
}