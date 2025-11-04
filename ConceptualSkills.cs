using System.ComponentModel.DataAnnotations;
using System.Linq;
using System;

namespace AppraisalAppV1.Models
{
    public class ConceptualSkills
    {
        [Required, Range(0, 5, ErrorMessage = "Value must be between 0 and 5.")]
        public double? Leadership { get; set; }

        [Required, Range(0, 5, ErrorMessage = "Value must be between 0 and 5.")]
        public double? NewIdeas { get; set; }

        [Required, Range(0, 5, ErrorMessage = "Value must be between 0 and 5.")]
        public double? Judgement { get; set; }

        [Required, Range(0, 5, ErrorMessage = "Value must be between 0 and 5.")]
        public double? CompanyPhilosophy { get; set; }

        [Required, Range(0, 5, ErrorMessage = "Value must be between 0 and 5.")]
        public double? ProblemAnalysis { get; set; }

        public double AverageScore => new double?[] {
            Leadership, NewIdeas, Judgement, CompanyPhilosophy, ProblemAnalysis
        }
        .Where(s => s.HasValue)
        .Select(s => s.Value)
        .DefaultIfEmpty(0)
        .Average();
    }
}