using P2PReview.Client.Models;
using P2PReview.Client.Services.Interfaces;

namespace P2PReview.Client.Services.Mocks
{
    public class MockReviewService: IReviewService
    {
        public Task<List<Review>> GetAssignedReviewsAsync()
        {
            var reviews = new List<Review>
        {
            new Review
            {
                Id = 1,
                ProjectName = "E-Commerce Platform",
                Technologies = new List<string> { "Python", "Django" },
                FileCount = 5,
                DueDays = 2,
                IsStarted = false,
                AuthorName = "Tim Hockin",
                Language = "Python"
            },
            new Review
            {
                Id = 2,
                ProjectName = "Chatbot Module",
                Technologies = new List<string> { "JS", "Node.js" },
                FileCount = 4,
                DueDays = 1,
                IsStarted = true,
                AuthorName = "Jeongho Jang",
                Language = "JavaScript"
            },
            new Review
            {
                Id = 3,
                ProjectName = "Image Processing Lib",
                Technologies = new List<string> { "C++", "OpenCV" },
                FileCount = 8,
                DueDays = 3,
                IsStarted = false,
                AuthorName = "Thierry Beaulieu",
                Language = "C++"
            },
            new Review
            {
                Id = 4,
                ProjectName = "CMS System",
                Technologies = new List<string> { "PHP", "Laravel" },
                FileCount = 6,
                DueDays = 4,
                IsStarted = false,
                AuthorName = "Lee Dum",
                Language = "PHP"
            }
        };

            return Task.FromResult(reviews);
        }

        public Task<Review?> GetReviewByIdAsync(int id)
        {
            var reviews = GetAssignedReviewsAsync().Result;
            return Task.FromResult(reviews.FirstOrDefault(r => r.Id == id));
        }
    }
}
