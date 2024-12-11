using EducationalCenter.Core.Const;
using EducationalCenter.Core.Interfaces.VMsInterfaces.BlogReviews;
using FluentValidation;

namespace EducationalCenter.EF.Configuration.VMsValidation.BaseValidation.BlogReviews
{
	internal class BlogTitleVMValidation : AbstractValidator<ITitleBlogVM>
	{
		public BlogTitleVMValidation()
		{
			RuleFor(x => x.Title).NotEmpty().MaximumLength(ModelsSettings.MaxBlogTitleLength);
		}
	}
}
