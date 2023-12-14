using ArxsAPI.Models;
using ArxsAPI.Repositories;

namespace ArxsAPI.Services
{
    public class CountryService(CountryRepository repository) : EntityService<Country>(repository)
    {
        public async Task<List<Country>> Import(Stream file)
        {
            List<Country> Countries = new List<Country>();
            using (var reader = new StreamReader(file))
            {
                var header = reader.ReadLine();
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine()!;
                    var values = line.Split(',');

                    Country CurrentCountry = new();

                    string Name = values[0];
                    string Iso3 = values[1];
                    string Adjective = values[2];

                    CurrentCountry.Name = Name;
                    CurrentCountry.Iso3 = Iso3;
                    CurrentCountry.Adjective = Adjective;

                    Countries.Add(CurrentCountry);
                }
            }
            await Task.Run(() => {});
            return Countries;
        }
    }
}