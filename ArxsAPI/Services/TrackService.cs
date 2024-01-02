using ArxsAPI.Common;
using ArxsAPI.Exceptions;
using ArxsAPI.Models;
using ArxsAPI.Repositories;

namespace ArxsAPI.Services
{
    public class TrackService(
        TrackRepository repository,
        CountryService countryService,
        CsvService csvService
        ) : EntityService<Track>(repository)
    {
        private readonly TrackRepository Repository = repository;
        private readonly CountryService CountryService = countryService;
        private readonly CsvService CsvService = csvService;

        public async Task<List<Track>> Import(Stream file)
        {
            List<string[]> values = CsvService.GetStringsFromFile(file, ',');
            List<Track> tracks = [];

            List<Country> countries = await CountryService.GetAll();
            
            if (EmptyHelper.IsEmpty(countries))
            {
                throw new CountryNotFoundException("No countries were found");
            }

            values.ForEach(row =>
                {
                    string name = row[0];
                    string city = row[1];
                    string countryIso3 = row[2];

                    var country = CountryHelper.FindCountry(countryIso3, countries);

                    Track track = new(name, country.Id);

                    if (EmptyHelper.IsNotEmpty(city))
                    {
                        track.City = city;
                    }

                    tracks.Add(track);
                }
            );

            // await Repository.AddMany(tracks);

            return tracks;
        }
    }
}