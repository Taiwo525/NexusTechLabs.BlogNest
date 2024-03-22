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
        public async Task AddPost(Post post)
        {
            await _db.Posts.AddAsync(post);
            await _db.SaveChangesAsync();
        }

        public async Task DeletePost(int Id)
        {
            var deletedPost = await _db.Posts.FindAsync(Id);
            _db.Posts.Remove(deletedPost);
            await _db.SaveChangesAsync();
        }

        public async Task<IEnumerable<Post>> GetAllPosts()
        {
            return await _db.Posts.ToListAsync();
        }

        public async Task<Post> GetPostById(int Id)
        {
            return await _db.Posts.FindAsync(Id);
        }

        public async Task<IEnumerable<Post>> GetUsersPosts(int Id)
        {
            return await _db.Posts.Where(u => u.Id == Id).ToListAsync();
        }

        public async Task<IEnumerable<Post>> GetUsersPostsByCategory(string categoryName)
        {
            return await _db.Posts.Include(p => p.Categories).
                Where(c => c.Categories.Any(b => b.
                Name == categoryName)).ToListAsync();
        }

        public Task<IEnumerable<Post>> GetUsersPostsByTag(string tagName)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Post>> SearchPosts(string query)
        {
            throw new NotImplementedException();
        }

        public Task UpdatePost(Post post)
        {
            throw new NotImplementedException();
        }
    }
}
