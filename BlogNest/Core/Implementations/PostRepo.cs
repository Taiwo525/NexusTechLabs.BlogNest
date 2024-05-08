using BlogNest.Core.Repositories;
using BlogNest.Data;
using BlogNest.Models;
using Microsoft.EntityFrameworkCore;

namespace BlogNest.Core.Implementations
{
    public class PostRepo : IPostRepo
    {
        private readonly BlogDbContext _db;
        public PostRepo(BlogDbContext db)
        {
            _db = db;
        }
        public async Task<Post> AddPostAsync(Post post)
        {
            await _db.Posts.AddAsync(post);
            await _db.SaveChangesAsync();
            return post;
        }

        public async Task<Post> DeletePostAsync(Guid Id)
        { 
            var deletedPost = await _db.Posts.FindAsync(Id);
            if (deletedPost != null)
            {
                _db.Posts.Remove(deletedPost);
                await _db.SaveChangesAsync();
                return deletedPost;
            }
            
            return null;
        }

        public async Task<IEnumerable<Post>> GetAllPostsAsync()
        {
            return await _db.Posts.Include(x => x.Tags).ToListAsync();
        }

        public async Task<Post> GetPostByIdAsync(Guid id)
        {
            return await _db.Posts.Include(x => x.Tags).FirstOrDefaultAsync(u => u.Id==id);
        }

        public async Task<Post> GetPostByUrlHandleAsync(string urlHandle)
        {
            return await _db.Posts.Include(u => u.Tags).FirstOrDefaultAsync(x => x.UrlHandle == urlHandle);
        }

        public async Task<IEnumerable<Post>> GetUsersPosts(Guid id)
        {
            return await _db.Posts.Where(u => u.Id == id).ToListAsync();
        }

        //public async Task<IEnumerable<Post>> GetUsersPostsByCategory(string categoryName)
        //{
        //    return await _db.Posts.Include(p => p.Categories).
        //        Where(c => c.Categories.Any(b => b.
        //        Name == categoryName)).ToListAsync();
        //}

        public Task<IEnumerable<Post>> GetUsersPostsByTag(string tagName)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Post>> SearchPosts(string query)
        {
            throw new NotImplementedException();
        }

        public async Task<Post> UpdatePostAsync(Post post)
        {
           var existingBlog = await _db.Posts.Include(x => x.Tags)
                .FirstOrDefaultAsync(x  => x.Id==post.Id);
            if (existingBlog != null)
            {
                existingBlog.Id = post.Id;
                existingBlog.Heading = post.Heading;
                existingBlog.PageTitle = post.PageTitle;
                existingBlog.Content = post.Content;
                existingBlog.ShortDescription = post.ShortDescription;
                existingBlog.Author = post.Author;
                existingBlog.FeaturedImageUrl = post.FeaturedImageUrl;
                existingBlog.UrlHandle = post.UrlHandle;
                existingBlog.PublishedDate = post.PublishedDate;
                existingBlog.Visible = post.Visible;
                existingBlog.Tags = post.Tags;

                await _db.SaveChangesAsync();
                return existingBlog;
            }
            return null;
        }
    }
}
