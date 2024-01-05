using ArxsAPI.Models;
using ArxsAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace ArxsAPI.Controllers
{
    [Route("tracks")]
    [ApiController]
    public class TrackController(TrackService service)
        : ImportableEntityController<Track, TrackService>(service)
    {
    }
}