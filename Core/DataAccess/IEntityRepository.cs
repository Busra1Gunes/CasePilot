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
		IQueryable<T> GetAll(Expression<Func<T, bool>> filter = null);
		IQueryable<T> Get(Expression<Func<T, bool>> filter);
		void Add(T entity);
		void Update(T entity);
		void Delete(T entity);
		void IkiIslem(T entity, T entity1);

	}
}
