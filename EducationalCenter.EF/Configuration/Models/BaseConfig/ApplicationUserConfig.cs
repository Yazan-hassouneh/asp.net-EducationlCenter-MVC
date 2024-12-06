using EducationalCenter.Core.Const;
using EducationalCenter.Core.Models.BaseModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EducationalCenter.EF.Configuration.Models.BaseConfig
{
	internal class ApplicationUserConfig : IEntityTypeConfiguration<ApplicationUser>
	{
		public virtual void Configure(EntityTypeBuilder<ApplicationUser> builder)
		{
			builder.Property(x => x.UserName).HasMaxLength(AppUserSettings.MaxNameLength);
			builder.Property(x => x.About).HasMaxLength(AppUserSettings.MaxAboutLength);
			builder.Property(x => x.Age).IsRequired(false);
			builder.Property(x => x.OnCreate).HasDefaultValueSql("GETDATE()").IsRequired();
			builder.Property(x => x.OnUpdate).HasDefaultValueSql("GETDATE()").IsRequired();
			builder.Property(x => x.IsDeleted).HasDefaultValue(false).IsRequired();
		}
	}
}
