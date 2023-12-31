using ArxsAPI.Data;
using ArxsAPI.Models;

namespace ArxsAPI.Repositories
{
    public class DriverRepository(ArxsDbContext context) : EntityRepository<Driver>(context)
    {
        public async Task<ICollection<Driver>> AddMany(ICollection<Driver> drivers)
        {
            context.Drivers.AddRange(drivers);
            await context.SaveChangesAsync();

            return drivers;
        }
    }
}