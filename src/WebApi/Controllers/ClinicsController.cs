using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ClinicsController : ControllerBase
{
    private readonly IUnitOfWork _uow;

    public ClinicsController(IUnitOfWork uow)
    {
        _uow = uow;
    }

    [HttpGet]
    public async Task<IEnumerable<Clinic>> Get()
    {
        return await _uow.Clinics.ListAsync();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Clinic>> Get(int id)
    {
        var entity = await _uow.Clinics.GetByIdAsync(id);
        if (entity == null)
            return NotFound();
        return entity;
    }

    [HttpPost]
    public async Task<ActionResult> Post(Clinic clinic)
    {
        await _uow.Clinics.AddAsync(clinic);
        await _uow.SaveChangesAsync();
        return CreatedAtAction(nameof(Get), new { id = clinic.Id }, clinic);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, Clinic clinic)
    {
        if (id != clinic.Id)
            return BadRequest();
        await _uow.Clinics.UpdateAsync(clinic);
        await _uow.SaveChangesAsync();
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var entity = await _uow.Clinics.GetByIdAsync(id);
        if (entity == null)
            return NotFound();
        await _uow.Clinics.DeleteAsync(entity);
        await _uow.SaveChangesAsync();
        return NoContent();
    }
}
