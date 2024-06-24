using ArxsAPI.Models;
using ArxsAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace ArxsAPI.Controllers
{
    [Route("championships")]
    [ApiController]
    public class ChampionshipController(ChampionshipService service)
        : ImportableEntityController<Championship, ChampionshipService>(service)
    {
    }
}