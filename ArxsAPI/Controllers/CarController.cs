using ArxsAPI.Models;
using ArxsAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace ArxsAPI.Controllers
{
    [Route("cars")]
    [ApiController]
    public class CarController(CarService service) : ImportableEntityController<Car, CarService>(service)
    {
    }
}
