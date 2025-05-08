using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Core.DataAccess.EntityFramework
{
	public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
	   where TEntity : class, IEntity, new()
	   where TContext : DbContext
	{

		readonly DbSet<TEntity> _dbSet;

		public EfEntityRepositoryBase(TContext context)
			=> _dbSet = context.Set<TEntity>();





		public async Task AddAsync(TEntity entity)
			=> await _dbSet.AddAsync(entity);




		public async Task AddRangeAsync(IEnumerable<TEntity> entities)
			=> await _dbSet.AddRangeAsync(entities);




		public async Task<bool> AnyAsync(Expression<Func<TEntity, bool>> expression)
			=> await _dbSet.AnyAsync(expression);




		public async Task<List<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>>? expression = null)
			=> expression == null ? await _dbSet.AsNoTracking().ToListAsync() : await _dbSet.Where(expression).AsNoTracking().ToListAsync();




		public IQueryable<TEntity> GetAllQueryable(Expression<Func<TEntity, bool>>? expression = null)
			=> expression == null ? _dbSet.AsNoTracking() : _dbSet.Where(expression).AsNoTracking();




		public async Task<List<TEntity>> GetAllList(Expression<Func<TEntity, bool>>? expression = null)
			=> expression == null ? await _dbSet.ToListAsync() : await _dbSet.Where(expression).ToListAsync();




		public async Task<TEntity?> GetByIdAsync(int id)
			=> await _dbSet.FindAsync(id);




		public async Task<TEntity?> GetAsync(Expression<Func<TEntity, bool>> filter)
			=> await _dbSet.SingleOrDefaultAsync(filter);




		public async Task<TEntity?> GetAsNoTrackingAsync(Expression<Func<TEntity, bool>> filter)
			=> await _dbSet.AsNoTracking().SingleOrDefaultAsync(filter);




		public void Remove(TEntity entity)
			=> _dbSet.Remove(entity);




		public void RemoveRange(IEnumerable<TEntity> entities)
			=> _dbSet.RemoveRange(entities);




		public void Update(TEntity entity)
			=> _dbSet.Update(entity);




		public void UpdateRange(IEnumerable<TEntity> entities)
			=> _dbSet.UpdateRange(entities);




		public IQueryable<TEntity> Where(Expression<Func<TEntity, bool>> expression)
			=> _dbSet.Where(expression);




		public async Task<int> CountAsync(Expression<Func<TEntity, bool>>? expression = null)
			=> expression != null ? await _dbSet.CountAsync(expression) : await _dbSet.CountAsync();


	}
}
