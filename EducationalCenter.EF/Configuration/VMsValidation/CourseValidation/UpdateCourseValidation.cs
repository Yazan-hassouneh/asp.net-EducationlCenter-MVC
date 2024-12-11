using EducationalCenter.Core.VMs.MainVMs.CourseVMs;
using EducationalCenter.EF.Configuration.VMsValidation.BaseValidation.Course;
using EducationalCenter.EF.Configuration.VMsValidation.BaseValidation;
using FluentValidation;

namespace EducationalCenter.EF.Configuration.VMsValidation.CourseValidation
{
	public class UpdateCourseValidation : AbstractValidator<UpdateCourseFormVM>
	{
		public UpdateCourseValidation()
		{
			Include(new ImagePathVMValidation());
			Include(new BaseCourseVMValidation());
			RuleFor(x => x.MentorsId).NotEmpty().WithMessage("At Least One Mentor!.");
		}
	}
}
