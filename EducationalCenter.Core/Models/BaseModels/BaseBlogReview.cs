
namespace EducationalCenter.Core.Models.BaseModels
{
	public class BaseBlogReview : MainBase
	{
		public string Text { get; set; } = null!;
		public string UserId { get; set; } = null!;
		public virtual ApplicationUser? User { get; set; }
	}
}
