using EducationalCenter.Core.Interfaces.VMsInterfaces;
using EducationalCenter.Core.Interfaces.VMsInterfaces.Course;
using EducationalCenter.VMs.ReviewsVMs;
using System.Security.Cryptography;

namespace EducationalCenter.Core.VMs.MainVMs.CourseVMs
{
	public class CourseVM : IImagePathVM, IBaseCourseVM
	{
		public int Id { get; set; }
		public string Title { get; set; } = null!;
		public int NumberOfStudentsInRole { get; set; }
		public float Price { get; set; }
		public string Description { get; set; } = null!;
		public string ImagePath { get; set; } = null!;
		public DateTime CreatedAt { get; set; }
		public ICollection<CourseReviewVM> Reviews { get; set; } = [];
		public ICollection<MentorCourseVM> Mentors { get; set; } = [];
	}
}
