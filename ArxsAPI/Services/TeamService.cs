using ArxsAPI.Exceptions;
using ArxsAPI.Models;
using ArxsAPI.Repositories;

namespace ArxsAPI.Services
{
    public class TeamService(
        TeamRepository repository,
        CountryService countryService,
        CsvService csvService
        ) : EntityService<Team>(repository), IImportableEntityService<Team>
    {
        private readonly TeamRepository Repository = repository;
        private readonly CountryService CountryService = countryService;
        private readonly CsvService CsvService = csvService;

        public async Task<List<Team>> Import(Stream file)
        {
            List<string[]> values = CsvService.GetStringsFromFile(file, ',');
            List<Team> teams = [];

            List<Country> countries = await CountryService.GetAll();
            
            if (countries.Count == 0)
            {
                throw new CountryNotFoundException("No countries were found");
            }

            values.ForEach(row =>
                {
                    string name = row[0];
                    string iso3 = row[1];

                    var country = countries.Find(c => c.Iso3 == iso3);

                    if (country == null)
                    {
                        throw new CountryNotFoundException($"No country was found with the following ISO-3: { iso3 }");
                    }

                    teams.Add(new Team(name, country.Id, null));
                }
            );

            await Repository.AddMany(teams);

            return teams;
        }
    }
}