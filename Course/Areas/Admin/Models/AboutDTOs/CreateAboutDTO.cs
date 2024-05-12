using System.ComponentModel.DataAnnotations;

namespace CourseApp.Areas.Admin.Models.AboutDTOs
{
    public class CreateAboutDTO
    {
        [Required(ErrorMessage ="Section can not be null")]
        public string AboutTitle { get; set; }
        [Required(ErrorMessage = "Section can not be null")]
        public string AboutDescription { get; set; }
        [Required(ErrorMessage = "Section can not be null")]
        public IFormFile Image { get; set; }
    }
}
