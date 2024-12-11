using EducationalCenter.Core.VMs.MainVMs.BlogVMs;
using EducationalCenter.EF.Configuration.VMsValidation.BaseValidation;
using EducationalCenter.EF.Configuration.VMsValidation.BaseValidation.BlogReviews;
using FluentValidation;

namespace EducationalCenter.EF.Configuration.VMsValidation.BlogValidation
{
	public class CreateBlogValidation : AbstractValidator<CreateBlogFormVM>
	{
		public CreateBlogValidation()
		{
			Include(new BlogTitleVMValidation());
			Include(new BaseReviewsTextVMValidation());
			Include(new BaseAddImageVMValidation());
		}
	}
}
