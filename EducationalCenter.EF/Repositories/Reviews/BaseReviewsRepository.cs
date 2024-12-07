using EducationalCenter.Core.Interfaces.RepositoryInterfaces.Repos.Reviews;
using EducationalCenter.EF.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EducationalCenter.EF.Repositories.Reviews
{
	internal class BaseReviewsRepository<T>(ApplicationDbContext context) : IBaseReviewRepository<T> where T : class
	{
		private readonly ApplicationDbContext _context = context;
		public async Task<IEnumerable<T>?> FindAllAsync(Expression<Func<T, bool>> matcher, string[] Includes)
		{
			IQueryable<T> query = _context.Set<T>();

			if (Includes is not null)
			{
				foreach (var Include in Includes) query.Include(Include);
			}

			return await query.Where(matcher).ToListAsync();
		}
		public async Task<T> AddAsync(T entity)
		{
			await _context.Set<T>().AddAsync(entity);
			return entity;
		}
		public T Update(T entity)
		{
			_context.Set<T>().Update(entity);
			return entity;
		}
		public void Delete(T entity)
		{
			_context.Set<T>().Remove(entity);
		}
		public async Task<int> Save()
		{
			return await _context.SaveChangesAsync();

		}
	}
}
