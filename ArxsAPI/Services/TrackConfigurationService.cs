using ArxsAPI.Common;
using ArxsAPI.Exceptions;
using ArxsAPI.Models;
using ArxsAPI.Repositories;

namespace ArxsAPI.Services
{
    public class TrackConfigurationService(
        TrackConfigurationRepository repository,
        TrackService trackService,
        CsvService csvService
        ) : EntityService<TrackConfiguration>(repository), IImportableEntityService<TrackConfiguration>
    {
        private readonly TrackConfigurationRepository _repository = repository;
        private readonly TrackService _trackService = trackService;
        private readonly CsvService _csvService = csvService;

        public async Task<List<TrackConfiguration>> Import(Stream file)
        {
            List<string[]> values = _csvService.GetStringsFromFile(file, ',');
            List<TrackConfiguration> trackConfigurations = [];

            List<Track> tracks = await _trackService.GetAll();

            if (EmptyHelper.IsEmpty(tracks))
            {
                throw new TrackNotFoundException("No tracks were found");
            }

            values.ForEach(row =>
                {
                    string name = row[0];
                    int year = int.Parse(row[1]);
                    string trackName = row[2];

                    var track = TrackHelper.FindByName(trackName, tracks);

                    TrackConfiguration trackConfiguration = new(name, year, track.Id);

                    trackConfigurations.Add(trackConfiguration);
                }
            );

            await _repository.AddMany(trackConfigurations);

            return trackConfigurations;
        }
    }
}