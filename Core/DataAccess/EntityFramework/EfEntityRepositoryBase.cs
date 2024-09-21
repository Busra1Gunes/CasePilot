using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
        where TEntity : class, IEntity, new()
        where TContext : DbContext, new()
    {
        public void Add(TEntity entity)
        {
            //using içindeki yazılan nesneler using işlemi bitince bellekten atılır
            using (TContext context = new())
            {
                var addedEntity = context.Entry(entity); //referansı yakala
                addedEntity.State = EntityState.Added;//eklenecek bir nesne
                context.SaveChanges(); //ekle
            }
        }

        public void Delete(TEntity entity)
        {
            using (TContext context = new())
            {
                var deletedEntity = context.Entry(entity); //referansı yakala
                deletedEntity.State = EntityState.Deleted;//silinecek bir nesne
                context.SaveChanges(); //sil
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (TContext context = new())
            {
                return context.Set<TEntity>().SingleOrDefault(filter);
            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext context = new())
            {
                // Set<TEntity>() ifadesi,TEntity tipi varlıklarla ilgili işlemleri yapabilmeniz için
                // veritabanındaki TEntity tablosuna erişmenizi sağlar.
                return filter == null
                    ? context.Set<TEntity>().ToList()
                    : context.Set<TEntity>().Where(filter).ToList();
            }
        }

        public void Update(TEntity entity)
        {
            using (TContext context = new())
            {
                var updatedEntity = context.Entry(entity); //referansı yakala
                updatedEntity.State = EntityState.Modified;//güncellenecek bir nesne
                context.SaveChanges(); //güncelle
            }
        }

        public IQueryable<TEntity> Where(Expression<Func<TEntity, bool>> expression)
        {
            using (TContext context = new())
            {
                return context.Set<TEntity>().Where(expression);
            }
        }
    }
}
