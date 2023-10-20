using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Core.Entities;

namespace Core.Interfaces
{
    public interface IGenericRepository <T> where T : BaseEntity
    {
        Task<T> GetByIdAsync(int id);
        Task<IEnumerable<T>>GetAllAsync();
        IEnumerable<T> Find(Expression<Func<T, bool>> expression);

        Task<(int totalRegistros, IEnumerable<T> registros)> GetAllAsync(int pageIndex, int pageSize, String searrch);

        void Add (T Entities);

        void AddRange(IEnumerable<T> Entities);

        void Remove (T Entities);
        
        void RemoveRange(IEnumerable<T> Entities);

        void Update (T Entities);
        
    }
}