using ArxsAPI.Models;
using ArxsAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace ArxsAPI.Controllers
{
    [Route("championship-season")]
    [ApiController]
    public class ChampionshipSeasonController(ChampionshipSeasonService service)
        : ImportableEntityController<ChampionshipSeason, ChampionshipSeasonService>(service)
    {
    }
}