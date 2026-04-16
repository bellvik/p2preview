using P2PReview.Client.Models;
using P2PReview.Client.Services.Interfaces;

namespace P2PReview.Client.Services.Mocks
{
    public class MockUserService: IUserService
    {
        public Task<List<User>> GetTopReviewersAsync(int count)
        {
            var users = new List<User>
            {
                new User { Id = 1, Name = "User 1", XP = 3540, AvatarUrl = "", Rank = 1 },
                new User { Id = 2, Name = "User 2", XP = 3210, AvatarUrl = "", Rank = 2 },
                new User { Id = 3, Name = "User 3", XP = 2980, AvatarUrl = "", Rank = 3 },
                new User { Id = 4, Name = "User 4", XP = 2750, AvatarUrl = "", Rank = 4 },
                new User { Id = 5, Name = "User 5", XP = 2630, AvatarUrl = "", Rank = 5 },
                new User { Id = 6, Name = "User 6", XP = 2520, AvatarUrl = "", Rank = 6 },
                new User { Id = 7, Name = "User 7", XP = 2480, AvatarUrl = "", Rank = 7 },
                new User { Id = 8, Name = "User 8", XP = 2350, AvatarUrl = "", Rank = 8 },
                new User { Id = 9, Name = "User 9", XP = 2210, AvatarUrl = "", Rank = 9 },
                new User { Id = 10, Name = "User 10", XP = 2150, AvatarUrl = "", Rank = 10 }
            };

            return Task.FromResult(users.Take(count).ToList());
        }

        public Task<User> GetCurrentUserAsync()
        {
            var currentUser = new User
            {
                Id = 999,
                Name = "Вы",
                XP = 200,
                AvatarUrl = "https://i.pravatar.cc/150?img=11",
                Rank = 1999
            };

            return Task.FromResult(currentUser);
        }
    }
}
