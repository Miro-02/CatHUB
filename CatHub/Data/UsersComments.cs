using static CatHub.Data.Enumerators;

namespace CatHub.Data
{
    public class UsersComments
    {
        public string UserId { get; set; }
        public AppUser User { get; set; }
        public string CommentId { get; set; }
        public Comment Comment { get; set; }

        public string VideoId { get; set; }

        public Video Video { get; set; }
    }
}
