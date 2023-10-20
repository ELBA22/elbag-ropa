using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Dtos
{
    public class InsumoDto
    {
        public string Nombre{ get; set; }

        public int ValorUn{ get; set; }
        
        public int StockMin{ get; set; }

        public int StockMax{ get; set; }

    }
}