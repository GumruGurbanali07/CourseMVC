using System.ComponentModel.DataAnnotations;

namespace CourseApp.Areas.Admin.Models.CourseCategoryDTOs
{
    public class UpdateCourseCategoryDTO
    {
        public int CourseCategoryId { get; set; }
        [Required(ErrorMessage = "Section can not be null")]
        public string CourseCategoryName { get; set; }
        public bool IsActive { get; set; }
    }
}
