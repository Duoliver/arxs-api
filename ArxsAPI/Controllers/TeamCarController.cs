using ArxsAPI.Models;
using ArxsAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace ArxsAPI.Controllers
{
    [Route("team-cars")]
    [ApiController]
    public class TeamCarController(TeamCarService service) : ImportableEntityController<TeamCar, TeamCarService>(service)
    {
    }
}
