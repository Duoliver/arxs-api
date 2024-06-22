using ArxsAPI.Common;
using ArxsAPI.Models;
using ArxsAPI.Responses;
using ArxsAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace ArxsAPI.Controllers
{
    public abstract class ImportableEntityController<TEntity, TService>(TService service) : EntityController<TEntity, TService>(service)
        where TEntity : Entity
        where TService : EntityService<TEntity>, IImportableEntityService<TEntity>
    {
        [HttpPost("import")]
        [Consumes("multipart/form-data")]
        public async Task<IActionResult> Import(IFormFile file)
        {
            if (EmptyHelper.IsEmpty(file))
            {
                return BadRequest(new Response("No file was received", false));
            }

            try 
            {
                return Ok(new PayloadResponse<List<TEntity>>(
                    await service.Import(file.OpenReadStream())
                ));
            }
            catch (Exception e)
            {
                return BadRequest(new Response(e.Message, false));
            }
        }
    }
}