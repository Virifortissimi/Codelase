namespace CodeLase.data.Entities
{
    public class BlogModel : BaseEntity
    {
        public string Title { get; set; }
        public string Category { get; set; }
        public string Body { get; set; }
    }
}