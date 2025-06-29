using System.Threading.Tasks;
using Domain.Entities;

namespace Domain.Interfaces;

public interface IUnitOfWork
{
    IRepository<Appointment> Appointments { get; }
    IRepository<Specialist> Specialists { get; }
    Task<int> SaveChangesAsync();
}
