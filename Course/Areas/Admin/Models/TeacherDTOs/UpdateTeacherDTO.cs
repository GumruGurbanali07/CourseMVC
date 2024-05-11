using System.ComponentModel.DataAnnotations;

namespace CourseApp.Areas.Admin.Models.TeacherDTOs
{
    public class UpdateTeacherDTO
    {
     
        public int TeacherId { get; set; }  
        [Required(ErrorMessage = "Section can not be null")]
        public string TeacherName { get; set; }
        public bool IsActive { get; set; }
       
        public IFormFile? TeacherImage { get; set; }
    }
}
