using EducationalCenter.Core.VMs.MainVMs.CourseVMs;

namespace EducationalCenter.Core.VMs.BaseModels
{
	public class BaseApplicationUserVM
	{
		public string? Id { get; set; }
		public string UserName { get; set; } = null!;
		public string Email { get; set; } = null!;
		public string? ImagePath { get; set; }
		public ICollection<CourseVM> AllCourses { get; set; } = [];
	}
}
