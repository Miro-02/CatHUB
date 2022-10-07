namespace CatHub.Data
{
    public class UsersVideos
    {
        public string UserId { get; set; }
        public AppUser User { get; set; }
        public int VideoId { get; set; }
        public Video Video { get; set; }

    }
}
