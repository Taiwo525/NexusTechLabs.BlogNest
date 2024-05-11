
using System.ComponentModel.DataAnnotations;

namespace BlogNest.Models
{
    public class Post
    {
        public Guid Id { get; set; }
        public string Heading { get; set; }
        public string PageTitle { get; set; }
        public string Content { get; set; }
        public string ShortDescription { get; set; }
        public string FeaturedImageUrl { get; set; }
        public string UrlHandle { get; set; }
        public DateTime PublishedDate { get; set; }
        public string Author { get; set; }
        public bool Visible { get; set; }

        //public int CategoryId { get; set; }
        //public int AuthorId { get; set; }
        //public PostStatus Status { get; set; }
        //public int UserId { get; set; }
        //public User User { get; set; }
        //public List<Comment> Comments { get; set; }
        public List<Like> Likes { get; set; }
        public ICollection<Tag> Tags { get; set; }
        //public ICollection<Category> Categories { get; set; }
        //public ICollection<PostTag> PostTags { get; set; }
        //public ICollection<PostCategory> PostCategories { get; set; }
    }
}
