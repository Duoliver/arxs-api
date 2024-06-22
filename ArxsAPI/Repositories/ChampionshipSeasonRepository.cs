using ArxsAPI.Data;
using ArxsAPI.Models;

namespace ArxsAPI.Repositories
{
    public class ChampionshipSeasonRepository(ArxsDbContext context) : EntityRepository<ChampionshipSeason>(context)
    {
    }
}