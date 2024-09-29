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
        where TContext : DbContext, new()
    {
        public void Add(TEntity entity)
        {
            //using içindeki yazılan nesneler using işlemi bitince bellekten atılır
            using (TContext context = new())
            {
				IDbContextTransaction transaction =  context.Database.BeginTransaction(); //bu işlemi yaparak transaction
                //işlemini manuel yaptık 
				var addedEntity = context.Entry(entity); //referansı yakala
                addedEntity.State = EntityState.Added;//eklenecek bir nesne
                context.SaveChanges(); //ekle

                transaction.Commit();//bu işlemle yapılan değişikliklerin veritabanına uygulanmasını saglarız
                //eger commit işlemi yapılmazsa veritabanında değişiklik olmayacaktır

                //transaction commit edilmezse default rollback anlamına gelir 
            }
        }

        public async void Delete(TEntity entity)
        {
            using (TContext context = new())
            {
				IDbContextTransaction transaction = context.Database.BeginTransaction(); //bu işlemi yaparak transaction
																						 //işlemini manuel yaptık 
				var deletedEntity = context.Entry(entity); //referansı yakala
                deletedEntity.State = EntityState.Deleted;//silinecek bir nesne
                await transaction.CreateSavepointAsync("Geri dönüş noktası"); //Bu adımda, işlem sırasında bir geri dönüş noktası oluşturuluyor.
                                                                              //Eğer ilerleyen adımlarda bir hata olursa, bu noktaya geri dönülebilir. Böylece veritabanında yapılan işlemler geri alınabilir.

				context.SaveChanges(); //sil
                await transaction.RollbackToSavepointAsync("Geri dönüş noktası"); //Bu adımda, önceki adımda oluşturulan geri dönüş noktasına geri dönülür.
                                                                                  //Yani, yapılan silme işlemi geri alınır ve veritabanındaki duruma geri dönülür.

				transaction.CommitAsync(); //Son olarak, bu işlem (transaction) sonlandırılır ve kaydedilmesi gereken işlemler commit edilerek kesinleştirilir.
                                           //Ancak rollback işlemi yapıldığı için silme işlemi aslında gerçekleşmez.
			}
        }

		public IQueryable<TEntity> Get(Expression<Func<TEntity, bool>> filter)
        {
			using (TContext context = new())
			{
				var query = context.Set<TEntity>().AsQueryable();
				return query.Where(filter);
			}
		}

        public IQueryable<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext context = new())
            {
                // Set<TEntity>() ifadesi,TEntity tipi varlıklarla ilgili işlemleri yapabilmeniz için
                // veritabanındaki TEntity tablosuna erişmenizi sağlar.
                return filter == null
                    ? context.Set<TEntity>().AsQueryable()
                    : context.Set<TEntity>().Where(filter).AsQueryable();
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
		public void IkiIslem(TEntity entity,TEntity entity1)
		{
			using (TransactionScope scope = new TransactionScope())
			{
				using (TContext context = new())
				{

					// İlk işlem
					var updatedEntity = context.Entry(entity); //referansı yakala
					updatedEntity.State = EntityState.Modified;//güncellenecek bir nesne
					context.SaveChanges();
					// İkinci işlem
					var updatedEntity2 = context.Entry(entity1); //referansı yakala
					updatedEntity.State = EntityState.Deleted;//güncellenecek bir nesne
					context.SaveChanges();
				}
				scope.Complete(); // İşlemler başarıyla tamamlandığında commit edilir.
			}
		}

	}
}
