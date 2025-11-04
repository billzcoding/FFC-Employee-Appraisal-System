using System.ComponentModel.DataAnnotations;
using System.Linq;
using System;

namespace AppraisalAppV1.Models
{
    public class ProfessionalSkills
    {
        [Required, Range(1, 5, ErrorMessage = "Value must be between 1 and 5.")]
        public double? JobKnowledge { get; set; }

        [Required, Range(1, 5, ErrorMessage = "Value must be between 1 and 5.")]
        public double? QualityOfWork { get; set; }

        [Required, Range(1, 5, ErrorMessage = "Value must be between 1 and 5.")]
        public double? Creativity { get; set; }

        [Required, Range(1, 5, ErrorMessage = "Value must be between 1 and 5.")]
        public double? Initiative { get; set; }

        [Required, Range(1, 5, ErrorMessage = "Value must be between 1 and 5.")]
        public double? SelfDevelopment { get; set; }

        [Required, Range(1, 5, ErrorMessage = "Value must be between 1 and 5.")]
        public double? OrganizingWork { get; set; }

        [Required, Range(1, 5, ErrorMessage = "Value must be between 1 and 5.")]
        public double? QuantityOfWork { get; set; }

        [Required, Range(1, 5, ErrorMessage = "Value must be between 1 and 5.")]
        public double? AnalyticalAbility { get; set; }

        [Required, Range(1, 5, ErrorMessage = "Value must be between 1 and 5.")]
        public double? Dependability { get; set; }

        public double AverageScore => new double?[] {
            JobKnowledge, QualityOfWork, Creativity, Initiative, SelfDevelopment,
            OrganizingWork, QuantityOfWork, AnalyticalAbility, Dependability
        }
        .Where(s => s.HasValue)
        .Select(s => s.Value)
        .DefaultIfEmpty(0)
        .Average();
    }
}