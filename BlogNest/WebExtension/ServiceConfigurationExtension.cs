using BlogNest.Core.Implementations;
using BlogNest.Core.Repositories;
using BlogNest.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace BlogNest.WebExtensions
{
    public static class ServiceConfigurationExtension
    {
        public static void ServiceConfiguration(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IPostRepo, PostRepo>();
            services.AddScoped<ITagRepo, TagRepo>();
            services.AddScoped<IImageRepo, CloudinaryImageRepo>();

            services.AddDbContext<BlogDbContext>(options =>
                  options.UseSqlServer(configuration.GetConnectionString("con")));

            services.AddDbContext<AuthDbContext>(options =>
                 options.UseSqlServer(configuration.GetConnectionString("authcon")));

            services.AddIdentity<IdentityUser, IdentityRole>()
                .AddEntityFrameworkStores<AuthDbContext>()
                .AddDefaultTokenProviders();

            services.ConfigureApplicationCookie(options =>
            {
                options.LoginPath = "/Account/Login";
                options.LogoutPath = "/Account/Logout";
                options.AccessDeniedPath = "/Account/AcceessDenied";
            });

            services.Configure<IdentityOptions>(options =>
            {
                options.Password.RequireDigit = true;
                options.Password.RequiredLength = 8;
                options.Password.RequireLowercase = true;
                options.Password.RequireNonAlphanumeric = true;
                options.Password.RequireUppercase = true;
                options.Password.RequiredUniqueChars = 1;
            });

            //services.AddIdentity<User>(options =>
            //{
            //    options.SignIn.RequireConfirmedAccount = true;
            //})
            //.AddEntityFrameworkStores<BlogDbContext>();

            services.ConfigureApplicationCookie(options =>
            {
                options.Cookie.HttpOnly = true;
                options.Cookie.SecurePolicy = CookieSecurePolicy.Always;
                options.Cookie.SameSite = SameSiteMode.Strict;
                options.Cookie.IsEssential = true;
            });
        }
    }
}
