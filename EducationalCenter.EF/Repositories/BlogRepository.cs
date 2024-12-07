using EducationalCenter.Core.Interfaces.RepositoryInterfaces.Repos;
using EducationalCenter.Core.Models.DomainModels;
using EducationalCenter.EF.Data;

namespace EducationalCenter.EF.Repositories
{
	internal class BlogRepository(ApplicationDbContext context) : BaseRepository<Blog>(context), IBlogRepository
	{
		private readonly ApplicationDbContext _context = context;
	}
}
