using BlogNest.Models;

namespace BlogNest.Core.Repositories
{
    public interface ITagRepo
    {
        Task<IEnumerable<Tag>> GetAllAsync();
        Task<Tag> GetByIdAsync(Guid id);
        Task<Tag> AddTagAsync(Tag tag);
        Task<Tag> UpdateTagAsync(Tag tag);
        Task<Tag> DeleteTagAsync(Guid id);
    }
}
