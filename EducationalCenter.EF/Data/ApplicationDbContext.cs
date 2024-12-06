using EducationalCenter.Core.Models.BaseModels;
using EducationalCenter.Core.Models.DomainModels;
using EducationalCenter.Core.Models.M2MRelations;
using EducationalCenter.Core.Models.ReviewsModels;
using EducationalCenter.EF.Configuration.Models.BaseConfig;
using EducationalCenter.EF.Configuration.Models.M2MConfig;
using EducationalCenter.EF.Configuration.Models.MainConfig;
using EducationalCenter.EF.Configuration.Models.ReviewsConfig;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EducationalCenter.EF.Data
{
	public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
	{
		public DbSet<Student> Students { get; set; }
		public DbSet<Mentor> Mentors { get; set; }
		public DbSet<Blog> Blogs { get; set; }
		public DbSet<Course> Courses { get; set; }
		public DbSet<BlogReview> BlogReviews { get; set; }
		public DbSet<CourseReview> CourseReviews { get; set; }
		public DbSet<MentorReview> MentorReviews { get; set; }
		public DbSet<MentorsCourses> MentorsCourses { get; set; }
		public DbSet<StudentsCourses> StudentsCourses { get; set; }

		protected override void OnModelCreating(ModelBuilder builder)
		{
			base.OnModelCreating(builder);
			builder.ApplyConfiguration(new BlogConfig());
			builder.ApplyConfiguration(new CourseConfig());
			builder.ApplyConfiguration(new MentorConfig());
			builder.ApplyConfiguration(new StudentConfig());
			builder.ApplyConfiguration(new BlogReviewsConfig());
			builder.ApplyConfiguration(new MentorReviewsConfig());
			builder.ApplyConfiguration(new CourseReviewsConfig());
			builder.ApplyConfiguration(new MentorCoursesConfig());
			builder.ApplyConfiguration(new StudentCoursesConfig());
			builder.ApplyConfiguration(new ApplicationUserConfig());

		}

	}
}
