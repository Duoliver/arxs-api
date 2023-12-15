using ArxsAPI.Data;
using ArxsAPI.Models;

namespace ArxsAPI.Repositories
{
    public class CountryRepository(ArxsDbContext context) : EntityRepository<Country>(context)
    {
        public async Task<ICollection<Country>> AddMany(ICollection<Country> countries)
        {
            context.Set<Country>().AddRange(countries);
            await context.SaveChangesAsync();
            return countries;
        }
    }
}