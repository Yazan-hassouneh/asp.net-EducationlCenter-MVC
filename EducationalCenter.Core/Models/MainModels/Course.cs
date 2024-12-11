using EducationalCenter.Core.Models.BaseModels;
using EducationalCenter.Core.Models.M2MRelations;
using EducationalCenter.Core.Models.ReviewsModels;

namespace EducationalCenter.Core.Models.DomainModels
{
	public class Course : MainBase
	{
		public string Title { get; set; } = null!;
		public float Price { get; set; }
		public string Description { get; set; } = null!;
		public string? Image { get; set; }
		public virtual ICollection<CourseReview> Reviews { get; set; } = [];
		public virtual ICollection<StudentsCourses> AllStudents { get; set; } = [];
		public virtual ICollection<MentorsCourses> Mentors { get; set; } = [];
	}
}
