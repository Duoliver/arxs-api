using ArxsAPI.Common;
using ArxsAPI.Exceptions;
using ArxsAPI.Models;
using ArxsAPI.Repositories;

namespace ArxsAPI.Services
{
    public class DriverService(
        DriverRepository repository,
        CountryService countryService,
        CsvService csvService
        ) : EntityService<Driver>(repository), IImportableEntityService<Driver>
    {
        private readonly DriverRepository Repository = repository;
        private readonly CountryService CountryService = countryService;
        private readonly CsvService CsvService = csvService;

        public async Task<List<Driver>> Import(Stream file)
        {
            List<string[]> values = CsvService.GetStringsFromFile(file, ',');
            List<Driver> drivers = [];

            List<Country> countries = await CountryService.GetAll();
            
            if (countries.Count == 0)
            {
                throw new CountryNotFoundException("No countries were found");
            }

            values.ForEach(row =>
                {
                    string name = row[0];
                    string surname = row[1];
                    string dob = row[2];
                    string city = row[3];
                    string country_iso3 = row[4];
                    string nationality_iso3 = row[5];

                    var countryOfOrigin = FindCountry(country_iso3, countries);
                    var nationality = FindCountry(nationality_iso3, countries);

                    Driver driver = new(name, surname, countryOfOrigin.Id, nationality.Id);

                    if (dob.Length > 0)
                    {
                        driver.DateOfBirth = DateHelper.GetDateFromString(dob);
                    }

                    if (city != "")
                    {
                        driver.CityOfOrigin = city;
                    }

                    drivers.Add(driver);
                }

            );
            await Repository.AddMany(drivers);

            return drivers;
        }

        private static Country FindCountry(string iso3, List<Country> list)
        {
            var country = list.Find(c => c.Iso3 == iso3);
            if (country == null)
            {
                throw new CountryNotFoundException($"No country was found with the following ISO-3: { iso3 }");
            }
            return country;
        }
    }
}