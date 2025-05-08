using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess
{
	public interface IEntityRepository<T> where T : class, IEntity, new()
    {
		Task AddAsync(T entity);

		Task AddRangeAsync(IEnumerable<T> entities);

		Task<bool> AnyAsync(Expression<Func<T, bool>> expression);

		Task<List<T>> GetAllAsync(Expression<Func<T, bool>>? expression = null);

		IQueryable<T> GetAllQueryable(Expression<Func<T, bool>>? expression = null);

		Task<List<T>> GetAllList(Expression<Func<T, bool>>? expression = null);

		Task<T?> GetByIdAsync(int id);

		Task<T?> GetAsync(Expression<Func<T, bool>> filter);

		Task<T?> GetAsNoTrackingAsync(Expression<Func<T, bool>> filter);

		void Remove(T entity);

		void RemoveRange(IEnumerable<T> entities);

		void Update(T entity);

		void UpdateRange(IEnumerable<T> entities);

		IQueryable<T> Where(Expression<Func<T, bool>> expression);

		Task<int> CountAsync(Expression<Func<T, bool>>? expression = null);

	}
}
