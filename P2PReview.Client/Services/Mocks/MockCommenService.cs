using P2PReview.Client.Models;
using P2PReview.Client.Services.Interfaces;

namespace P2PReview.Client.Services.Mocks;

public class MockCommentService : ICommentService
{
    private List<CodeComment> _comments = new()
    {
        new CodeComment
        {
            Id = 1,
            ReviewId = 1,
            LineNumber = 6,
            Text = "Consider using enumerate() instead of range(len())",
            Category = "BestPractice",
            AuthorName = "You",
            CreatedAt = DateTime.Now.AddHours(-2),
            FileName = "sort.py"
        }
    };

    public Task<List<CodeComment>> GetCommentsForReviewAsync(int reviewId)
    {
        var comments = _comments.Where(c => c.ReviewId == reviewId).ToList();
        return Task.FromResult(comments);
    }

    public Task<CodeComment> AddCommentAsync(CodeComment comment)
    {
        comment.Id = _comments.Max(c => c.Id) + 1;
        comment.CreatedAt = DateTime.Now;
        _comments.Add(comment);
        return Task.FromResult(comment);
    }

    public Task DeleteCommentAsync(int commentId)
    {
        var comment = _comments.FirstOrDefault(c => c.Id == commentId);
        if (comment != null)
        {
            _comments.Remove(comment);
        }
        return Task.CompletedTask;
    }

    public Task<List<CodeComment>> GetCommentsForLineAsync(int reviewId, int lineNumber)
    {
        var comments = _comments
            .Where(c => c.ReviewId == reviewId && c.LineNumber == lineNumber)
            .ToList();
        return Task.FromResult(comments);
    }
}
