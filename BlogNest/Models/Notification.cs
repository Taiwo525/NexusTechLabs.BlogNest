using BlogNest.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace BlogNest.Models
{
    public class Notification
    {
        [Key]
        public int Id { get; set; }
        //public int UserId { get; set; }
        public string Content { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool IsRead { get; set; }
        public NotificationType Type { get; set; }
        public User User { get; set; }
    }
}
