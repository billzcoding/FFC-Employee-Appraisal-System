public enum ApprovalStatusEnum
{
    InProcess = 0,
    Completed = 1
}

public class ApprovalStatus
{
    public int Id { get; set; }
    public ApprovalStatusEnum Status { get; set; }
    public int TotalStages { get; set; }
    public int CurrentStage { get; set; }
    public int? CurrentActionerUserId { get; set; }
}