using ArxsAPI.Exceptions;
using ArxsAPI.Models;
using ArxsAPI.Repositories;

namespace ArxsAPI.Services
{
    public class ChampionshipSeasonService(
        ChampionshipSeasonRepository repository,
        CsvService csvService,
        SeasonService seasonService,
        ChampionshipService championshipService
    ) : EntityService<ChampionshipSeason>(repository), IImportableEntityService<ChampionshipSeason>
    {
        private readonly ChampionshipSeasonRepository _repository = repository;
        private readonly CsvService _csvService = csvService;
        private readonly SeasonService _seasonService = seasonService;
        private readonly ChampionshipService _championshipService = championshipService;

        public async Task<List<ChampionshipSeason>> Import(Stream file)
        {
            List<string[]> values = _csvService.GetStringsFromFile(file, ',');
            List<ChampionshipSeason> championshipSeasons = [];

            List<Season> seasons = await _seasonService.GetAll();
            List<Championship> championships = await _championshipService.GetAll();

            values.ForEach(row =>
                {
                    string seasonAlias = row[0];
                    string championshipAlias = row[1];

                    var season = seasons.Find(c => c.Name == seasonAlias)
                        ?? throw new EntityNotFoundException($"No season was found with the following name: { seasonAlias }");

                    var championship = championships.Find(c => c.Alias == championshipAlias)
                        ?? throw new EntityNotFoundException($"No championship was found with the following alias: { championshipAlias }");

                    championshipSeasons.Add(new ChampionshipSeason(season.Id, championship.Id));
                }
            );

            await _repository.AddMany(championshipSeasons);

            return championshipSeasons;
        }
    }
}