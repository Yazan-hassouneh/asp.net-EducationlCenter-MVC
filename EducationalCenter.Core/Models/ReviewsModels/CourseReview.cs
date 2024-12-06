using EducationalCenter.Core.Models.BaseModels;
using EducationalCenter.Core.Models.DomainModels;

namespace EducationalCenter.Core.Models.ReviewsModels
{
	public class CourseReview : BaseBlogReview 
	{
		public int? CourseId { get; set; }
		public virtual Course? Course{ get; set; }
	}
}
