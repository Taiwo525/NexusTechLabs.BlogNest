using BlogNest.Models;
using BlogNest.Models.ViewModels;

namespace BlogNest.Core.Repositories
{
    public interface IPostRepo
    {
        Task<IEnumerable<Post>> GetAllPostsAsync();
        //Task<IEnumerable<Post>> GetUsersPosts(int Id);
        Task<IEnumerable<Post>> SearchPosts(string query);
        //Task<IEnumerable<Post>> GetUsersPostsByCategory(string categoryName);
        Task<IEnumerable<Post>> GetUsersPostsByTag(string tagName);
        Task<Post> GetPostByIdAsync(Guid Id);
        Task<Post> GetPostByUrlHandleAsync(string urlHandle);
        Task<Post> AddPostAsync(Post post);
        Task<Post> UpdatePostAsync(Post post);
        Task<Post> DeletePostAsync(Guid Id);
    }
}
