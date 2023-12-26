using ArxsAPI.Models;
using ArxsAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace ArxsAPI.Controllers
{
    [Route("teams")]
    [ApiController]
    public class TeamController(TeamService service) : EntityController<Team, TeamService>(service)
    {
        private readonly TeamService Service = service;

        [HttpPost("import")]
        [Consumes("multipart/form-data")]
        public async Task<IActionResult> Import([FromForm] IFormFile file)
        {
            if (file == null || file.Length == 0)
            {
                // TODO: create error object with message, isSuccess and isResponse attributes
                return BadRequest("No file was received");
            }

            try 
            {
                return Ok(await Service.Import(file.OpenReadStream()));
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }

        }
    }
}