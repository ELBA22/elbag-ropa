using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Dtos
{
    public class EmpleadoDto
    {
        public int IdEmpleado { get; set; }

        public string Nombre { get; set; }
        public int IdCargo { get; set; }

        

        public int FechaIngreso{ get; set; }

        public int IdMunicipio {get; set; }

        

    }
}