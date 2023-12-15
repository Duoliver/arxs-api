using ArxsAPI.Models;
using ArxsAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace ArxsAPI.Controllers
{
    [Route("countries")]
    [ApiController]
    public class CountryController(CountryService service) : EntityController<Country, CountryService>(service)
    {
        private readonly CountryService Service = service;
        
        [HttpPost("import")]
        [Consumes("multipart/form-data")]
        public async Task<IActionResult> Import([FromForm] IFormFile file)
        {
            if (file == null || file.Length == 0)
            {
                // TODO: create error object with message, isSuccess and isResponse attributes
                return BadRequest("Nenhum arquivo foi recebido");
            }
            return Ok(await Service.Import(file.OpenReadStream()));
        }
    }
}