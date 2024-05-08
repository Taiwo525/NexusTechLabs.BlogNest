//using BlogNest.Models;
//using BlogNest.Models.Enums;
//using Microsoft.AspNetCore.Identity;
//using Microsoft.EntityFrameworkCore;

//namespace BlogNest.Data
//{
//    public class BlogDbContext : DbContext
//    {
//        public BlogDbContext(DbContextOptions<BlogDbContext> options) : base(options)
//        {

//        }
//        public DbSet<User> Users { get; set; }
//        public DbSet<Post> Posts { get; set; }
//        public DbSet<Tag> Tags { get; set; }
//        public DbSet<Category> Categories { get; set; }
//        public DbSet<Comment> Comments { get; set; }
//        public DbSet<Notification> Notifications { get; set; }
//        public DbSet<Like> Likes { get; set; }
//        public DbSet<Subscription> Subscriptions { get; set; }
//        public DbSet<Role> Roles { get; set; }
//        public DbSet<PostCategory> PostCategories { get; set; }
//        public DbSet<PostTag> PostTags { get; set; }
//        public DbSet<UserRole> UserRoles { get; set; }
//        protected override void OnModelCreating(ModelBuilder modelBuilder)
//        {
//            // Configure IdentityUserRole<string> as a keyless entity type
//            modelBuilder.Entity<IdentityUserRole<string>>().HasNoKey();
//            modelBuilder.Entity<IdentityUserLogin<string>>().HasNoKey();
//            modelBuilder.Entity<IdentityUserToken<string>>().HasNoKey();

//            //Configure One User to Many Relationships
//            modelBuilder.Entity<User>()
//                .HasMany(a => a.Posts)
//                .WithOne(i => i.User)
//                .HasForeignKey(i => i.UserId)
//                .OnDelete(DeleteBehavior.Restrict);

//            modelBuilder.Entity<User>()
//                .HasMany(a => a.Notifications)
//                .WithOne(n => n.User)
//                .HasForeignKey(n => n.UserId)
//                .OnDelete(DeleteBehavior.Restrict);

//            //modelBuilder.Entity<User>()
//            //    .HasMany(a => a.Comments)
//            //    .WithOne(r => r.User)
//            //    .HasForeignKey(r => r.UserId);

//            modelBuilder.Entity<User>()
//                .HasMany(a => a.Subscriptions)
//                .WithOne(s => s.User)
//                .HasForeignKey(s => s.UserId)
//                .OnDelete(DeleteBehavior.Restrict);

//            modelBuilder.Entity<User>()
//                .HasMany(a => a.Likes)
//                .WithOne(t => t.User)
//                .HasForeignKey(t => t.UserId)
//                .OnDelete(DeleteBehavior.Restrict);

//            //Configure Post to comments One to Many Relationships
//            modelBuilder.Entity<Post>()
//                .HasMany(a => a.Comments)
//                .WithOne(i => i.Post)
//                .HasForeignKey(i => i.PostId);

//            //Configure Post to likes One to Many Relationships
//            modelBuilder.Entity<Post>()
//                .HasMany(a => a.Likes)
//                .WithOne(i => i.Post)
//                .HasForeignKey(i => i.PostId);

//            //Configure comment to likes One to Many Relationships
//            modelBuilder.Entity<Comment>()
//                .HasMany(a => a.Likes)
//                .WithOne(i => i.Comment)
//                .HasForeignKey(i => i.CommentId);

//            modelBuilder.Entity<Comment>()
//                .HasOne(c => c.User)
//                .WithMany(u => u.Comments)
//                .HasForeignKey(c => c.UserId)
//                .OnDelete(DeleteBehavior.Restrict); // Specify NO ACTION on delete


//            //Configure User to role many to Many Relationships
//            modelBuilder.Entity<UserRole>()
//              .HasKey(ur => new { ur.UserId, ur.RoleId });
//            modelBuilder.Entity<UserRole>()
//                .HasOne(pc => pc.User)
//                .WithMany(p => p.UserRoles)
//                .HasForeignKey(pc => pc.UserId);

//            modelBuilder.Entity<UserRole>()
//                .HasOne(pc => pc.Role)
//                .WithMany(c => c.UserRoles)
//                .HasForeignKey(pc => pc.RoleId);

//            modelBuilder.Entity<PostTag>()
//                .HasKey(pt => new { pt.PostId, pt.TagId });
//            modelBuilder.Entity<PostTag>()
//                .HasOne(pc => pc.Post)
//                .WithMany(p => p.PostTags)
//                .HasForeignKey(pc => pc.PostId);

//            modelBuilder.Entity<PostTag>()
//                .HasOne(pc => pc.Tag)
//                .WithMany(c => c.PostTags)
//                .HasForeignKey(pc => pc.TagId);

//            ////Configure post to category many to Many Relationships
//            //modelBuilder.Entity<Post>()
//            modelBuilder.Entity<PostCategory>()
//           .HasKey(pc => new { pc.PostId, pc.CategoryId });

