using EducationalCenter.Core.Interfaces.VMsInterfaces;
using EducationalCenter.Core.Interfaces.VMsInterfaces.BlogReviews;
using Microsoft.AspNetCore.Http;

namespace EducationalCenter.Core.VMs.MainVMs.BlogVMs
{
	public class CreateBlogFormVM : IAddImageVM, ITitleBlogVM, IBlogReviewsTextVM
	{
		public int Id { get; set; }
		public string Text { get; set; } = null!;
		public string Title { get; set; } = null!;
		public IFormFile? Image { get; set; }
	}
}
