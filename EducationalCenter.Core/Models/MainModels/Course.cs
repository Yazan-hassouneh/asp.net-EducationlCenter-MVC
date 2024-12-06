using EducationalCenter.Core.Models.BaseModels;
using EducationalCenter.Core.Models.M2MRelations;
using EducationalCenter.Core.Models.ReviewsModels;

namespace EducationalCenter.Core.Models.DomainModels
{
	public class Course : MainBase
	{
		public float Price { get; set; }
		public string? Image { get; set; }
		public virtual ICollection<CourseReview> Reviews { get; set; } = [];
		public virtual ICollection<StudentsCourses> AllStudents { get; set; } = [];
		public virtual ICollection<MentorsCourses> Mentors { get; set; } = [];
	}
}
