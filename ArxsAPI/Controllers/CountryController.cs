using ArxsAPI.Models;
using ArxsAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace ArxsAPI.Controllers
{
    [Route("countries")]
    [ApiController]
    public class CountryController(CountryService service)
        : ImportableEntityController<Country, CountryService>(service)
    {
    }
}