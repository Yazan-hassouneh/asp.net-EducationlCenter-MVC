﻿using EducationalCenter.Core.Models.ReviewsModels;
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
	internal class CourseReviewsConfig : BaseBlogReviewConfig<CourseReview>
	{
		public override void Configure(EntityTypeBuilder<CourseReview> builder)
		{
			base.Configure(builder);
			builder.HasOne(x => x.Course)
					.WithMany(x => x.Reviews)
					.HasForeignKey(x => x.CourseId)
					.OnDelete(DeleteBehavior.Cascade);

			builder.HasOne(x => x.User)
					.WithMany()
					.HasForeignKey(x => x.UserId)
					.OnDelete(DeleteBehavior.NoAction);
		}
	}
}
