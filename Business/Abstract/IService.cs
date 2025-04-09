using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IService<TEntity> where TEntity : class
    {
        Task<IDataResult<TEntity>> GetByIdAsync(int id);

        IQueryable<TEntity> Where(Expression<Func<TEntity, bool>> expression);

        //Task<int> CountAsync(Expression<Func<TEntity, bool>> expression);       

        IQueryable<TEntity> GetAll();

        Task<bool> AnyAsync(Expression<Func<TEntity, bool>> expression);

        Task<IDataResult<TEntity>> AddAsync(TEntity entity);

        Task<IDataResult<IEnumerable<TEntity>>> AddRangeAsync(IEnumerable<TEntity> entities);

        Task<IResult> UpdateAsync(TEntity entity);

        Task<IResult> RemoveAsync(TEntity entity);

        Task<IResult> RemoveRangeAsync(IEnumerable<TEntity> entities);

        Task<IDataResult<IEnumerable<TEntity>>> UpdateRangeAsync(IEnumerable<TEntity> entities);
    }
}
