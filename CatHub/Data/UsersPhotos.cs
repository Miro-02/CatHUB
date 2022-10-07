using static CatHub.Data.Enumerators;

namespace CatHub.Data
{
    public class UsersPhotos
    {
        public string UserId { get; set; }
        public AppUser User { get; set; }
        public int PhotoId { get; set; }
        public Photo Photo { get; set; }
    }
}
