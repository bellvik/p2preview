using P2PReview.Client.Models;

namespace P2PReview.Client.Services.Interfaces
{
    public interface IRepositoryService
    {
        Task<List<Repository>> GetUserRepositoriesAsync();
    }
}
