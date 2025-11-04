using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace AppraisalAppV1.Models
{
    public class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string AppraiseeNumber { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Department { get; set; } = string.Empty;
        public string Designation { get; set; } = string.Empty;
        public string RequestDate { get; set; } = string.Empty;
        public string PeriodCoveredFrom { get; set; } = string.Empty;

        public ICollection<Appraisal> Appraisals { get; set; } = new List<Appraisal>();
    }
}