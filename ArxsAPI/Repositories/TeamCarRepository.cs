using ArxsAPI.Data;
using ArxsAPI.Models;

namespace ArxsAPI.Repositories
{
    public class TeamCarRepository(ArxsDbContext context) : EntityRepository<TeamCar>(context)
    {
    }
}