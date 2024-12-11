using EducationalCenter.Core.Const;
using EducationalCenter.Core.Models.BaseModels;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationalCenter.EF.Configuration.Models.BaseConfig
{
	internal class BaseBlogReviewConfig<T> : MainBaseConfig<T> where T : BaseBlogReview
	{
		public override void Configure(EntityTypeBuilder<T> builder)
		{
			base.Configure(builder);
			builder.Property(x => x.Text).HasMaxLength(ModelsSettings.MaxBlogReviewsTextLength);
		}
	}
}
