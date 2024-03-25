using System.Transactions;
using ArxsAPI.Common;
using ArxsAPI.Exceptions;
using ArxsAPI.Models;
using ArxsAPI.Repositories;
using DTOs;

namespace ArxsAPI.Services
{
    public class ScoreSystemService(
        ScoreSystemRepository repository
        ) : EntityService<ScoreSystem>(repository)
    {
        private readonly ScoreSystemRepository _repository = repository;

        public async Task<List<ScoreSystem>> CreateMany(List<CreateScoreSystemRequestDTO> requests)
        {
            var transaction = _repository.GetContext().Database.BeginTransaction();
            List<ScoreSystem> scoreSystems = [];
            try {
                int requestIndex = 0;
                requests.ForEach(request =>
                    {
                        if (EmptyHelper.IsEmpty(request.Alias) || EmptyHelper.IsEmpty(request.Scores))
                        {
                            throw new InvalidRequestException($"No alias or score list were sent for the score system of index {requestIndex}");
                        }
                        ScoreSystem scoreSystem;
                        int scoreIndex = 0;
                        List<Score> scores = [];
                        request.Scores.ForEach(pointsAmount =>
                            {
                                int position = scoreIndex + 1;
                                scores.Add(new Score(position, pointsAmount));
                                scoreIndex ++;
                            }
                        );
                        scoreSystem = new()
                        {
                            Alias = request.Alias,
                            Scores = scores
                        };
                        scoreSystems.Add(scoreSystem);
                        requestIndex ++;
                    }
                );
                await _repository.AddMany(scoreSystems);
                transaction.Commit();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                if (e is TransactionException)
                {
                    await transaction.RollbackAsync();

                }
                throw;
            }
            return scoreSystems;
        }
    }
}