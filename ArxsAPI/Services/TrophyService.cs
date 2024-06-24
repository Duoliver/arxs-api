using ArxsAPI.Enums;
using ArxsAPI.Models;
using ArxsAPI.Repositories;

namespace ArxsAPI.Services
{
    public class TrophyService(
        TrophyRepository repository,
        CsvService csvService
    ) : EntityService<Trophy>(repository), IImportableEntityService<Trophy>
    {
        private readonly TrophyRepository _repository = repository;
        private readonly CsvService _csvService = csvService;

        public async Task<List<Trophy>> Import(Stream file)
        {
            List<string[]> values = _csvService.GetStringsFromFile(file, ',');
            List<Trophy> trophies = [];

            values.ForEach(row =>
                {
                    string name = row[0];
                    string type = row[1];

                    TrophyType trophyType = GetTrophyType(type);

                    trophies.Add(new Trophy(name, trophyType));
                }
            );

            await _repository.AddMany(trophies);

            return trophies;
        }

        private static TrophyType GetTrophyType(string type)
        {
            return type.ToLower() switch
            {
                "teams" => TrophyType.Teams,
                "drivers" => TrophyType.Drivers,
                // TODO: Ditch generic exception for a proper class instead.
                _ => throw new Exception($"Could not find type {type}"),
            };
        }
    }
}