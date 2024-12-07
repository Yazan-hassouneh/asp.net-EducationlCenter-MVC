using EducationalCenter.Core.Interfaces.RepositoryInterfaces.Repos;
using EducationalCenter.Core.Interfaces.RepositoryInterfaces.Repos.Reviews;

namespace EducationalCenter.Core.Interfaces.RepositoryInterfaces
{
	public interface IUnitOfWork : IDisposable
	{
		public IMentorRepository Mentors { get; }
		public IStudentRepository Students { get; }
		public IBlogRepository Blogs { get; }
		public ICourseRepository Courses{ get; }
		public IBlogReviewRepository BlogReviews{ get; }
		public ICourseReviewRepository CourseReviews{ get; }
		public IMentorReviewRepository MentorReviews{ get; }
		Task<int> Complete();
	}
}
