using EducationalCenter.Core.Models.BaseModels;
using EducationalCenter.Core.Models.DomainModels;

namespace EducationalCenter.Core.Models.ReviewsModels
{
	public class BlogReview : BaseBlogReview
	{
		public int? BlogId { get; set; }
		public virtual Blog? Blog { get; set; }
	}
}
