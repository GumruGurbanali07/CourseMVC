using CourseApp.Models;
using System.ComponentModel.DataAnnotations;

namespace CourseApp.Areas.Admin.Models.TeacherDTOs
{
    public class CreateTeacherDTO
    {
        [Required(ErrorMessage ="Section can not be null")]
        public string TeacherName { get; set; }    
        public bool IsActive { get; set; }
        [Required(ErrorMessage = "Section can not be null")]
        public IFormFile TeacherImage { get; set; }




    }
}
