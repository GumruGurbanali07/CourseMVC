using CourseApp.Models;

namespace CourseApp.Areas.Admin.Models
{
    public class CreateCourseDTO
    {
       
        public string CourseName { get; set; }
        public decimal Price { get; set; }
        public string CourseDescription { get; set; }
        public bool IsActive { get; set; }
        public IFormFile CourseImage { get; set; }

        public int CourseCategoryId { get; set; }
      

        public int TeacherId { get; set; }
     

      






    }
}
