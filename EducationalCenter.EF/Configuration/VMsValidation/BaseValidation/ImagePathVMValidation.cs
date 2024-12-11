using EducationalCenter.Core.Interfaces.VMsInterfaces;
using FluentValidation;

namespace EducationalCenter.EF.Configuration.VMsValidation.BaseValidation
{
	internal class ImagePathVMValidation : AbstractValidator<IImagePathVM>
	{
		public ImagePathVMValidation()
		{
			RuleFor(x => x.ImagePath).NotEmpty();
		}
	}
}
