using BlogNest.Models;

namespace BlogNest.Core.Repositories
{
    public interface IPostRepo
    {
        Task<IEnumerable<Post>> GetAllPosts();
        Task<IEnumerable<Post>> GetUsersPosts(int Id);
        Task<IEnumerable<Post>> SearchPosts(string query);
        Task<IEnumerable<Post>> GetUsersPostsByCategory(string categoryName);
        Task<IEnumerable<Post>> GetUsersPostsByTag(string tagName);
        Task<Post> GetPostById(int Id);
        Task AddPost(Post post);
        Task UpdatePost(Post post);
        Task DeletePost(int Id);
    }
}
