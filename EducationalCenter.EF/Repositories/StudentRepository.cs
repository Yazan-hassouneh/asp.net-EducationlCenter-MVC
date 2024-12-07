using EducationalCenter.Core.Interfaces.RepositoryInterfaces.Repos;
using EducationalCenter.Core.Models.DomainModels;
using EducationalCenter.EF.Data;

namespace EducationalCenter.EF.Repositories
{
	internal class StudentRepository(ApplicationDbContext context) : BaseRepository<Student>(context), IStudentRepository
	{
		private readonly ApplicationDbContext _context = context; 
	}
}
