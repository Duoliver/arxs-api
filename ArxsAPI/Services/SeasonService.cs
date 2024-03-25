using ArxsAPI.Models;
using ArxsAPI.Repositories;

namespace ArxsAPI.Services
{
    public class SeasonService(
        SeasonRepository repository,
        CsvService csvService
        ) : EntityService<Season>(repository), IImportableEntityService<Season>
    {
        private readonly SeasonRepository _repository = repository;

        private readonly CsvService _csvService = csvService;

        public async Task<List<Season>> Import(Stream file)
        {
            List<string[]> values = _csvService.GetStringsFromFile(file, ',');
            List<Season> seasons = [];

            values.ForEach(row =>
                {
                    string name = row[0];
                    int year = int.Parse(row[1]);

                    seasons.Add(new Season(name, year));
                }
            );

            await _repository.AddMany(seasons);

            return seasons;
        }
    }
}
