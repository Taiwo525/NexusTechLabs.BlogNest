using System.ComponentModel.DataAnnotations;

namespace BlogNest.Models
{
    public class Like
    {
        [Key]
        public Guid Id { get; set; }
        public Guid PostId { get; set; }
        public Guid UserId { get; set; }
        //public DateTime LikedAt { get; set; }
        //public int CommentId { get; set; }
        //public Comment Comment { get; set; }
        //public User User { get; set; }
        //public Post Post { get; set; }
    }
}
