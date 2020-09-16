using System.ComponentModel.DataAnnotations;

namespace CodeLase.web.Models.DTOs
{
    public class CreateBlogDTO
    {
        [Required(ErrorMessage = "Title is required")]
        [Display(Name = "Title")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Category is required")]
        [Display(Name = "Category")]
        public string Category { get; set; }

        [Required(ErrorMessage = "Body is required")]
        [Display(Name = "Body")]
        public string Body { get; set; }
    }
}