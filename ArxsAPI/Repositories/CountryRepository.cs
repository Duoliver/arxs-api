using ArxsAPI.Data;
using ArxsAPI.Models;

namespace ArxsAPI.Repositories
{
    public class CountryRepository(ArxsDbContext context) : EntityRepository<Country>(context)
    {
    }
}