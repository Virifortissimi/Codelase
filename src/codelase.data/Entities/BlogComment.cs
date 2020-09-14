using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace codelase.data.Entities
{
    public class BlogComment : BaseEntity
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Comment { get; set; }

        [Required]
        [ForeignKey("BlogPost")]
        public int BlogId { get; set; }
    }
}