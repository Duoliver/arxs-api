using ArxsAPI.Models;
using ArxsAPI.Repositories;

namespace ArxsAPI.Services
{
    public class ScoreService(
        ScoreRepository repository
        ) : EntityService<Score>(repository)
    {
        private readonly ScoreRepository _repository = repository;

        public async Task<List<Score>> CreateMany(List<Score> scores)
        {
            return (List<Score>)await _repository.AddMany(scores);
        }
    }
}