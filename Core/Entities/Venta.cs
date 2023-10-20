using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Venta :BaseEntity
    {
        public DateOnly Fecha {get; set; }

        public int IdEmpleado {get; set; }

        public Empleado Empleados {get; set; }

        public int IdCliente {get; set; }

        public Cliente Clientea {get; set; }

        public int FormaPago {get; set; }

        public FormaPago FormaPagos {get; set;}

        public ICollection<DetalleVenta> DetalleVentas  {get; set; }
        
    }
}