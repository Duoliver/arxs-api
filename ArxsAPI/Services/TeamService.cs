using ArxsAPI.Models;
using ArxsAPI.Repositories;

namespace ArxsAPI.Services
{
    public class TeamService : EntityService<Team>
    {
        private readonly TeamRepository Repository;
        private readonly CountryService CountryService;
        private readonly CsvService CsvService;

        public TeamService(
            TeamRepository repository,
            CountryService countryService,
            CsvService csvService
        ) : base(repository)
        {
            Repository = repository;
            CountryService = countryService;
            CsvService = csvService;
        }

        public async Task<List<Team>> Import(Stream file)
        {
            List<string[]> values = CsvService.GetStringsFromFile(file, ',');
            List<Team> teams = [];

            List<Country> countries = await CountryService.GetAll();
            
            if (countries.Count == 0)
            {
                throw new Exception("No countries found");
            }

            values.ForEach(row =>
                {
                    string name = row[0];
                    string iso3 = row[1];

                    var country = countries.Find(c => c.Iso3 == iso3);

                    if (country == null)
                    {
                        throw new Exception($"No country was found with the following ISO-3: { iso3 }");
                    }

                    teams.Add(new Team(name, country.Id, null));
                }
            );

            await Repository.AddMany(teams);

            return teams;
        }
    }
}