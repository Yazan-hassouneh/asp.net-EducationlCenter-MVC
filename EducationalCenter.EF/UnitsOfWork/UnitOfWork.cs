using EducationalCenter.Core.Interfaces.RepositoryInterfaces;
using EducationalCenter.Core.Interfaces.RepositoryInterfaces.Repos;
using EducationalCenter.Core.Interfaces.RepositoryInterfaces.Repos.Reviews;
using EducationalCenter.EF.Data;
using EducationalCenter.EF.Repositories;
using EducationalCenter.EF.Repositories.Reviews;


namespace EducationalCenter.EF.UnitsOfWork
{
	public class UnitOfWork : IUnitOfWork
	{
		private readonly ApplicationDbContext _context;
		public IMentorRepository Mentors { get; private set; }
		public IStudentRepository Students { get; private set; }
		public IBlogRepository Blogs{ get; private set; }
		public ICourseRepository Courses{ get; private set; }
		public IMentorReviewRepository MentorReviews { get; private set; }
		public IBlogReviewRepository BlogReviews { get; private set; }
		public ICourseReviewRepository CourseReviews { get; private set; }

		public UnitOfWork(ApplicationDbContext context)
		{
			_context = context;
			Mentors = new MentorRepository(_context);
			Students = new StudentRepository(_context);
			Courses = new CourseRepository(_context);
			Blogs = new BlogRepository(_context);
			MentorReviews = new MentorReviewsRepository(_context);
			CourseReviews = new CourseReviewsRepository(_context);
			BlogReviews = new BlogReviewsRepository(_context);
		}
		public async Task<int> Complete() => await _context.SaveChangesAsync();
		public void Dispose()
		{
			_context.Dispose();
		}
	}
}
