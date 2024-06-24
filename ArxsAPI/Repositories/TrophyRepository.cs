using ArxsAPI.Data;
using ArxsAPI.Models;

namespace ArxsAPI.Repositories
{
    public class TrophyRepository(ArxsDbContext context) : EntityRepository<Trophy>(context)
    {
    }
}