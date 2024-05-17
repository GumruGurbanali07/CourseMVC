using System.ComponentModel.DataAnnotations;

namespace CourseApp.Areas.Admin.Models.TestimonialDTO
{
    public class CreateTestimonialDTO
    {
        [Required(ErrorMessage ="Section can not be null")]
        public IFormFile TestimonialImage { get; set; }
        [Required(ErrorMessage = "Section can not be null")]
        public string TestimonialName { get; set; }
        [Required(ErrorMessage = "Section can not be null")]
        public string TestimonialDescription { get; set; }
        public bool IsActive { get; set; }
    }
}
