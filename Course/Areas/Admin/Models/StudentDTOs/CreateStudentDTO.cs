using CourseApp.Models;
using System.ComponentModel.DataAnnotations;

namespace CourseApp.Areas.Admin.Models.StudentDTOs
{
	public class CreateStudentDTO
	{
		[Required(ErrorMessage ="Section can not be null")]
		public IFormFile StudentImage { get; set; }
		[Required(ErrorMessage = "Section can not be null")]
		public string StudentName { get; set; }
		[Required(ErrorMessage = "Section can not be null")]
		public DateTime BirthDate { get; set; }
		[Required(ErrorMessage = "Section can not be null")]
		public string PhoneNumber { get; set; }
		[Required(ErrorMessage = "Section can not be null")]
		public string Email { get; set; }
		public bool IsActive { get; set; }
		
	}
}
