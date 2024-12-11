using EducationalCenter.Core.Interfaces.VMsInterfaces;
using EducationalCenter.Core.Interfaces.VMsInterfaces.BlogReviews;
using EducationalCenter.Core.VMs.ReviewsVMs;

namespace EducationalCenter.Core.VMs.MainVMs.BlogVMs
{
	public class BlogVM : IBaseBlogReviewsVM, IBlogReviewsTextVM, ITitleBlogVM, IImagePathVM
	{
		public int Id { get; set; }
		public string Title { get; set; } = null!;
		public required string Text { get; set; }
		public string ImagePath { get; set; } = null!;
		public required string UserId { get; set; }
		public required string UserName { get; set; }
		public DateTime CreatedDate { get; set; }
		public ICollection<BlogReviewVM> Reviews { get; set; } = [];
	}
}
