using BlogNest.Core.Repositories;
using BlogNest.Data;
using BlogNest.Models;
using Microsoft.EntityFrameworkCore;

namespace BlogNest.Core.Implementations
{
    public class LikeRepo : ILikeRepo
    {
        private readonly BlogDbContext context;

        public LikeRepo(BlogDbContext context)
        {
            this.context = context;
        }
        public Task<Like> AddLikeAsync(Like like)
        {
            throw new NotImplementedException();
        }

        public Task<Like> DeleteLikeAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Like> GetLikeByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Like>> GetLikesAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<int> GetLikesAsync(Guid postId)
        {
            return await context.Likes.CountAsync(x => x.PostId == postId);
        }

        public Task<Like> UpdateLikeAsync(Like like)
        {
            throw new NotImplementedException();
        }
    }
}
