using EducationalCenter.Core.Models.ReviewsModels;
using EducationalCenter.EF.Configuration.Models.BaseConfig;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EducationalCenter.EF.Configuration.Models.ReviewsConfig
{
	internal class BlogReviewsConfig : BaseBlogReviewConfig<BlogReview>
	{
		public override void Configure(EntityTypeBuilder<BlogReview> builder)
		{
			base.Configure(builder);

			builder.HasOne(x => x.Blog)
				.WithMany(x => x.Reviews)
				.HasForeignKey(x => x.BlogId)
				.OnDelete(DeleteBehavior.Cascade);

			builder.HasOne(x => x.User)
				.WithMany()
				.HasForeignKey(x => x.UserId)
				.OnDelete(DeleteBehavior.NoAction);
		}
	}
}
