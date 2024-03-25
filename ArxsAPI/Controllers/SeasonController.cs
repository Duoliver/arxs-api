using ArxsAPI.Models;
using ArxsAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace ArxsAPI.Controllers
{
    [Route("seasons")]
    [ApiController]
    public class SeasonController(SeasonService service)
        : ImportableEntityController<Season, SeasonService>(service)
    {
    }
}