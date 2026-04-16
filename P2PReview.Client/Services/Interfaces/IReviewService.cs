using P2PReview.Client.Models;

namespace P2PReview.Client.Services.Interfaces
{
    public interface IReviewService
    {
        Task<List<Review>> GetAssignedReviewsAsync();
        Task<Review?> GetReviewByIdAsync(int id);
    }
}
