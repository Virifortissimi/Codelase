using System;

namespace CodeLase.web.Models.DTOs
{
    public class ReadBlogDTO
    {
        public Guid Id { get; set; }

        public DateTime CreatedAt { get; set; }
        public bool IsDeleted { get; set; }
        public string Title { get; set; }
        public string Category { get; set; }
        public string Body { get; set; }
    }
}