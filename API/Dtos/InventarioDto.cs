using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Dtos
{
    public class InventarioDto
    {
        public int CodIventario { get; set; }

        

        
        public double ValorVtaCop {get; set; }

        

        public ICollection<DetalleVenta> DetalleVentas { get; set; }
    }
}