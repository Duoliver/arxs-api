using ArxsAPI.Models;
using ArxsAPI.Repositories;

namespace ArxsAPI.Services
{
    public class ChampionshipService(
        ChampionshipRepository repository,
        CsvService csvService
        ) : EntityService<Championship>(repository), IImportableEntityService<Championship>
    {

        private readonly ChampionshipRepository _repository = repository;
        private readonly CsvService _csvService = csvService;

        public async Task<List<Championship>> Import(Stream file)
        {
            List<string[]> values = _csvService.GetStringsFromFile(file, ',');
            List<Championship> championships = [];

            values.ForEach(row =>
                {
                    string name = row[0];
                    string alias = row[1];
                    // string previous = row[2];

                    championships.Add(new Championship(name, alias));
                }
            );

            await _repository.AddMany(championships);

            return championships;
        }
    }
}