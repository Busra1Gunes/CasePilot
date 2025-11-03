using Business.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.Extensions.DependencyInjection;
using System.Transactions;

namespace Business.Concrete
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IServiceProvider _serviceProvider;

        public UnitOfWork(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        // Mevcut metot - kendi transaction'ını yönetir
        public async Task SaveChangesAsync()
        {
            CasePilotContext context = _serviceProvider.GetRequiredService<CasePilotContext>();
            using var transaction = await context.Database.BeginTransactionAsync();
            try
            {
                await ApplyAuditInfo(context);
                await context.SaveChangesAsync();
                await transaction.CommitAsync();
            }
            catch (Exception ex)
            {
                await transaction.RollbackAsync();
                throw new TransactionException("Transaction yönetiminde hata oluştu!", ex);
            }
        }

        // Yeni metot - transaction olmadan sadece SaveChanges
        public async Task SaveChangesWithoutTransactionAsync()
        {
            CasePilotContext context = _serviceProvider.GetRequiredService<CasePilotContext>();
            await ApplyAuditInfo(context);
            await context.SaveChangesAsync();
        }

        // Ortak audit bilgilerini uygula
        private async Task ApplyAuditInfo(CasePilotContext context)
        {
            var turkeyTimeZone = TimeZoneInfo.FindSystemTimeZoneById("Turkey Standard Time");
            var turkeyTime = TimeZoneInfo.ConvertTime(DateTime.UtcNow, turkeyTimeZone);

            var entries = context.ChangeTracker.Entries<Entity>();
            foreach (var entry in entries)
            {
                if (entry.State == EntityState.Added)
                    entry.Entity.CreatedDate = turkeyTime;
            }
        }
    }
}
