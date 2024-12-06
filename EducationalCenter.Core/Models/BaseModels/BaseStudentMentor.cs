using EducationalCenter.Core.Models.M2MRelations;

namespace EducationalCenter.Core.Models.BaseModels
{
	public class BaseStudentMentor
	{
		public int Id { get; set; }
		public string UserId { get; set; } = null!;
		public virtual ApplicationUser? User { get; set; }
		public virtual ICollection<StudentsCourses> CoursesInAction { get; set; } = [];
	}
}
