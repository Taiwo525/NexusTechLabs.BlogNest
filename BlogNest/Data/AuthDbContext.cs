using BlogNest.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BlogNest.Data
{
    public class AuthDbContext : IdentityDbContext
    {
        public AuthDbContext(DbContextOptions<AuthDbContext> options) : base(options)
        {
        }

        //protected override void OnModelCreating(ModelBuilder builder)
        //{
        //    base.OnModelCreating(builder);

        //    // seed roles (user, admin, superadmin)
        //    var adminRoleId = "203f864c-6a4a-4584-a2cc-d302caa7990f";
        //    var superAdminRoleId = "e73de0dc-0eb3-43a8-9529-48769cc74910";
        //    var userRoleId = "c40acc69-73bf-4be7-b47d-d6c83c591986";

        //    var roles = new List<IdentityRole>
        //    {
        //        new IdentityRole
        //        {
        //            Name = "Admin",
        //            NormalizedName = "Admin",
        //            Id = adminRoleId,
        //            ConcurrencyStamp = adminRoleId
        //        },
        //        new IdentityRole
        //        {
        //            Name = "SuperAdmin",
        //            NormalizedName = "SuperAdmin",
        //            Id = superAdminRoleId,
        //            ConcurrencyStamp = superAdminRoleId
        //        },
        //        new IdentityRole
        //        {
        //            Name = "User",
        //            NormalizedName = "User",
        //            Id = userRoleId,
        //            ConcurrencyStamp = userRoleId
        //        }
        //    };
        //    builder.Entity<IdentityRole>().HasData(roles);

        //    // seed superadminuser
        //    var superAdminId = "149081ed-9659-4c49-b222-bbbafd920060";
        //    var superAdminUser = new IdentityUser
        //    {
        //        UserName = "superAdmin@blog.com",
        //        Email = "superAdmin@blog.com",
        //        NormalizedEmail = "superAdmin@blog.com".ToUpper(),
        //        NormalizedUserName = "superAdmin@blog.com".ToUpper(),
        //        Id = superAdminId
        //    };

        //    superAdminUser.PasswordHash = new PasswordHasher<IdentityUser>()
        //        .HashPassword(superAdminUser, "superadmin@253");

        //    builder.Entity<IdentityUser>().HasData(superAdminUser);

        //    // add all roles to superadminuser

        //    var superAdminRoles = new List<IdentityUserRole<string>>
        //    {
        //        new IdentityUserRole<string>
        //        {
        //            RoleId = adminRoleId,
        //            UserId = superAdminId
        //        },
        //        new IdentityUserRole<string>
        //        {
        //            RoleId = superAdminRoleId,
        //            UserId = superAdminId
        //        },
        //        new IdentityUserRole<string>
        //        {
        //            RoleId = userRoleId,
        //            UserId = superAdminId
        //        }
        //    };
        //    builder.Entity<IdentityUserRole<string>>().HasData(superAdminRoles);
        //}
    }
}
