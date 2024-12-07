using EducationalCenter.Core.Interfaces.RepositoryInterfaces.Repos.Reviews;
using EducationalCenter.Core.Models.ReviewsModels;
using EducationalCenter.EF.Data;

namespace EducationalCenter.EF.Repositories.Reviews
{
	internal class MentorReviewsRepository(ApplicationDbContext context) : BaseReviewsRepository<MentorReview>(context), IMentorReviewRepository
	{
		private readonly ApplicationDbContext _context = context;
	}
}
