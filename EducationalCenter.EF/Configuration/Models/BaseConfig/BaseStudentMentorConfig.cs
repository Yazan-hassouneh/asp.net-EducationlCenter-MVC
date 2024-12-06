using EducationalCenter.Core.Models.BaseModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationalCenter.EF.Configuration.Models.BaseConfig
{
	internal class BaseStudentMentorConfig<T> : IEntityTypeConfiguration<T> where T : BaseStudentMentor
	{
		public virtual void Configure(EntityTypeBuilder<T> builder)
		{
			builder.HasKey(x => x.Id);
			builder.Property(x => x.Id).UseIdentityColumn();
			builder.Property(x => x.UserId).IsRequired();
			builder.HasIndex(x => x.UserId).IsUnique();

			builder.HasOne(x => x.User)
				.WithMany()
				.HasForeignKey(x => x.UserId)
				.HasPrincipalKey(x => x.Id)
				.OnDelete(DeleteBehavior.Cascade);
		}
	}
}
