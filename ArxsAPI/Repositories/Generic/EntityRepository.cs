using ArxsAPI.Common;
using ArxsAPI.Data;
using ArxsAPI.Exceptions;
using ArxsAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace ArxsAPI.Repositories
{
    public abstract class EntityRepository<TEntity>(ArxsDbContext context) : IRepository<TEntity>
        where TEntity : Entity
    {
        protected readonly ArxsDbContext context = context;

        public async Task<TEntity> Add(TEntity model)
        {
            context.Set<TEntity>().Add(model);
            await context.SaveChangesAsync();
            return model;
        }

        public async Task<TEntity> Delete(TEntity model)
        {
            context.Set<TEntity>().Remove(model);
            await context.SaveChangesAsync();

            return model;
        }

        public async Task<List<TEntity>> GetAll()
        {
            return await context.Set<TEntity>().ToListAsync();
        }

        public async Task<TEntity> GetById(int id)
        {
            var model = await context.Set<TEntity>().FindAsync(id);
            if (EmptyHelper.IsEmpty(model))
            {
                throw new EntityNotFoundException($"Could not found an entity of the requested model with ID {id}");
            }

            return model!;
        }

        public async Task<TEntity> Update(TEntity model)
        {
            context.Entry(model).State = EntityState.Modified;
            await context.SaveChangesAsync();

            return model;
        }

        public async Task<ICollection<TEntity>> AddMany(ICollection<TEntity> models)
        {
            context.Set<TEntity>().AddRange(models);
            await context.SaveChangesAsync();

            return models;
        }
    }
}