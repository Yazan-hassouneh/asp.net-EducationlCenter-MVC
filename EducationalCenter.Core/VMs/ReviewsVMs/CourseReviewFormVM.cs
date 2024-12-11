using EducationalCenter.Core.Interfaces.VMsInterfaces.BlogReviews;

namespace EducationalCenter.VMs.ReviewsVMs
{
	public class CourseReviewFormVM : IBlogReviewsTextVM
	{
		public string Text { get; set; } = null!;
}
}
