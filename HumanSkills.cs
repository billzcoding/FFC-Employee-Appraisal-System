using System.ComponentModel.DataAnnotations;
using System.Linq;
using System;

namespace AppraisalAppV1.Models
{
    public class HumanSkills
    {
        [Required, Range(0, 5, ErrorMessage = "Value must be between 0 and 5.")]
        public double? RelationshipSenior { get; set; }

        [Required, Range(0, 5, ErrorMessage = "Value must be between 0 and 5.")]
        public double? WorkingUnderPressure { get; set; }

        [Required, Range(0, 5, ErrorMessage = "Value must be between 0 and 5.")]
        public double? Communication { get; set; }

        [Required, Range(0, 5, ErrorMessage = "Value must be between 0 and 5.")]
        public double? RelationshipJunior { get; set; }

        [Required, Range(0, 5, ErrorMessage = "Value must be between 0 and 5.")]
        public double? SafetyConsciousness { get; set; }

        public double AverageScore => new double?[] {
            RelationshipSenior, WorkingUnderPressure, Communication,
            RelationshipJunior, SafetyConsciousness
        }
        .Where(s => s.HasValue)
        .Select(s => s.Value)
        .DefaultIfEmpty(0)
        .Average();
    }
}