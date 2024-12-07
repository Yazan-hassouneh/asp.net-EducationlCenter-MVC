using EducationalCenter.Core.Interfaces.RepositoryInterfaces.Repos.Reviews;
using EducationalCenter.Core.Models.ReviewsModels;
using EducationalCenter.EF.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationalCenter.EF.Repositories.Reviews
{
	internal class BlogReviewsRepository(ApplicationDbContext context) : BaseReviewsRepository<BlogReview>(context), IBlogReviewRepository
	{
		private readonly ApplicationDbContext _context = context;
	}
}
