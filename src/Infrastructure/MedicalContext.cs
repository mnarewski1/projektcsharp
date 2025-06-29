using Microsoft.EntityFrameworkCore;
using Domain.Entities;

namespace Infrastructure;

public class MedicalContext : DbContext
{
    public DbSet<Specialist> Specialists => Set<Specialist>();
    public DbSet<Appointment> Appointments => Set<Appointment>();

    public MedicalContext(DbContextOptions<MedicalContext> options)
        : base(options)
    {
    }
}
