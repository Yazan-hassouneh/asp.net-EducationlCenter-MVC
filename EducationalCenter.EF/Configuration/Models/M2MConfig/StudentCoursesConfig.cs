using EducationalCenter.Core.Models.M2MRelations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EducationalCenter.EF.Configuration.Models.M2MConfig
{
	internal class StudentCoursesConfig : IEntityTypeConfiguration<StudentsCourses>
	{
		public void Configure(EntityTypeBuilder<StudentsCourses> builder)
		{
			builder.HasKey(model => new { model.StudentId, model.CourseId });
			builder.Property(sc => sc.Mark).IsRequired();

			builder.HasOne(sc => sc.Course)
					.WithMany(c => c.AllStudents)
					.HasForeignKey(sc => sc.CourseId)
					.OnDelete(DeleteBehavior.Cascade);	
			
			builder.HasOne(sc => sc.Student)
					.WithMany(s => s.CoursesInAction)
					.HasForeignKey(sc => sc.CourseId)
					.OnDelete(DeleteBehavior.Restrict);		
			
			builder.HasOne(sc => sc.Mentor)
					.WithMany(m => m.CoursesInAction)
					.HasForeignKey(sc => sc.CourseId)
					.OnDelete(DeleteBehavior.Restrict);
		}
	}
}
