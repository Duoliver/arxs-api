using ArxsAPI.Models;

namespace ArxsAPI.Repositories
{
    public interface IRepository<T>
        where T : Entity
    {
        Task<T> Add(T model);
        Task<T> Delete(int id);
        Task<T> Update(T model);
        Task<T> GetById(int id);
        Task<List<T>> GetAll();
    }
}