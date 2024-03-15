using System.Transactions;
using ArxsAPI.Common;
using ArxsAPI.Models;
using ArxsAPI.Repositories;
using DTOs;

namespace ArxsAPI.Services
{
    public class ScoreSystemService(
        ScoreSystemRepository repository,
        ScoreService scoreService
        ) : EntityService<ScoreSystem>(repository)
    {
        private readonly ScoreSystemRepository _repository = repository;
        private readonly ScoreService _scoreService = scoreService;

        public async Task<List<ScoreSystem>> CreateMany(List<CreateScoreSystemRequestDTO> requests)
        {
            // var transaction = _repository.GetContext().Database.BeginTransaction();
            List<ScoreSystem> scoreSystems = [];
            try {
                int requestIndex = 0;
                requests.ForEach(request =>
                    {
                        if (EmptyHelper.IsEmpty(request.Alias) || EmptyHelper.IsEmpty(request.Scores))
                        {
                            // throw new InvalidRequestException()
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
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                if (e is TransactionException)
                {

                }
                else {
                    throw;
                }
            }
            await Task.Run(() => {});
            return scoreSystems;
            // try
            // {

            //     // await _repository.AddMany(scoreSystems);

            //     // await _scoreService.CreateMany(scores);
            //     // transaction.Commit();
            //     // await transaction.RollbackAsync();
            // }
            // catch (Exception)
            // {
            //     // transaction.Rollback();
            // }
            // Precisa retornar com a lista de pontos
        }
    }
}