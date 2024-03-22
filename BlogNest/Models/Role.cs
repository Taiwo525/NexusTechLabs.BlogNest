using BlogNest.Models.Enums;

namespace BlogNest.Models
{
    public class Role
    {
        public int Id { get; set; }
        public UserRole Name { get; set; }
        public ICollection<User> Users { get; set; }

    }
}
