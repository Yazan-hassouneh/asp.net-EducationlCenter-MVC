using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EducationalCenter.Core.Interfaces.RepositoryInterfaces.Repos.Reviews
{
	public interface IBaseReviewRepository<T> where T : class
	{
		Task<IEnumerable<T>?> FindAllAsync(Expression<Func<T, bool>> matcher, string[] Includes);
		Task<T> AddAsync(T entity);
		T Update(T entity);
		void Delete(T entity);
		Task<int> Save();
	}
}
