using ArxsAPI.Models;
using ArxsAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace ArxsAPI.Controllers
{
    public abstract class EntityController<TEntity, TService>(TService service) : Controller
        where TEntity : Entity
        where TService : EntityService<TEntity>
    {
        private readonly TService Service = service;
    }
}