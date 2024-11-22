

namespace App
{
    public interface IRepository<T>
    {
        Task<T> GetByIdAsync(int id);
        Task<IEnumerable<T>> GetAllAsync();
        Task AddAsync(T entity);

        Task EditAsync(T entity);
        Task DeleteAsyn(int id);
    }
}
