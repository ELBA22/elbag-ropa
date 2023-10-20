using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestructure.Data.Configuration
{
    public class ClienteConfiguration : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.ToTable("Cliente");

            builder.HasKey(i => i.Id);
            builder.Property(i => i.Id);

            builder.HasIndex(p => p.IdCliente)
            .IsUnique();

            builder.Property(p => p.Nombre)
            .IsRequired()
            .HasMaxLength(50);

            builder.HasOne(p => p.TipoPersonas)
            .WithMany(p => p.Clientes)
            .HasForeignKey(p => p.IdTipoPersona);

            builder.Property(p => p.FechaRegistro)
            .HasColumnType("date");

            builder.HasOne(p => p.Municipios)
            .WithMany(p => p.Clientes)
            .HasForeignKey(p => p.IdMunicipio);
        }

        }
    }
