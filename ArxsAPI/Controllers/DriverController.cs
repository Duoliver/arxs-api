using ArxsAPI.Models;
using ArxsAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace ArxsAPI.Controllers
{
    [Route("drivers")]
    [ApiController]
    public class DriverController(DriverService service)
        : ImportableEntityController<Driver, DriverService>(service)
    {
    }
}
