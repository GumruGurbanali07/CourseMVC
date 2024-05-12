using System.ComponentModel.DataAnnotations;

namespace CourseApp.Areas.Admin.Models.AboutDTOs
{
    public class UpdateAboutDTO
    {
        public int AboutId { get; set; }
        [Required(ErrorMessage = "Section can not be null")]
        public string AboutTitle { get; set; }
        [Required(ErrorMessage = "Section can not be null")]
        public string AboutDescription { get; set; }       
        public IFormFile? Image { get; set; }
    }
}
