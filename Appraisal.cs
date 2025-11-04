using AppraisalAppV1.Models;
using System.Collections.Generic;

public class Appraisal
{
    public int Id { get; set; }
    public string AppraiseeNumber { get; set; } = string.Empty;
    public string RequestDate { get; set; } = string.Empty;
    public string EmployeeName { get; set; } = string.Empty;
    public string Department { get; set; } = string.Empty;
    public string Designation { get; set; } = string.Empty;
    public int? AppraisalYear { get; set; }
    public string PeriodCoveredFrom { get; set; } = string.Empty;
    public string MainTrainingAssignment { get; set; } = string.Empty;
    public string TrainingPlanned { get; set; } = string.Empty;
    public string Comments { get; set; } = string.Empty;

    // Skill scores are now nullable to allow for a blank state
    public double? JobKnowledge { get; set; }
    public double? QualityOfWork { get; set; }
    public double? Creativity { get; set; }
    public double? Initiative { get; set; }
    public double? SelfDevelopment { get; set; }
    public double? OrganizingWork { get; set; }
    public double? QuantityOfWork { get; set; }
    public double? AnalyticalAbility { get; set; }
    public double? Dependability { get; set; }
    public double? RelationshipSenior { get; set; }
    public double? WorkingUnderPressure { get; set; }
    public double? Communication { get; set; }
    public double? RelationshipJunior { get; set; }
    public double? SafetyConsciousness { get; set; }
    public double? Leadership { get; set; }
    public double? NewIdeas { get; set; }
    public double? Judgement { get; set; }
    public double? CompanyPhilosophy { get; set; }
    public double? ProblemAnalysis { get; set; }

    // Calculated fields
    public double? CumulativeWeightage { get; set; }
    public string Ranking { get; set; } = string.Empty;

    public string AttachmentFilePaths { get; set; } = string.Empty;

    public string? EmployeeAppraiseeNumber { get; set; }
    public Employee? Employee { get; set; }
    public int? SubmitterId { get; set; }
    public User? Submitter { get; set; }

    public int? ApprovalStatusId { get; set; }
    public ApprovalStatus? ApprovalStatus { get; set; }
    public List<AppraisalAssignment>? AppraisalAssignments { get; set; }
}