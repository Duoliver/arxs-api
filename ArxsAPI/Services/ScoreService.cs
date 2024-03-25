using ArxsAPI.Models;
using ArxsAPI.Repositories;

namespace ArxsAPI.Services
{
    public class ScoreService(
        ScoreRepository repository
        ) : EntityService<Score>(repository)
    {
    }
}