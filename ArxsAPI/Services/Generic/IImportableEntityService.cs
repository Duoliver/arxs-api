using ArxsAPI.Models;

namespace ArxsAPI.Services
{
    public interface IImportableEntityService<T> : IService<T> where T : Entity
    {
        Task<List<T>> Import(Stream file);
    }
}