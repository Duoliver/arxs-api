using ArxsAPI.Data;
using ArxsAPI.Models;

namespace ArxsAPI.Repositories
{
    public class CarRepository(ArxsDbContext context) : EntityRepository<Car>(context)
    {
    }
}