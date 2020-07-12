using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OnionSample.Common.Interfaces
{
    public interface IRepository<T, TId> where T: BaseEntity<TId>
    {
        Task<T> GetByIdAsync(TId id);
        Task<List<T>> ListAsync();
        Task<T> AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);
    }
}
