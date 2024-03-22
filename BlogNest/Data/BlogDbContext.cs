using BlogNest.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace BlogNest.Data
{
    public class BlogDbContext : DbContext
    {
        public BlogDbContext(DbContextOptions<BlogDbContext> options) : base(options)
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<Like> Likes { get; set; }
        public DbSet<Subscription> Subscriptions { get; set; }
        public DbSet<Role> Roles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure IdentityUserRole<string> as a keyless entity type
            modelBuilder.Entity<IdentityUserRole<string>>().HasNoKey();
            modelBuilder.Entity<IdentityUserLogin<string>>().HasNoKey();
            modelBuilder.Entity<IdentityUserToken<string>>().HasNoKey();

            // Configure One AppUser to Zero or One Relationships
            //    modelBuilder.Entity<User>()
            //        .HasOne(a => a.Health)
            //        .WithOne(h => h.User)
            //        .HasForeignKey<Health>(h => h.AppUserId);

            //    modelBuilder.Entity<AppUser>()
            //        .HasOne(a => a.Setting)
            //        .WithOne(s => s.AppUser)
            //        .HasForeignKey<Setting>(s => s.AppUserId);

            //    modelBuilder.Entity<AppUser>()
            //        .HasOne(a => a.Wallet)
            //        .WithOne(w => w.AppUser)
            //        .HasForeignKey<Wallet>(w => w.AppUserId);

            //    //Configure One AppUser to Many Relationships
            //    modelBuilder.Entity<AppUser>()
            //        .HasMany(a => a.Invities)
            //        .WithOne(i => i.AppUser)
            //        .HasForeignKey(i => i.AppUserId);

            //    modelBuilder.Entity<AppUser>()
            //        .HasMany(a => a.Notifications)
            //        .WithOne(n => n.AppUser)
            //        .HasForeignKey(n => n.AppUserId);

            //    modelBuilder.Entity<AppUser>()
            //        .HasMany(a => a.Reviews)
            //        .WithOne(r => r.AppUser)
            //        .HasForeignKey(r => r.AppUserId);

            //    modelBuilder.Entity<AppUser>()
            //        .HasMany(a => a.Subscriptions)
            //        .WithOne(s => s.AppUser)
            //        .HasForeignKey(s => s.AppUserId);

            //    modelBuilder.Entity<AppUser>()
            //        .HasMany(a => a.Transactions)
            //        .WithOne(t => t.AppUser)
            //        .HasForeignKey(t => t.AppUserId);

            //    // Configure One to One Health Relationship
            //    modelBuilder.Entity<Health>()
            //        .HasOne(h => h.AppUser)
            //        .WithOne(a => a.Health)
            //        .HasForeignKey<Health>(h => h.AppUserId);

            //    // Configure One to Zero or One Wallet Relationship
            //    modelBuilder.Entity<Wallet>()
            //        .HasOne(w => w.AppUser)
            //        .WithOne(a => a.Wallet)
            //        .HasForeignKey<Wallet>(w => w.AppUserId);

            //    // Configure One Wallet to Many Relationships
            //    //modelBuilder.Entity<Wallet>()
            //    //    .HasOne(w => w.AppUser);


            //    // Configure One to Many Transaction Relationship
            //    //modelBuilder.Entity<Transaction>()
            //    //    .HasOne(t => t.AppUser)
            //    //    .WithMany(a => a.Transactions)
            //    //    .HasForeignKey(t => t.AppUserId);

            //    // Configure One to Many Subscription Relationship
            //    modelBuilder.Entity<Subscription>()
            //        .HasOne(s => s.User)
            //        .WithMany(a => a.Subscriptions)
            //        .HasForeignKey(s => s.UserId);

            //    // Configure One to Many Reviews Relationships
            //    modelBuilder.Entity<Review>()
            //        .HasOne(r => r.AppUser)
            //        .WithMany(a => a.Reviews)
            //        .HasForeignKey(r => r.AppUserId);

            //    // Configure One to Many Notification Relationship
            //    modelBuilder.Entity<Notification>()
            //        .HasOne(n => n.User)
            //        .WithMany(a => a.Notifications)
            //        .HasForeignKey(n => n.UserId);
            
        }
    }
}
