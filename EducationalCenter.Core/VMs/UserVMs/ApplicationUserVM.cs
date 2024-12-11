using EducationalCenter.Core.VMs.BaseModels;

namespace EducationalCenter.Core.VMs.UserVMs
{
	public class ApplicationUserVM : BaseApplicationUserVM
	{
		public bool IsDeleted { get; set; } = false;
	}
}
