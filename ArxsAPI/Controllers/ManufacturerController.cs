using ArxsAPI.Models;
using ArxsAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace ArxsAPI.Controllers
{
    [Route("manufacturers")]
    [ApiController]
    public class ManufacturerController(ManufacturerService service)
        : ImportableEntityController<Manufacturer, ManufacturerService>(service)
    {
    }
}