using EducationalCenter.Core.Const;
using EducationalCenter.Core.VMs.MainVMs.CourseVMs;
using EducationalCenter.EF.Configuration.VMsValidation.BaseValidation;
using EducationalCenter.EF.Configuration.VMsValidation.BaseValidation.Course;
using FluentValidation;

namespace EducationalCenter.EF.Configuration.VMsValidation.CourseValidation
{
	public class CreateCourseVMValidation : AbstractValidator<CreateCourseFormVM>
	{
		public CreateCourseVMValidation()
		{
			Include(new BaseAddImageVMValidation());
			Include(new BaseCourseVMValidation());
			RuleFor(x => x.MentorsId).NotEmpty().WithMessage("At Least One Mentor!.");
		}
	}
}
