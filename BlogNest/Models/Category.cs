namespace BlogNest.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        //public string CategoryId { get; set; } = Guid.NewGuid().ToString();
        public ICollection<Post> Posts { get; set; }

    }
}
