using EducationalCenter.Core.Models.DomainModels;
using EducationalCenter.EF.Configuration.Models.BaseConfig;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EducationalCenter.EF.Configuration.Models.MainConfig
{
	internal class StudentConfig : BaseStudentMentorConfig<Student>
	{
		public override void Configure(EntityTypeBuilder<Student> builder)
		{
			base.Configure(builder);
		}
	}
}
