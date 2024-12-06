using EducationalCenter.Core.Const;
using EducationalCenter.Core.Models.BaseModels;
using EducationalCenter.Core.Models.DomainModels;
using EducationalCenter.EF.Configuration.Models.BaseConfig;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EducationalCenter.EF.Configuration.Models.MainConfig
{
	internal class BlogConfig : BaseBlogReviewConfig<Blog>
	{
		public override void Configure(EntityTypeBuilder<Blog> builder)
		{
			base.Configure(builder);
			builder.Property(x => x.Title).HasMaxLength(BlogReviewsSettings.MaxBlogTitleLength);

			builder.HasOne(mc => mc.User)
					.WithMany(m => m.Blogs)
					.HasForeignKey(sc => sc.UserId)
					.OnDelete(DeleteBehavior.Cascade);
		}
	}
}
