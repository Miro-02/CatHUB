using Microsoft.Extensions.Logging;
using static CatHub.Data.Enumerators;

namespace CatHub.Data
{
    public class UsersLikedVideos
    {
        public string UserId { get; set; }
        public AppUser User { get; set; }
        public int VideoId { get; set; }
        public Video Video { get; set; }

        public TypeOfLike typeOfLike { get; set; }

    }
}
