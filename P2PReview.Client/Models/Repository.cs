namespace P2PReview.Client.Models
{
    public class Repository
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int FileCount { get; set; }
        public RepoStatus Status { get; set; }
        public string Language { get; set; } = string.Empty;
    }
    public enum RepoStatus
    {
        InProgress,
        PendingApproval,
        ReadyForReview,
        Completed
    }
}
