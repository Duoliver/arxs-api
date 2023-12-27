using ArxsAPI.Models;
using ArxsAPI.Responses;
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
                return BadRequest(new Response("No file was received", false));
            }

            try 
            {
                return Ok(new PayloadResponse<List<Team>>(
                    await Service.Import(file.OpenReadStream())
                ));
            }
            catch (Exception e)
            {
                return BadRequest(new Response(e.Message, false));
            }

        }
    }
}