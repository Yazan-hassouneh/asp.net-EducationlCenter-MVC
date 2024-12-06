using EducationalCenter.Core.Models.DomainModels;
using EducationalCenter.Core.Models.M2MRelations;
using Microsoft.AspNetCore.Identity;

namespace EducationalCenter.Core.Models.BaseModels
{
	public class ApplicationUser : IdentityUser
	{
        public short? Age { get; set; }
        public string About { get; set; } = null!;
        public bool IsDeleted { get; set; } = false;
        public string? Image { get; set; }
		public DateTime OnCreate { get; set; }
		public DateTime OnUpdate { get; set; }
		public virtual List<Blog> Blogs { get; set; } = [];
		public virtual ICollection<StudentsCourses> CoursesInAction { get; set; } = [];
	}
}
