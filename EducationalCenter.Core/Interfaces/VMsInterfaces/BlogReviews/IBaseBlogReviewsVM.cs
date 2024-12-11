namespace EducationalCenter.Core.Interfaces.VMsInterfaces.BlogReviews
{
	public interface IBaseBlogReviewsVM
	{
		string UserId { get; set; }
		string UserName { get; set; }
		DateTime CreatedDate { get; set; }
	}
}
