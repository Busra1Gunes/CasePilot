using Business.Abstract;
using Core.DataAccess;
using Core.Entities;
using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class Manager<TEntity> : IService<TEntity> where TEntity : class, IEntity, new()
    {
        private readonly IEntityRepository<TEntity> _repository;


        public Manager(IEntityRepository<TEntity> repository)
        {
            _repository = repository;
        }

        public async Task<IDataResult<TEntity>> AddAsync(TEntity entity)
        {

            await _repository.AddAsync(entity);
            //await _unitOfWork.CommitAsync();
            return new SuccessDataResult<TEntity>(entity, typeof(TEntity).Name + " " +"");
        }

        public async Task<IDataResult<IEnumerable<TEntity>>> AddRangeAsync(IEnumerable<TEntity> entities)
        {
            await _repository.AddRangeAsync(entities);

            //await _unitOfWork.CommitAsync();
            return new SuccessDataResult<IEnumerable<TEntity>>(entities, typeof(TEntity).Name + " " + "");
        }

        public async Task<bool> AnyAsync(Expression<Func<TEntity, bool>> expression)
        {
            return await _repository.AnyAsync(expression);
        }

        public IQueryable<TEntity> GetAll()
        {
            return _repository.GetAllQueryable();
        }

        public async Task<IDataResult<TEntity>> GetByIdAsync(int id)
        {
            var result = await _repository.GetByIdAsync(id);

            //if (result == null)
            //{
            //    throw new GeneralNotFoundException($"{typeof(TEntity).Name}");
            //}

            return new SuccessDataResult<TEntity>(result, typeof(TEntity).Name + " " +"");
        }

        public async Task<IResult> RemoveAsync(TEntity entity)
        {
            _repository.Remove(entity);
            //await _unitOfWork.CommitAsync();
            return new SuccessResult(typeof(TEntity).Name + " " +"");
        }

        public async Task<IResult> RemoveRangeAsync(IEnumerable<TEntity> entities)
        {
            _repository.RemoveRange(entities);
            //await _unitOfWork.CommitAsync();
            return new SuccessResult(typeof(TEntity).Name + " " +"");
        }

        public async Task<IResult> UpdateAsync(TEntity entity)
        {
            _repository.Update(entity);
            //await _unitOfWork.CommitAsync();
            return new SuccessResult(typeof(TEntity).Name + " " +"");
        }

        public IQueryable<TEntity> Where(Expression<Func<TEntity, bool>> expression)
        {
            return _repository.Where(expression);
        }

        //public async Task<int> CountAsync(Expression<Func<TEntity, bool>> expression)
        //{
        //    return await _repository.CountAsync(expression);
        //}


        //public async Task<IDataResult<IEnumerable<TEntity>>> UpdateRangeAsync(IEnumerable<TEntity> entities)
        //{
        //    try
        //    {
        //        await _repository.UpdateRangeAsync(entities);
        //        return new SuccessDataResult<IEnumerable<TEntity>>(entities, typeof(TEntity).Name + " " + "");
        //    }
        //    catch (Exception ex)
        //    {
        //        // Hata durumunda gerekli işlemleri burada gerçekleştirebilirsiniz.
        //        return new ErrorDataResult<IEnumerable<TEntity>>(ex.Message);
        //    }
        //}
    }
}
