using P2PReview.Client.Models;
using P2PReview.Client.Services.Interfaces;

namespace P2PReview.Client.Services.Mocks
{
    public class MockRepositoryService: IRepositoryService
    {
        public Task<List<Repository>> GetUserRepositoriesAsync()
        {
            var repositories = new List<Repository>
        {
            new Repository { Id = 1, Name = "Task Manager App", FileCount = 3, Status = RepoStatus.InProgress, Language = "Python" },
            new Repository { Id = 2, Name = "AI Bot Project", FileCount = 5, Status = RepoStatus.InProgress, Language = "Python" },
            new Repository { Id = 3, Name = "API Service", FileCount = 4, Status = RepoStatus.PendingApproval, Language = "Node.js" },
            new Repository { Id = 4, Name = "React Website", FileCount = 8, Status = RepoStatus.ReadyForReview, Language = "JavaScript" },
            new Repository { Id = 5, Name = "Game Engine", FileCount = 12, Status = RepoStatus.Completed, Language = "C++" },
            new Repository { Id = 6, Name = "Analytics Tool", FileCount = 6, Status = RepoStatus.Completed, Language = "Python" }
        };

            return Task.FromResult(repositories);
        }
    }
}
