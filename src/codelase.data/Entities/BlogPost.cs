namespace codelase.data.Entities
{
    public class BlogPost : BaseEntity
    {
        public string Title { get; set; }
        public string Category { get; set; }
        public string Body { get; set; }
    }
}