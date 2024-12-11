using EducationalCenter.Core.Interfaces.VMsInterfaces;
using EducationalCenter.Core.Interfaces.VMsInterfaces.BlogReviews;

namespace EducationalCenter.Core.VMs.MainVMs.BlogVMs
{
	public class UpdateBlogFormVM : IBlogReviewsTextVM, ITitleBlogVM, IImagePathVM
	{
		public int Id { get; set; }
		public string Text { get; set; } = null!;
		public string Title { get; set; } = null!;
		public string ImagePath { get; set; } = null!;
	}
}
