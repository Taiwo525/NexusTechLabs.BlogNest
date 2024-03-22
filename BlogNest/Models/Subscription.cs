using BlogNest.Models.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlogNest.Models
{
    public class Subscription
    {
        [Key]
        public int Id { get; set; }
        //public int UserId { get; set; }
        //public int AuthorId { get; set; }
        public DateTime SubscribedAt { get; set; }
        public SubscriptionStatus Status { get; set; }
        public User User { get; set; }
    }
}
