using ArxsAPI.Data;
using ArxsAPI.Models;

namespace ArxsAPI.Repositories
{
    public class ManufacturerRepository(ArxsDbContext context) : EntityRepository<Manufacturer>(context)
    {
        
    }
    
}