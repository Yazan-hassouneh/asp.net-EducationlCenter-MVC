using EducationalCenter.Core.Models.DomainModels;

namespace EducationalCenter.Core.Models.M2MRelations
{
	public class MentorsCourses
	{
		public int CourseId { get; set; }
		public virtual Course? Course { get; set; }		
		public int MentorId { get; set; }
		public virtual Mentor? Mentor { get; set; }
	}
}
