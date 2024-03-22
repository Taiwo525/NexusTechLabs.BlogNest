namespace BlogNest.Models
{
    public class Tag
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string TagType { get; set; } = string.Empty;
        public string TagValue { get; set; }
        public string Value { get; set; }
        public ICollection<Post> Posts { get; set; }

    }
}
