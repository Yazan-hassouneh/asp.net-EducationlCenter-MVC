using EducationalCenter.Core.Interfaces.VMsInterfaces;
using EducationalCenter.Core.Interfaces.VMsInterfaces.Course;
using Microsoft.AspNetCore.Http;
using System.Web.Mvc;

namespace EducationalCenter.Core.VMs.MainVMs.CourseVMs
{
	public class CreateCourseFormVM : IAddImageVM, IBaseCourseVM
	{
		public string Title { get; set; } = null!;
		public float Price { get; set; }
		public string Description { get; set; } = null!;
		public List<int> MentorsId { get; set; } = [];
		public ICollection<SelectListItem> Mentors { get; set; } = [];
		public IFormFile? Image { get; set; }
	}
}
