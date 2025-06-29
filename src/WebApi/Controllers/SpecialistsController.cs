using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class SpecialistsController : ControllerBase
{
    private readonly IUnitOfWork _uow;

    public SpecialistsController(IUnitOfWork uow)
    {
        _uow = uow;
    }

    [HttpGet]
    public async Task<IEnumerable<Specialist>> Get()
    {
        return await _uow.Specialists.ListAsync();
    }
}
