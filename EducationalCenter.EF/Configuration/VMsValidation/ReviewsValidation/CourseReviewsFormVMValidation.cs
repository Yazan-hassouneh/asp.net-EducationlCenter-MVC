using EducationalCenter.EF.Configuration.VMsValidation.BaseValidation.BlogReviews;
using EducationalCenter.VMs.ReviewsVMs;
using FluentValidation;

namespace EducationalCenter.EF.Configuration.VMsValidation.ReviewsValidation
{
	public class CourseReviewsFormVMValidation : AbstractValidator<CourseReviewFormVM>
	{
		public CourseReviewsFormVMValidation()
		{
			Include(new BaseReviewsTextVMValidation());
		}
	}
}
