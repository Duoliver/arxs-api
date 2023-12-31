using ArxsAPI.Models;
using ArxsAPI.Repositories;

namespace ArxsAPI.Services
{
    public abstract class EntityService<TEntity> : IService<TEntity>
        where TEntity : Entity
    {
        private readonly EntityRepository<TEntity> Repository;
        
        public EntityService(EntityRepository<TEntity> repository)
        {
            Repository = repository;
        }

        public async Task<TEntity> Add(TEntity model)
        {
            return await Repository.Add(model);
        }

        public async Task<TEntity> Delete(int id)
        {
            var deletedModel = await Repository.Delete(id);
            if (deletedModel == null)
            {
                // TODO handle model not found 
            }
            return deletedModel;
        }

        public async Task<List<TEntity>> GetAll()
        {
            return await Repository.GetAll();
        }

        public async Task<TEntity> GetById(int id)
        {
            var foundModel = await Repository.GetById(id);
            if (foundModel == null)
            {
                 // TODO handle model not found
            }
            return foundModel;
        }

        public async Task<TEntity> Update(TEntity model)
        {
            return await Repository.Update(model);
        }
    }
}