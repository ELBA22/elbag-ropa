using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Dtos
{
    public class TallaDto
    {
        
        public string Descripcion {get; set; }

        public ICollection<DetalleVenta> DetalleVentas {get; set; }
        
    }
}