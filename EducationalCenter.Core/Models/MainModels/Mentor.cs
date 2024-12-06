using EducationalCenter.Core.Models.BaseModels;
using EducationalCenter.Core.Models.M2MRelations;
using EducationalCenter.Core.Models.ReviewsModels;

namespace EducationalCenter.Core.Models.DomainModels
{
	public class Mentor : BaseStudentMentor
	{
		public List<string> Experiences { get; set; } = null!;
		public virtual ICollection<MentorReview> Reviews { get; set; } = [];
		public virtual ICollection<MentorsCourses> AllCourses { get; set; } = [];
	}
}
