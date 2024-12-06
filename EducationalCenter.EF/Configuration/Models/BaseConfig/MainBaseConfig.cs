using EducationalCenter.Core.Models.BaseModels;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace EducationalCenter.EF.Configuration.Models.BaseConfig
{
	internal class MainBaseConfig<T> : IEntityTypeConfiguration<T> where T : MainBase
	{
		public virtual void Configure(EntityTypeBuilder<T> builder)
		{
			builder.HasKey(x => x.Id);
			builder.Property(x => x.Id).UseIdentityColumn();
			builder.Property(x => x.OnCreate).HasDefaultValueSql("GETDATE()");
			builder.Property(x => x.OnUpdate).HasDefaultValueSql("GETDATE()");
		}
	}
}

