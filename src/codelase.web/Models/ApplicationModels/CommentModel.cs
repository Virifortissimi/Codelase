using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace codelase.web.Models.ApplicationModels
{
    public class CommentModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; }
        public DateTime DeletedAt { get; set; }
        public bool IsDeleted { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Comment { get; set; }

        [Required]
        [ForeignKey("BlogModel")]
        public int BlogId { get; set; }
    }
}