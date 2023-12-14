using ArxsAPI.Models;
using ArxsAPI.Repositories;

namespace ArxsAPI.Services
{
    public abstract class EntityService<TEntity> : IService<TEntity>
        where TEntity : Entity
    {
        private readonly EntityRepository<TEntity> _repository;
        
        public EntityService(EntityRepository<TEntity> repository)
        {
            _repository = repository;
        }

        public async Task<TEntity> Add(TEntity model)
        {
            return await _repository.Add(model);
        }

        public async Task<TEntity> Delete(int id)
        {
            var deletedModel = await _repository.Delete(id);
            if (deletedModel == null)
            {
                // TODO handle model not found 
            }
            return deletedModel;
        }

        public async Task<List<TEntity>> GetAll()
        {
            return await _repository.GetAll();
        }

        public async Task<TEntity> GetById(int id)
        {
            var foundModel = await _repository.GetById(id);
            if (foundModel == null)
            {
                 // TODO handle model not found
            }
            return foundModel;
        }

        public async Task<TEntity> Update(TEntity model)
        {
            return await _repository.Update(model);
        }
    }
}