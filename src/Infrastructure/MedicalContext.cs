using Microsoft.EntityFrameworkCore;
using Domain.Entities;

namespace Infrastructure;

public class MedicalContext : DbContext
{
    public DbSet<Specialist> Specialists => Set<Specialist>();
    public DbSet<Appointment> Appointments => Set<Appointment>();
    public DbSet<Patient> Patients => Set<Patient>();
    public DbSet<Clinic> Clinics => Set<Clinic>();

    public MedicalContext(DbContextOptions<MedicalContext> options)
        : base(options)
    {
    }
}
