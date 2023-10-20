using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Dtos
{
    public class PrendaDto
    {
        public int IdPrenda { get; set; }

        public string Nombre { get; set; }

        public int ValorUniCop{ get; set; }        

        public int ValorUniUsd { get; set; }

        public int IdEstado  { get; set; }

        

        public int IdTipoProteccion { get; set; }

        

        public int IdGenero { get; set; }

        
    }
}