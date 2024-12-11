using EducationalCenter.Core.Interfaces.VMsInterfaces;
using FluentValidation;

namespace EducationalCenter.EF.Configuration.VMsValidation.BaseValidation
{
	public class BaseAddImageVMValidation : AbstractValidator<IAddImageVM>
	{
		public BaseAddImageVMValidation()
		{
			RuleFor(x => x.Image).NotEmpty().WithMessage("Image is required.");
		}
	}
}
