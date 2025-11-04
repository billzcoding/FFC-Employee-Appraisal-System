using System.Linq;
using System;

namespace AppraisalAppV1.Models
{
    public class OverallRating
    {
        private readonly ProfessionalSkills _professionalSkills;
        private readonly HumanSkills _humanSkills;
        private readonly ConceptualSkills _conceptualSkills;

        public OverallRating(ProfessionalSkills professionalSkills, HumanSkills humanSkills, ConceptualSkills conceptualSkills)
        {
            _professionalSkills = professionalSkills;
            _humanSkills = humanSkills;
            _conceptualSkills = conceptualSkills;
        }

        public double? CumulativeWeightage
        {
            get
            {
                var profAvg = _professionalSkills.AverageScore;
                var humanAvg = _humanSkills.AverageScore;
                var conceptAvg = _conceptualSkills.AverageScore;

                if (profAvg == 0 && humanAvg == 0 && conceptAvg == 0)
                {
                    return null;
                }

                return Math.Round((profAvg * 0.50) + (humanAvg * 0.30) + (conceptAvg * 0.20), 2);
            }
        }

        public string Ranking
        {
            get
            {
                if (CumulativeWeightage == null) return string.Empty;

                double totalScore = CumulativeWeightage.Value;
                if (totalScore >= 5.0) return "A";
                if (totalScore >= 4.0) return "B";
                if (totalScore >= 3.0) return "C";
                if (totalScore >= 2.0) return "D";
                if (totalScore >= 1.0) return "E";
                return "F";
            }
        }
    }
}