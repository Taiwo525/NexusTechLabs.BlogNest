//using BlogNest.Core.Repositories;
//using BlogNest.Data;
//using BlogNest.Models;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Migrations.Operations;

//namespace BlogNest.Core.Implementations
//{
//    public class CommentRepo : ICommentRepo
//    {
//        private readonly BlogDbContext _context;
//        public CommentRepo(BlogDbContext context) 
//        {
//            _context = context;
//        }
//        public async Task<Comment> AddComment(Comment comment)
//        {
//            throw new NotImplementedException();
//        }

//        public async Task<Comment> DeleteComment(int id)
//        {
//            var deleted = await _context.Comments.FindAsync(id);
//            if (deleted != null)
//            {
//                _context.Comments.Remove(deleted);
//                await _context.SaveChangesAsync();
//            }
//            return null;
//        }

//        public async Task<ICollection<Comment>> GetAllComments()
//        {
//            return await _context.Comments.ToListAsync();
//        }

//        public async Task<Comment> GetCommentById(int id)
//        {
//            return await _context.Comments.Where(p=>p.UserId==id).FirstOrDefaultAsync();
//        }

        
//        public Task<Comment> UpdateComment(Comment comment)
//        {
//            throw new NotImplementedException();
//        }
//    }
//}
