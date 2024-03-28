using ArxsAPI.Data;
using ArxsAPI.Models;

namespace ArxsAPI.Repositories
{
    public class ChampionshipRepository(ArxsDbContext context) : EntityRepository<Championship>(context)
    {
    }
}