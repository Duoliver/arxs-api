using ArxsAPI.Data;
using ArxsAPI.Models;

namespace ArxsAPI.Repositories
{
    public class ScoreRepository(ArxsDbContext context) : EntityRepository<Score>(context)
    {
    }
}