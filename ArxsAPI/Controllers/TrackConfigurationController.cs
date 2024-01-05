using ArxsAPI.Models;
using ArxsAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace ArxsAPI.Controllers
{
    [Route("track-configurations")]
    [ApiController]
    public class TrackConfigurationController(TrackConfigurationService service)
        : ImportableEntityController<TrackConfiguration, TrackConfigurationService>(service)
    {
    }
}