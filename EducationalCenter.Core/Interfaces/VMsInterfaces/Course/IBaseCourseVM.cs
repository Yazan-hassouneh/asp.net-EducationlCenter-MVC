using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationalCenter.Core.Interfaces.VMsInterfaces.Course
{
	public interface IBaseCourseVM
	{
		string Title { get; set; }
		float Price { get; set; }
		string Description { get; set; }
	}
}
