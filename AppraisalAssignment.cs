using System.ComponentModel.DataAnnotations;

namespace AppraisalAppV1.Models
{
    public class AppraisalAssignment
    {
        [Key]
        public int Id { get; set; }

        public int AppraisalId { get; set; }
        public Appraisal? Appraisal { get; set; }

        public int UserId { get; set; }
        public User? User { get; set; }

        public string TaskAssigned { get; set; } = "Review";

        public AppraisalTaskStatus Status { get; set; } = AppraisalTaskStatus.Pending;
        public string? ReviewerComment { get; set; }
    }
}