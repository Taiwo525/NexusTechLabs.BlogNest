using BlogNest.Core.Repositories;
using BlogNest.Data;
using BlogNest.Models;
using Microsoft.EntityFrameworkCore;

namespace BlogNest.Core.Implementations
{
    public class TagRepo : ITagRepo
    {
        private readonly BlogDbContext _blog;
        public TagRepo(BlogDbContext blog)
        {
            _blog = blog;
        }
        public async Task<Tag> AddTagAsync(Tag tag)
        {
            await _blog.Tags.AddAsync(tag);
            await _blog.SaveChangesAsync();
            return tag;
        }

        public async Task<Tag> DeleteTagAsync(Guid id)
        {
            var deleted = await _blog.Tags.FindAsync(id);
            if (deleted != null) 
            {
                _blog.Tags.Remove(deleted);
                await _blog.SaveChangesAsync();
                return deleted;
            }
            return null;
        }

        public async Task<IEnumerable<Tag>> GetAllAsync()
        {
            return await _blog.Tags.ToListAsync();
        }

        public async Task<Tag> GetByIdAsync(Guid id)
        {
            return await _blog.Tags.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Tag> UpdateTagAsync(Tag tag)
        {

            var updated = await _blog.Tags.FindAsync(tag.Id);
            if (updated != null)
            {

                _blog.Tags.Update(updated);
                await _blog.SaveChangesAsync();
            }
            return null;
        }
    }
}
