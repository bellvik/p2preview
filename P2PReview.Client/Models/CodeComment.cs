namespace P2PReview.Client.Models;

public class CodeComment
{
    public int Id { get; set; }
    public int ReviewId { get; set; }
    public int LineNumber { get; set; }
    public string Text { get; set; } = string.Empty;
    public string Category { get; set; } = string.Empty;
    public string AuthorName { get; set; } = string.Empty;
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public string? FileName { get; set; }
}

public enum CommentCategory
{
    Bug,
    Performance,
    Security,
    Architecture,
    CodeStyle,
    BestPractice,
    Refactoring
}
