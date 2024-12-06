using EducationalCenter.Core.Models.DomainModels;
using EducationalCenter.EF.Configuration.Models.BaseConfig;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationalCenter.EF.Configuration.Models.MainConfig
{
	internal class MentorConfig : BaseStudentMentorConfig<Mentor>
	{
		public override void Configure(EntityTypeBuilder<Mentor> builder)
		{
			base.Configure(builder);
		}
	}
}
