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

        public async Task<ICollection<Team>> AddMany(ICollection<Team> teams)
        {
            context.Teams.AddRange(teams);
            await context.SaveChangesAsync();

            return teams;
        }
    }
}