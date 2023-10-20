using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Inventario : BaseEntity
    {
        public int CodIventario { get; set; }

        public Inventario IdPrenda { get; set; }

        public Prenda Prendas { get; set; }
        public double ValorVtaCop {get; set; }

        public ICollection<InventarioTalla> InventarioTallas { get; set; }

        public ICollection<DetalleVenta> DetalleVentas {get; set; }

       
    }
}