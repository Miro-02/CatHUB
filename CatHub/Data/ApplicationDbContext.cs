using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace CatHub.Data
{
    public class ApplicationDbContext : IdentityDbContext<AppUser>
    {

        public ApplicationDbContext()
        {

        }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public Microsoft.EntityFrameworkCore.DbSet<Comment> Comment { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<Video> Video { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<Photo> Photo { get; set; }

        public Microsoft.EntityFrameworkCore.DbSet<GIF> Gif { get; set; }

        public Microsoft.EntityFrameworkCore.DbSet<UsersComments> UsersComments { get; set; }

        public Microsoft.EntityFrameworkCore.DbSet<UsersPhotos> UsersPhoto { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<UsersVideos> UsersVideos { get; set; }

        public Microsoft.EntityFrameworkCore.DbSet<UsersLikedVideos> UsersLikedVideos { get; set; }

        public Microsoft.EntityFrameworkCore.DbSet<UsersGifs> UsersGifs { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<UsersComments>().HasKey(bc => new { bc.UserId, bc.CommentId });
            modelBuilder.Entity<UsersVideos>().HasKey(bc => new { bc.UserId, bc.VideoId });
            modelBuilder.Entity<UsersGifs>().HasKey(bc => new { bc.UserId, bc.GifId });
            modelBuilder.Entity<UsersPhotos>().HasKey(bc => new { bc.UserId, bc.PhotoId });
            modelBuilder.Entity<UsersLikedVideos>().HasKey(bc => new { bc.UserId, bc.VideoId, bc.typeOfLike });

        }
    }
}