using ArxsAPI.Models;
using ArxsAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace ArxsAPI.Controllers
{
    [Route("teams")]
    [ApiController]
    public class TeamController(TeamService service)
        : ImportableEntityController<Team, TeamService>(service)
    {
    }
}