using BlogNest.Models;

namespace BlogNest.Core.Repositories
{
    public interface ILikeRepo
    {
        Task<int> GetLikesAsync(Guid PostId);
        Task<Like> GetLikeByIdAsync(Guid id);
        Task<Like> AddLikeAsync(Like like);
        Task<Like> UpdateLikeAsync(Like like);
        Task<Like> DeleteLikeAsync(Guid id);
    }
}
