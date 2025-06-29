using Domain.Entities;

namespace Application;

public interface IAppointmentService
{
    Task<IEnumerable<Appointment>> GetAppointmentsAsync();
    Task<Appointment?> GetByIdAsync(int id);
    Task AddAppointmentAsync(Appointment appointment);
    Task UpdateAppointmentAsync(Appointment appointment);
    Task DeleteAppointmentAsync(int id);
}
