
using EducationalCenter.Core.Models.DomainModels;
using System.ComponentModel.DataAnnotations;

namespace EducationalCenter.Core.Models.M2MRelations
{
	public class StudentsCourses
	{
		public int CourseId { get; set; }
		public virtual Course? Course { get; set; }
		public int StudentId { get; set; }
		public virtual Student? Student { get; set; }
		public int MentorId { get; set; }
		public virtual Mentor? Mentor { get; set; }
		[Range(1, 100)]
		public short Mark { get; set; }

	}
}
