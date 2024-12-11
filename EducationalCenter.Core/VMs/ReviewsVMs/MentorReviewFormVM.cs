using EducationalCenter.Core.Interfaces.VMsInterfaces.BlogReviews;

namespace EducationalCenter.Core.VMs.ReviewsVMs
{
	public class MentorReviewFormVM : IBlogReviewsTextVM
	{
		public string Text { get; set; } = null!;
	}
}
