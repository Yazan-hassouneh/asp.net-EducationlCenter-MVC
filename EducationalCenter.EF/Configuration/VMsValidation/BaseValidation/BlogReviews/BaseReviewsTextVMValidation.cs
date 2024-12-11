using EducationalCenter.Core.Const;
using EducationalCenter.Core.Interfaces.VMsInterfaces.BlogReviews;
using FluentValidation;

namespace EducationalCenter.EF.Configuration.VMsValidation.BaseValidation.BlogReviews
{
	public class BaseReviewsTextVMValidation : AbstractValidator<IBlogReviewsTextVM>
	{
		public BaseReviewsTextVMValidation()
		{
			RuleFor(x => x.Text).NotEmpty().MaximumLength(ModelsSettings.MaxBlogReviewsTextLength);
		}
	}
}
