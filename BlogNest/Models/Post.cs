using BlogNest.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace BlogNest.Models
{
    public class Post
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        //public int CategoryId { get; set; }
        //public int AuthorId { get; set; }
        public PostStatus Status { get; set; }
       //public int UserId { get; set; }
        public User User { get; set; }
        public List<Comment> Comments { get; set; }
        public List<Like> Likes { get; set; }
        public ICollection<Tag> Tags { get; set; }
        public ICollection<Category> Categories { get; set; }
    }
}
