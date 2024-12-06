using EducationalCenter.Core.Models.M2MRelations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EducationalCenter.EF.Configuration.Models.M2MConfig
{
	internal class MentorCoursesConfig : IEntityTypeConfiguration<MentorsCourses>
	{
		public void Configure(EntityTypeBuilder<MentorsCourses> builder)
		{
			builder.HasKey(model => new { model.MentorId, model.CourseId });

			builder.HasOne(mc => mc.Course)
					.WithMany(m => m.Mentors)
					.HasForeignKey(mc => mc.CourseId)
					.OnDelete(DeleteBehavior.Cascade);

			builder.HasOne(mc => mc.Mentor)
					.WithMany(m => m.AllCourses)
					.HasForeignKey(sc => sc.CourseId)
					.OnDelete(DeleteBehavior.Restrict);
		}
	}
}
