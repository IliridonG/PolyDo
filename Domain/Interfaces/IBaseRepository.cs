using Domain.Base;
using System.Linq.Expressions;

namespace Domain.Interfaces
{
    public interface IBaseRepository<T, TId> where T : class
    {
        Task<List<T>> GetAllAsync();

        Task AddAsync(T entity);

        Task UpdateAsync(T entity);

        Task DeleteAsync(TId id);

        Task<T> GetByIdAsync(TId id);
    }
}
