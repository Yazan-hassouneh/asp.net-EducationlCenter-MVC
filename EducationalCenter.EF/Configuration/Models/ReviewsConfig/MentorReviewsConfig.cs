using EducationalCenter.Core.Models.ReviewsModels;
using EducationalCenter.EF.Configuration.Models.BaseConfig;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationalCenter.EF.Configuration.Models.ReviewsConfig
{
	internal class MentorReviewsConfig : BaseBlogReviewConfig<MentorReview>
	{
		public override void Configure(EntityTypeBuilder<MentorReview> builder)
		{
			base.Configure(builder);
			builder.HasOne(x => x.Mentor)
					.WithMany(x => x.Reviews)
					.HasForeignKey(x => x.MentorId)
					.OnDelete(DeleteBehavior.Cascade);

			builder.HasOne(x => x.User)
					.WithMany()
					.HasForeignKey(x => x.UserId)
					.OnDelete(DeleteBehavior.NoAction);
		}
	}
}
