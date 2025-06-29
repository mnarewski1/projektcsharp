using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PatientsController : ControllerBase
{
    private readonly IUnitOfWork _uow;

    public PatientsController(IUnitOfWork uow)
    {
        _uow = uow;
    }

    [HttpGet]
    public async Task<IEnumerable<Patient>> Get()
    {
        return await _uow.Patients.ListAsync();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Patient>> Get(int id)
    {
        var entity = await _uow.Patients.GetByIdAsync(id);
        if (entity == null)
            return NotFound();
        return entity;
    }

    [HttpPost]
    public async Task<ActionResult> Post(Patient patient)
    {
        await _uow.Patients.AddAsync(patient);
        await _uow.SaveChangesAsync();
        return CreatedAtAction(nameof(Get), new { id = patient.Id }, patient);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, Patient patient)
    {
        if (id != patient.Id)
            return BadRequest();
        await _uow.Patients.UpdateAsync(patient);
        await _uow.SaveChangesAsync();
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var entity = await _uow.Patients.GetByIdAsync(id);
        if (entity == null)
            return NotFound();
        await _uow.Patients.DeleteAsync(entity);
        await _uow.SaveChangesAsync();
        return NoContent();
    }
}
