using ArxsAPI.Exceptions;
using ArxsAPI.Models;
using ArxsAPI.Repositories;

namespace ArxsAPI.Services
{
    public class ManufacturerService(
        ManufacturerRepository repository,
        CountryService countryService,
        CsvService csvService
        ) : EntityService<Manufacturer>(repository), IImportableEntityService<Manufacturer>
    {
        private readonly ManufacturerRepository Repository = repository;
        private readonly CountryService CountryService = countryService;
        private readonly CsvService CsvService = csvService;

        public async Task<List<Manufacturer>> Import(Stream file)
        {
            List<string[]> values = CsvService.GetStringsFromFile(file, ',');
            List<Manufacturer> manufacturers = [];

            List<Country> countries = await CountryService.GetAll();

            if (countries.Count == 0)
            {
                throw new CountryNotFoundException("No countries were found");
            }

            values.ForEach(row =>
                {
                    string name = row[0];
                    string country_iso3 = row[1];

                    var country = countries.Find(c => c.Iso3 == country_iso3);

                    if (country == null)
                    {
                        throw new CountryNotFoundException($"No country was found with the following ISO-3: { country_iso3 }");
                    }

                    manufacturers.Add(new Manufacturer(name, country.Id));
                }
            );

            await Repository.AddMany(manufacturers);

            return manufacturers;
        }
    }
}