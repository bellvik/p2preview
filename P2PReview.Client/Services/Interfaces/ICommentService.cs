using P2PReview.Client.Models;

namespace P2PReview.Client.Services.Interfaces;

public interface ICommentService
{
    Task<List<CodeComment>> GetCommentsForReviewAsync(int reviewId);
    Task<CodeComment> AddCommentAsync(CodeComment comment);
    Task DeleteCommentAsync(int commentId);
    Task<List<CodeComment>> GetCommentsForLineAsync(int reviewId, int lineNumber);
}
