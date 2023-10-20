using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestructure.Data.Configuration
{
    public class InsumoPrendaConfiguration : IEntityTypeConfiguration<InsumoPrenda>
    {
        public void Configure(EntityTypeBuilder<InsumoPrenda> builder)
        {
            builder.ToTable("InsumoPrenda");

            builder.HasOne(i => i.Insumos)
            .WithMany(i => i.InsumoPrendas)
            .HasForeignKey(i => i.IdInsumo);
            
            builder.HasOne(p => p.Prendas)
            .WithMany(p => p.InsumoPrendas)
            .HasForeignKey(p => p.IdPrenda);

            builder.Property(p => p.Cantidad)
            .HasColumnType("int");
        }

    }
}
