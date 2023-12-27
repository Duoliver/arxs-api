using ArxsAPI.Models;

namespace ArxsAPI.Services
{
    public interface IService<T>
        where T : Entity
    {
        Task<T> Add(T model);
        Task<T> Update(T model);
        Task<T> GetById(int id);
        Task<List<T>> GetAll();
        Task<T> Delete(int id);
    }
}