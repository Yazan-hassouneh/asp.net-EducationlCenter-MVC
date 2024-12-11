using EducationalCenter.Core.Const;
using EducationalCenter.Core.Interfaces.VMsInterfaces.Course;
using FluentValidation;

namespace EducationalCenter.EF.Configuration.VMsValidation.BaseValidation.Course
{
	public class BaseCourseVMValidation : AbstractValidator<IBaseCourseVM>
	{
		public BaseCourseVMValidation()
		{
			RuleFor(x => x.Title).NotEmpty().WithMessage("Title Cannot Be Empty").MaximumLength(ModelsSettings.MaxCourseTitleLength).WithMessage($"Title Cann't be More Than {ModelsSettings.MaxCourseTitleLength} Characters");
			RuleFor(x => x.Price).NotEmpty().WithMessage("Price Is Required").GreaterThanOrEqualTo(0).WithMessage("Price CANN'T be Less Than 0");
			RuleFor(x => x.Description).NotEmpty().WithMessage("Description Is Required !").MaximumLength(ModelsSettings.MaxCourseDescriptionLength).WithMessage($"Description Should Not Be More Than {ModelsSettings.MaxCourseDescriptionLength} Character");
				
		}
	}
}
