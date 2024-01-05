using ArxsAPI.Exceptions;
using ArxsAPI.Models;
using ArxsAPI.Repositories;

namespace ArxsAPI.Services
{
    public abstract class EntityService<TEntity>(EntityRepository<TEntity> repository)
        : IService<TEntity>
        where TEntity : Entity
    {
        private readonly EntityRepository<TEntity> Repository = repository;

        public async Task<TEntity> Add(TEntity model)
        {
            return await Repository.Add(model);
        }

        public async Task<TEntity> Delete(int id)
        {
            var model = await GetById(id);
            return await Repository.Delete(model);
        }

        public async Task<List<TEntity>> GetAll()
        {
            return await Repository.GetAll();
        }

        public async Task<TEntity> GetById(int id)
        {
            return await Repository.GetById(id);
        }

        public async Task<TEntity> Update(TEntity model)
        {
            return await Repository.Update(model);
        }
    }
}