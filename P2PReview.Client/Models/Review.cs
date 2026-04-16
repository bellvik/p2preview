namespace P2PReview.Client.Models
{
    public class Review
    {
        public int Id { get; set; }
        public string ProjectName { get; set; } = string.Empty;
        public List<string> Technologies { get; set; } = new();
        public int FileCount { get; set; }
        public int DueDays { get; set; }
        public bool IsStarted { get; set; }
        public string AuthorName { get; set; } = string.Empty;
        public string Language { get; set; } = string.Empty;
        public bool HasAIAnalysis { get; set; } = false;
    }
}
