using System.Threading.Tasks;
using Domain.Entities;
using Domain.Interfaces;

namespace Infrastructure;

public class UnitOfWork : IUnitOfWork
{
    private readonly MedicalContext _context;

    public IRepository<Appointment> Appointments { get; }
    public IRepository<Specialist> Specialists { get; }
    public IRepository<Patient> Patients { get; }
    public IRepository<Clinic> Clinics { get; }

    public UnitOfWork(MedicalContext context)
    {
        _context = context;
        Appointments = new Repository<Appointment>(_context);
        Specialists = new Repository<Specialist>(_context);
        Patients = new Repository<Patient>(_context);
        Clinics = new Repository<Clinic>(_context);
    }

    public async Task<int> SaveChangesAsync()
    {
        return await _context.SaveChangesAsync();
    }
}
