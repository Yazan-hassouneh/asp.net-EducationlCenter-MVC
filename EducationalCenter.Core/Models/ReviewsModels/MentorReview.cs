using EducationalCenter.Core.Models.BaseModels;
using EducationalCenter.Core.Models.DomainModels;

namespace EducationalCenter.Core.Models.ReviewsModels
{
	public class MentorReview : BaseBlogReview
	{
		public int? MentorId { get; set; }
		public virtual Mentor? Mentor { get; set; }
	}
}
