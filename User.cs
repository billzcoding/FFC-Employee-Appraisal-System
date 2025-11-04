// In AppraisalAppV1.Models/User.cs
using AppraisalAppV1.Models;
using System.ComponentModel.DataAnnotations.Schema;

public class User
{
    public int Id { get; set; }
    public string FullName { get; set; } = string.Empty;
    public string Username { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;

    // This is the property that was missing in the migration.
    public string? AppraiseeNumber { get; set; }

    [ForeignKey("AppraiseeNumber")]
    public Employee? Employee { get; set; }

    public ICollection<AppraisalAssignment> AppraisalAssignments { get; set; } = new List<AppraisalAssignment>();
    public ICollection<Appraisal> Appraisals { get; set; } = new List<Appraisal>();
}