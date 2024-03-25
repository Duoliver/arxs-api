using ArxsAPI.Data;
using ArxsAPI.Models;

namespace ArxsAPI.Repositories
{
    public class SeasonRepository(ArxsDbContext context) : EntityRepository<Season>(context)
    {
    }
}