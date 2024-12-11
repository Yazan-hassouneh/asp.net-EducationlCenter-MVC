using EducationalCenter.Core.Const;
using EducationalCenter.Core.VMs.RoleVMs;
using FluentValidation;

namespace EducationalCenter.EF.Configuration.VMsValidation.RoleValidation
{
	public class RoleFormVMValidation : AbstractValidator<RoleFormVM>
	{
		public RoleFormVMValidation()
		{
			RuleFor(x => x.Name).NotEmpty().WithMessage("Name Is Required !").MaximumLength(ModelsSettings.MaxRoleNameLength).WithMessage($"Name Should Not Be More Than {ModelsSettings.MaxRoleNameLength} Character");
		}
	}
}
