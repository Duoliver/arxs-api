using ArxsAPI.Data;
using ArxsAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace ArxsAPI.Repositories
{
    public class CountryRepository(ArxsDbContext context) : EntityRepository<Country>(context)
    {
        public async Task<Country> GetByIso3(string iso3)
        {
            var query = context.Countries.Where(c => c.Iso3 == iso3);

            return await query.FirstAsync();
        }
    }
}