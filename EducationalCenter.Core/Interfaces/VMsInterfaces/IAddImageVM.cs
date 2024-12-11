using Microsoft.AspNetCore.Http;

namespace EducationalCenter.Core.Interfaces.VMsInterfaces
{
	public interface IAddImageVM
	{
		IFormFile? Image { get; set; }
	}
}
