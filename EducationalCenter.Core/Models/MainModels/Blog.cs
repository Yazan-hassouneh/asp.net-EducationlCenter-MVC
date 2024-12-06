using EducationalCenter.Core.Models.BaseModels;
using EducationalCenter.Core.Models.ReviewsModels;

namespace EducationalCenter.Core.Models.DomainModels
{
	public class Blog : BaseBlogReview
	{
		public string Title { get; set; } = null!;
		public string? Image { get; set; }
		public virtual ICollection<BlogReview> Reviews { get; set; } = [];
	}
}
