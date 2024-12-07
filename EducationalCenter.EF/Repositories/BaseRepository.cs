using EducationalCenter.Core.Interfaces.RepositoryInterfaces.Repos;
using EducationalCenter.EF.Data;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace EducationalCenter.EF.Repositories
{
	internal class BaseRepository<T>(ApplicationDbContext context) : IBaseRepository<T> where T : class
	{
		private readonly ApplicationDbContext _context = context;
		public virtual async Task<T?> GetByIdAsync(int id)
		{
			return await _context.Set<T>().FindAsync(id);
		}
		public virtual async Task<IEnumerable<T>> GetAllAsync()
		{
			return await _context.Set<T>().ToListAsync();
		}
		public async Task<T?> FindAsync(Expression<Func<T, bool>> matcher)
		{
			return await _context.Set<T>().AsNoTracking().FirstOrDefaultAsync(matcher);
		}
		public async Task<T?> FindAsync(Expression<Func<T, bool>> matcher, string[] Includes)
		{
			IQueryable<T> query = _context.Set<T>();

			if (Includes != null)
			{
				foreach (var Include in Includes) query.Include(Include);
			}

			return await query.SingleOrDefaultAsync(matcher);
		}
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
