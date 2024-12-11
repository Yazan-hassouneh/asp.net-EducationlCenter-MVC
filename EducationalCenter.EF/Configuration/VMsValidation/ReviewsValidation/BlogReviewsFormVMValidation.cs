using EducationalCenter.Core.VMs.ReviewsVMs;
using EducationalCenter.EF.Configuration.VMsValidation.BaseValidation.BlogReviews;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationalCenter.EF.Configuration.VMsValidation.ReviewsValidation
{
	public class BlogReviewsFormVMValidation : AbstractValidator<BlogReviewFormVM>
	{
		public BlogReviewsFormVMValidation() 
		{
			Include(new BaseReviewsTextVMValidation());
		}
	}
}
