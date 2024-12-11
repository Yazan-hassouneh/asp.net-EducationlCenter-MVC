using EducationalCenter.Core.Interfaces.VMsInterfaces.BlogReviews;

namespace EducationalCenter.Core.VMs.ReviewsVMs
{
	public class MentorReviewVM : IBaseBlogReviewsVM, IBlogReviewsTextVM
	{
		public required string UserId { get; set; }
		public required string UserName { get; set; }
		public required string Text { get; set; }
		public DateTime CreatedDate { get; set; }
	}
}
