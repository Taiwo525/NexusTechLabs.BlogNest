using BlogNest.Models;

namespace BlogNest.Core.Repositories
{
    public interface IUserRepo
    {
        Task<IEnumerable<User>> GetAllUsersAsync();
        Task<User> GetByIdAsync(int Id);
        Task AddUser(User user);
        Task UpdateUser(User user);
        Task DeleteUser(int Id);
    }
}
