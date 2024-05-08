//using BlogNest.Core.Repositories;
//using BlogNest.Data;
//using BlogNest.Models;
//using Microsoft.EntityFrameworkCore;

//namespace BlogNest.Core.Implementations
//{
//    public class UserRepo : IUserRepo
//    {
//        private readonly BlogDbContext _db;
//        public UserRepo(BlogDbContext db)
//        {
//            _db = db;
//        }
//        public async Task AddUser(User user)
//        {
//            await _db.Users.AddAsync(user);
//            await _db.SaveChangesAsync();
//        }

//        public async Task DeleteUser(int Id)
//        {
//            var userToDelete = await _db.Users.FindAsync(Id);
//            _db.Users.Remove(userToDelete);
//            await _db.SaveChangesAsync();
//        }

//        public async Task<IEnumerable<User>> GetAllUsersAsync()
//        {
//            return await _db.Users.ToListAsync();
//        }

//        public async Task<User> GetUserByIdAsync(int Id)
//        {
//            return await _db.Users.FindAsync(Id);
//        }

//        public async Task UpdateUser(User user)
//        {
//            _db.Users.Update(user);
//            await _db.SaveChangesAsync();
//        }
//    }
//}
