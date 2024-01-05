using ArxsAPI.Data;
using ArxsAPI.Models;

namespace ArxsAPI.Repositories
{
    public class TrackRepository(ArxsDbContext context) : EntityRepository<Track>(context)
    {
    }
}