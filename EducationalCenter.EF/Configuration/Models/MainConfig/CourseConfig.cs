using EducationalCenter.Core.Const;
using EducationalCenter.Core.Models.DomainModels;
using EducationalCenter.EF.Configuration.Models.BaseConfig;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EducationalCenter.EF.Configuration.Models.MainConfig
{
	internal class CourseConfig : MainBaseConfig<Course>
	{
		public override void Configure(EntityTypeBuilder<Course> builder)
		{
			base.Configure(builder);
			builder.Property(x => x.Price).IsRequired();
			builder.Property(x => x.Title).IsRequired().HasMaxLength(ModelsSettings.MaxCourseTitleLength);
			builder.Property(x => x.Description).IsRequired().HasMaxLength(ModelsSettings.MaxCourseDescriptionLength);
		}
	}
}
