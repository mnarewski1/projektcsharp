using Application;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AppointmentsController : ControllerBase
{
    private readonly IAppointmentService _service;

    public AppointmentsController(IAppointmentService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<IEnumerable<Appointment>> Get()
    {
        return await _service.GetAppointmentsAsync();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Appointment>> Get(int id)
    {
        var appt = await _service.GetByIdAsync(id);
        if (appt == null)
            return NotFound();
        return appt;
    }

    [HttpPost]
    public async Task<ActionResult> Post(Appointment appointment)
    {
        await _service.AddAppointmentAsync(appointment);
        return CreatedAtAction(nameof(Get), new { id = appointment.Id }, appointment);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, Appointment appointment)
    {
        if (id != appointment.Id)
            return BadRequest();
        await _service.UpdateAppointmentAsync(appointment);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        await _service.DeleteAppointmentAsync(id);
        return NoContent();
    }
}
