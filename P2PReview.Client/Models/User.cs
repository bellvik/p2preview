namespace P2PReview.Client.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int XP { get; set; }
        public string AvatarUrl { get; set; } = string.Empty;
        public int Rank { get; set; }
    }
}
