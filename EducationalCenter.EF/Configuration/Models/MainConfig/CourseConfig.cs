using EducationalCenter.Core.Models.DomainModels;
using EducationalCenter.EF.Configuration.Models.BaseConfig;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationalCenter.EF.Configuration.Models.MainConfig
{
	internal class CourseConfig : MainBaseConfig<Course>
	{
		public override void Configure(EntityTypeBuilder<Course> builder)
		{
			base.Configure(builder);
			builder.Property(x => x.Price).IsRequired();
		}
	}
}
