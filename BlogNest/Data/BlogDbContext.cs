
using BlogNest.Models;
//using BlogNest.Models.Enums;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace BlogNest.Data
{
    public class BlogDbContext : DbContext
    {
        public BlogDbContext(DbContextOptions<BlogDbContext> options) : base(options)
        {

        }

        // DbSet properties for your entities
        public DbSet<Post> Posts { get; set; }
        public DbSet<Tag> Tags { get; set; }
//        public DbSet<Category> Categories { get; set; }
//        public DbSet<Comment> Comments { get; set; }
//        public DbSet<Notification> Notifications { get; set; }
        public DbSet<Like> Likes { get; set; }
//        public DbSet<Subscription> Subscriptions { get; set; }
//        public DbSet<Role> Roles { get; set; }
//        public DbSet<PostCategory> PostCategories { get; set; }
//        public DbSet<PostTag> PostTags { get; set; }
//        public DbSet<UserRole> UserRoles { get; set; }

//        protected override void OnModelCreating(ModelBuilder modelBuilder)
//        {
//            // Configure IdentityUserRole<string> as a keyless entity type
//            
   }
}

