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
        IQueryable<T> Where(Expression<Func<T, bool>> expression);
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
		T  Get(Expression<Func<T, bool>> filter, params string[] includeProperties);
		void Add(T entity);
		void Update(T entity);
		void Delete(T entity);

	}
}