//            modelBuilder.Entity<PostCategory>()
//                .HasOne(pc => pc.Post)
//                .WithMany(p => p.PostCategories)
//                .HasForeignKey(pc => pc.PostId);

//            modelBuilder.Entity<PostCategory>()
//                .HasOne(pc => pc.Category)
//                .WithMany(c => c.PostCategories)
//                .HasForeignKey(pc => pc.CategoryId);
//        }
//    }
//}

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
        //public DbSet<User> Users { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Tag> Tags { get; set; }
//        public DbSet<Category> Categories { get; set; }
//        public DbSet<Comment> Comments { get; set; }
//        public DbSet<Notification> Notifications { get; set; }
//        public DbSet<Like> Likes { get; set; }
//        public DbSet<Subscription> Subscriptions { get; set; }
//        public DbSet<Role> Roles { get; set; }
//        public DbSet<PostCategory> PostCategories { get; set; }
//        public DbSet<PostTag> PostTags { get; set; }
//        public DbSet<UserRole> UserRoles { get; set; }

//        protected override void OnModelCreating(ModelBuilder modelBuilder)
//        {
//            // Configure IdentityUserRole<string> as a keyless entity type
//            modelBuilder.Entity<IdentityUserRole<string>>().HasNoKey();
//            modelBuilder.Entity<IdentityUserLogin<string>>().HasNoKey();
//            modelBuilder.Entity<IdentityUserToken<string>>().HasNoKey();

//            // Configure relationships
//            modelBuilder.Entity<User>()
//                .HasMany(a => a.Posts)
//                .WithOne(i => i.User)
//                .HasForeignKey(i => i.UserId)
//                .OnDelete(DeleteBehavior.Restrict);

//            modelBuilder.Entity<User>()
//                .HasMany(a => a.Notifications)
//                .WithOne(n => n.User)
//                .HasForeignKey(n => n.UserId)
//                .OnDelete(DeleteBehavior.Restrict);

//            modelBuilder.Entity<User>()
//                .HasMany(a => a.Subscriptions)
//                .WithOne(s => s.User)
//                .HasForeignKey(s => s.UserId)
//                .OnDelete(DeleteBehavior.Restrict);

//            modelBuilder.Entity<User>()
//                .HasMany(a => a.Likes)
//                .WithOne(t => t.User)
//                .HasForeignKey(t => t.UserId)
//                .OnDelete(DeleteBehavior.Restrict);

//            modelBuilder.Entity<Comment>()
//                .HasOne(c => c.User)
//                .WithMany(u => u.Comments)
//                .HasForeignKey(c => c.UserId)
//                .OnDelete(DeleteBehavior.Restrict);

//            // Configure Post to comments One-to-Many Relationships
//            modelBuilder.Entity<Post>()
//                .HasMany(a => a.Comments)
//                .WithOne(i => i.Post)
//                .HasForeignKey(i => i.PostId);

//            // Configure Post to likes One-to-Many Relationships
//            modelBuilder.Entity<Post>()
//                .HasMany(a => a.Likes)
//                .WithOne(i => i.Post)
//                .HasForeignKey(i => i.PostId);

//            // Configure comment to likes One-to-Many Relationships
//            modelBuilder.Entity<Comment>()
//                .HasMany(a => a.Likes)
//                .WithOne(i => i.Comment)
//                .HasForeignKey(i => i.CommentId);

//            // Configure User to role many-to-many Relationships
//            modelBuilder.Entity<UserRole>()
//                .HasKey(ur => new { ur.UserId, ur.RoleId });

//            modelBuilder.Entity<UserRole>()
//                .HasOne(pc => pc.User)
//                .WithMany(p => p.UserRoles)
//                .HasForeignKey(pc => pc.UserId);

//            modelBuilder.Entity<UserRole>()
//                .HasOne(pc => pc.Role)
//                .WithMany(c => c.UserRoles)
//                .HasForeignKey(pc => pc.RoleId);

//            // Configure PostTag entity (you've left this incomplete)
//            modelBuilder.Entity<PostTag>()
//                .HasKey(pt => new { pt.PostId, pt.TagId });
//            modelBuilder.Entity<PostTag>()
//                .HasOne(pc => pc.Post)
//                .WithMany(p => p.PostTags)
//                .HasForeignKey(pc => pc.PostId);

//            modelBuilder.Entity<PostTag>()
//                .HasOne(pc => pc.Tag)
//                .WithMany(c => c.PostTags)
//                .HasForeignKey(pc => pc.TagId);

//            ////Configure post to category many to Many Relationships
//            //modelBuilder.Entity<Post>()
//            modelBuilder.Entity<PostCategory>()
//           .HasKey(pc => new { pc.PostId, pc.CategoryId });

//            modelBuilder.Entity<PostCategory>()
//                .HasOne(pc => pc.Post)
//                .WithMany(p => p.PostCategories)
//                .HasForeignKey(pc => pc.PostId);

//            modelBuilder.Entity<PostCategory>()
//                .HasOne(pc => pc.Category)
//                .WithMany(c => c.PostCategories)
//                .HasForeignKey(pc => pc.CategoryId);
//        }
   }
}

