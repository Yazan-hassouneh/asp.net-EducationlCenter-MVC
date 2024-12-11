using EducationalCenter.Core.VMs.ReviewsVMs;
using EducationalCenter.EF.Configuration.VMsValidation.BaseValidation.BlogReviews;
using FluentValidation;

namespace EducationalCenter.EF.Configuration.VMsValidation.ReviewsValidation
{
	public class MentorReviewsFormVMValidation : AbstractValidator<MentorReviewFormVM>
	{
		public MentorReviewsFormVMValidation()
		{
			Include(new BaseReviewsTextVMValidation());
		}
	}
}
