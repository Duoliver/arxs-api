using ArxsAPI.Data;
using ArxsAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace ArxsAPI.Repositories
{
    public abstract class EntityRepository<TEntity>(ArxsDbContext context) : IRepository<TEntity>
        where TEntity : Entity
    {
        private readonly ArxsDbContext context = context;

        public async Task<TEntity> Add(TEntity model)
        {
            context.Set<TEntity>().Add(model);
            await context.SaveChangesAsync();
            return model;
        }

        public async Task<TEntity> Delete(int id)
        {
            var model = await context.Set<TEntity>().FindAsync(id);
            if (model == null)
            {
                return model;
            }

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
            return await context.Set<TEntity>().FindAsync(id);
        }

        public async Task<TEntity> Update(TEntity model)
        {
            context.Entry(model).State = EntityState.Modified;
            await context.SaveChangesAsync();
            return model;
        }
    }
}