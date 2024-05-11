using System.ComponentModel.DataAnnotations;

namespace CourseApp.Models
{
    public class Teacher
    {
        [Key]
        public int TeacherId { get; set; }
        public string TeacherName { get; set; }
        public List<Courses> Courses { get; set; }
        public bool IsActive { get; set; }
        public string TeacherImage { get; set; }


    }
}
