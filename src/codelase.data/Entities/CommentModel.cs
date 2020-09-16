using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeLase.data.Entities
{
    public class CommentModel : BaseEntity
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Comment { get; set; }

        [Required]
        [ForeignKey("BlogPost")]
        public int BlogId { get; set; }
    }
}