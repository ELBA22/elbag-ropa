using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;
using Infraestructure.Data;

namespace Infraestructure.Repositories
{
    public class DepartamentoRepository : GenericRepository<Departamento>, IDepartamento
    {
        private readonly elbaRopaContext _context;
        public DepartamentoRepository(elbaRopaContext context) : base(context)
        {
            _context = context;
        }
    }
}