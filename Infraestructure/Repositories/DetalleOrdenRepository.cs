using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;
using Infraestructure.Data;

namespace Infraestructure.Repositories
{
    public class DetalleOrdenRepository : GenericRepository<DetalleOrden>, IDetalleOrden
    {
        private readonly elbaRopaContext _context;
        public DetalleOrdenRepository(elbaRopaContext context) : base(context)
        {
            _context = context;
        }
    }
}