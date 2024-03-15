using ArxsAPI.Models;
using ArxsAPI.Responses;
using ArxsAPI.Services;
using DTOs;
using Microsoft.AspNetCore.Mvc;

namespace ArxsAPI.Controllers
{
    [Route("score-systems")]
    [ApiController]
    public class ScoreSystemController(
        ScoreSystemService service
        ) : EntityController<ScoreSystem, ScoreSystemService>(service)
    {
        [HttpPost("")]
        public async Task<IActionResult> CreateMany(
            [FromBody] List<CreateScoreSystemRequestDTO> requests
            )
        {
            try
            {
                return Ok(new PayloadResponse<List<ScoreSystem>>(
                    await service.CreateMany(requests)
                ));
            }
            catch (Exception e)
            {
                return BadRequest(new Response(e.Message, false));
            }
        }
    }
}