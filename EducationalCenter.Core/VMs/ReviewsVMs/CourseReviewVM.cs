using EducationalCenter.Core.Interfaces.VMsInterfaces.BlogReviews;

namespace EducationalCenter.VMs.ReviewsVMs
{
	public class CourseReviewVM : IBaseBlogReviewsVM, IBlogReviewsTextVM
	{
		public required string UserId { get; set; }
		public required string UserName { get; set; }
		public required string Text { get; set; }
		public DateTime CreatedDate { get; set; }
	}
}
