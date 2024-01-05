using ArxsAPI.Data;
using ArxsAPI.Models;

namespace ArxsAPI.Repositories
{
    public class TrackConfigurationRepository(ArxsDbContext context) : EntityRepository<TrackConfiguration>(context)
    {
    }
}