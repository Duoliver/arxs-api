using ArxsAPI.Data;
using ArxsAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace ArxsAPI.Repositories
{
    public class TeamRepository(ArxsDbContext context) : EntityRepository<Team>(context)
    {
        public async Task<Team> GetByName(string name)
        {
            var query = context.Teams.Where(t => t.Name == name);

            return await query.FirstAsync();
        }
    }
}