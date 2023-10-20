using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;
using Infraestructure.Data;

namespace Infraestructure.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        private readonly elbaRopaContext _context;

        public GenericRepository(elbaRopaContext context)
        {
            _context = context;

        }
        public void Add(T Entities)
        {
            throw new NotImplementedException();
        }

        public void AddRange(IEnumerable<T> Entities)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> Find(Expression<Func<T, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<T>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<(int totalRegistros, IEnumerable<T> registros)> GetAllAsync(int pageIndex, int pageSize, string searrch)
        {
            throw new NotImplementedException();
        }

        public Task<T> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(T Entities)
        {
            throw new NotImplementedException();
        }

        public void RemoveRange(IEnumerable<T> Entities)
        {
            throw new NotImplementedException();
        }

        public void Update(T Entities)
        {
            throw new NotImplementedException();
        }
    }
}