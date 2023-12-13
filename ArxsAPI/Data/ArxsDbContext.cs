using Microsoft.EntityFrameworkCore;

namespace ArxsAPI.Data
{
    public class ArxsDbContext : DbContext
    {
        public ArxsDbContext(DbContextOptions<ArxsDbContext> options)
            : base(options)
        {

        }
    }
}