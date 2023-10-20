using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestructure.Data.Configuration
{
    public class InsumoProveedor : IEntityTypeConfiguration<InsumoProveedor>
    {
    
        public void Configure(EntityTypeBuilder<InsumoProveedor> builder)
        {
            builder.ToTable("InsumoProveedor");

            builder.HasOne( F => F.Insumos)
            .WithMany(F => F.InsumoProveedores)
            .HasForeignKey(F => F.IdInsumo);

            builder.HasOne( F => F.Proveedor)
            .WithMany( F => F.InsumoProveedores)
            .HasForeignKey(F => F.IdProveedores);



            
        }
    }
}