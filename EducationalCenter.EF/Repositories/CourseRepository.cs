using EducationalCenter.Core.Interfaces.RepositoryInterfaces.Repos;
using EducationalCenter.Core.Models.DomainModels;
using EducationalCenter.EF.Data;

namespace EducationalCenter.EF.Repositories
{
	internal class CourseRepository(ApplicationDbContext context) : BaseRepository<Course>(context), ICourseRepository
	{
		private readonly ApplicationDbContext _context = context;
	}
}
