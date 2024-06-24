using ArxsAPI.Models;
using ArxsAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace ArxsAPI.Controllers
{
    [Route("trophy")]
    [ApiController]
    public class TrophyController(TrophyService service)
        : ImportableEntityController<Trophy, TrophyService>(service)
    {
    }
}