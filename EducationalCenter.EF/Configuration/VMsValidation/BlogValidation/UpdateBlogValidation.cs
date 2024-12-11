using FluentValidation;
using EducationalCenter.Core.VMs.MainVMs.BlogVMs;
using EducationalCenter.EF.Configuration.VMsValidation.BaseValidation.BlogReviews;
using EducationalCenter.EF.Configuration.VMsValidation.BaseValidation;

namespace EducationalCenter.EF.Configuration.VMsValidation.BlogValidation
{
	public class UpdateBlogValidation : AbstractValidator<UpdateBlogFormVM>
	{
		public UpdateBlogValidation()
		{
			Include(new BlogTitleVMValidation());
			Include(new BaseReviewsTextVMValidation());
			Include(new ImagePathVMValidation());
		}
	}
}
