using EducationalCenter.Core.Interfaces.RepositoryInterfaces.Repos;
using EducationalCenter.Core.Models.DomainModels;
using EducationalCenter.EF.Data;

namespace EducationalCenter.EF.Repositories
{
	internal class MentorRepository(ApplicationDbContext context) : BaseRepository<Mentor>(context), IMentorRepository
	{
		private readonly ApplicationDbContext _context = context;
	}
}
