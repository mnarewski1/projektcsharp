using System.Threading.Tasks;
using Domain.Entities;

namespace Domain.Interfaces;

public interface IUnitOfWork
{
    IRepository<Appointment> Appointments { get; }
    IRepository<Specialist> Specialists { get; }
    IRepository<Patient> Patients { get; }
    IRepository<Clinic> Clinics { get; }
    Task<int> SaveChangesAsync();
}
