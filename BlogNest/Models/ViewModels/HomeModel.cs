namespace BlogNest.Models.ViewModels
{
    public class HomeModel
    {
        public IEnumerable<Post> Posts { get; set; }
        public IEnumerable<Tag> Tags { get; set; }
    }
}
