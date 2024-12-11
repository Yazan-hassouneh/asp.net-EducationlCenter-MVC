

using EducationalCenter.Core.VMs.BaseModels;
using EducationalCenter.Core.VMs.MainVMs.CourseVMs;
using EducationalCenter.Core.VMs.ReviewsVMs;

namespace EducationalCenter.Core.VMs.MainVMs.MentorVMs
{
	public class MentorVM : BaseApplicationUserVM
	{
		public List<string> Experiences { get; set; } = null!;
		public virtual ICollection<MentorReviewVM> Reviews { get; set; } = [];
	}
}
