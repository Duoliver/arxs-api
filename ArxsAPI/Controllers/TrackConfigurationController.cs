using ArxsAPI.Common;
using ArxsAPI.Models;
using ArxsAPI.Responses;
using ArxsAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace ArxsAPI.Controllers
{
    [Route("track-configurations")]
    [ApiController]
    public class TrackConfigurationController(TrackConfigurationService service) : EntityController<TrackConfiguration, TrackConfigurationService>(service)
    {
        [HttpPost("import")]
        [Consumes("multipart/form-data")]
        public async Task<IActionResult> Import([FromForm] IFormFile file)
        {
            if (EmptyHelper.IsEmpty(file))
            {
                return BadRequest(new Response("No file was received", false));
            }

            try
            {
                return Ok(new PayloadResponse<List<TrackConfiguration>>(
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