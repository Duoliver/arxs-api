using ArxsAPI.Data;
using ArxsAPI.Models;

namespace ArxsAPI.Repositories
{
    public class ScoreSystemRepository(ArxsDbContext context) : EntityRepository<ScoreSystem>(context)
    {
    }
}