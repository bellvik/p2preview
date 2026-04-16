using P2PReview.Client.Models;

namespace P2PReview.Client.Services.Interfaces
{
    public interface IUserService
    {
        Task<List<User>> GetTopReviewersAsync(int count);
        Task<User> GetCurrentUserAsync();
    }
}
