using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using Core.Interfaces;
using Infraestructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infraestructure.Repositories
{
    public class ColorRepository : GenericRepository<Color>, IColorres
    {
        private readonly elbaRopaContext context; 
        public ColorRepository(elbaRopaContext context) : base(context)
        {
            this.context = context;
        }
    }
}