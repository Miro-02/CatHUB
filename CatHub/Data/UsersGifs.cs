namespace CatHub.Data
{
    public class UsersGifs
    {
        public string UserId { get; set; }
        public AppUser User { get; set; }
        public int GifId { get; set; }
        public GIF Gif { get; set; }
    }
}
