using System.ComponentModel.DataAnnotations;

namespace CourseApp.Areas.Admin.Models.AdminDTOs
{
    public class AdminLoginDTO
    {
        [Required(ErrorMessage ="Section can not be null")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Section can not be null")]
        public string Password { get; set; }
    }
}
