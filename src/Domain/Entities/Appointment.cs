using System;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities;

public class Appointment
{
    public int Id { get; set; }
    [Required]
    public DateTime Date { get; set; }
    [Required]
    public int SpecialistId { get; set; }
    public Specialist? Specialist { get; set; }
    public int? PatientId { get; set; }
    public Patient? Patient { get; set; }
    public int? ClinicId { get; set; }
    public Clinic? Clinic { get; set; }
    [Required]
    public string FirstName { get; set; } = string.Empty;
    [Required]
    public string LastName { get; set; } = string.Empty;
}
