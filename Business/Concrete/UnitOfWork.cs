using Business.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Transactions;

namespace Business.Concrete
{
    public class UnitOfWork : IUnitOfWork
    {
        IServiceProvider _serviceProvider;
        public UnitOfWork(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task SaveChangesAsync()
        {
			CaseFileContext context = _serviceProvider.GetRequiredService<CaseFileContext>();
            using var transaction = await context.Database.BeginTransactionAsync();

            try
            {
                // Türkiye saatini hesapla
                var turkeyTimeZone = TimeZoneInfo.FindSystemTimeZoneById("Turkey Standard Time");
                var turkeyTime = TimeZoneInfo.ConvertTime(DateTime.UtcNow, turkeyTimeZone);

                // ChangeTracker ile sadece BaseEntity'den türeyen entity’lerini yakalıyoruz.
                var entries = context.ChangeTracker.Entries<Entity>();

                foreach (var entry in entries)
                {
                    if (entry.State == EntityState.Added)
                        entry.Entity.CreatedDate = turkeyTime;
                }

                await context.SaveChangesAsync();

                await transaction.CommitAsync();
            }
            catch (Exception ex)
            {
                await transaction.RollbackAsync();

                throw new TransactionException("Transaction yönetiminde hata oluştu!", ex);
            }

        }
    }
}
