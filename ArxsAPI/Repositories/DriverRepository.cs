using ArxsAPI.Data;
using ArxsAPI.Models;

namespace ArxsAPI.Repositories
{
    public class DriverRepository(ArxsDbContext context) : EntityRepository<Driver>(context)
    {
    }
}