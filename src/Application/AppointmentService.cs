using Domain.Entities;
using Domain.Interfaces;

namespace Application;

public class AppointmentService : IAppointmentService
{
    private readonly IUnitOfWork _uow;

    public AppointmentService(IUnitOfWork uow)
    {
        _uow = uow;
    }

    public async Task AddAppointmentAsync(Appointment appointment)
    {
        await _uow.Appointments.AddAsync(appointment);
        await _uow.SaveChangesAsync();
    }

    public async Task DeleteAppointmentAsync(int id)
    {
        var appointment = await _uow.Appointments.GetByIdAsync(id);
        if (appointment != null)
        {
            await _uow.Appointments.DeleteAsync(appointment);
            await _uow.SaveChangesAsync();
        }
    }

    public async Task<Appointment?> GetByIdAsync(int id)
    {
        return await _uow.Appointments.GetByIdAsync(id);
    }

    public async Task<IEnumerable<Appointment>> GetAppointmentsAsync()
    {
        return await _uow.Appointments.ListAsync();
    }

    public async Task UpdateAppointmentAsync(Appointment appointment)
    {
        await _uow.Appointments.UpdateAsync(appointment);
        await _uow.SaveChangesAsync();
    }
}
