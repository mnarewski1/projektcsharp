using System;

namespace Domain.Entities;

public class Appointment
{
    public int Id { get; set; }
    public DateTime Date { get; set; }
    public int SpecialistId { get; set; }
    public Specialist? Specialist { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
}
