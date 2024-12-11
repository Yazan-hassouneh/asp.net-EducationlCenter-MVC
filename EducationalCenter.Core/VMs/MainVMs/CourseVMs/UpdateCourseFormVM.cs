using EducationalCenter.Core.Interfaces.VMsInterfaces;
using EducationalCenter.Core.Interfaces.VMsInterfaces.Course;
using System.Web.Mvc;

namespace EducationalCenter.Core.VMs.MainVMs.CourseVMs
{
	public class UpdateCourseFormVM : IImagePathVM, IBaseCourseVM
	{
		public string Title { get; set; } = null!;
		public float Price { get; set; }
		public string ImagePath { get; set; } = null!;
		public string Description { get; set; } = null!;
		public List<int> MentorsId { get; set; } = [];
		public ICollection<SelectListItem> Mentors { get; set; } = [];
	}
}
