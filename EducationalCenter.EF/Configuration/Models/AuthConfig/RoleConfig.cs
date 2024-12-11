using EducationalCenter.Core.Const;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EducationalCenter.EF.Configuration.Models.AuthConfig
{
	internal class RoleConfig : IEntityTypeConfiguration<IdentityRole>
	{
		public void Configure(EntityTypeBuilder<IdentityRole> builder)
		{
			builder.Property(x => x.Name).IsRequired().HasMaxLength(ModelsSettings.MaxRoleNameLength);
		}
	}
}
