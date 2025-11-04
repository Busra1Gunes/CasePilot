using Business.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System.Transactions;

namespace Business.Concrete
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly CasePilotContext _context;
        private readonly ILogger<UnitOfWork> _logger;

        public UnitOfWork(CasePilotContext context, ILogger<UnitOfWork> logger)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _logger = logger;
        }

        public async Task SaveChangesAsync()
        {
            _logger?.LogDebug("UnitOfWork: SaveChangesAsync (with explicit transaction) started.");

            // BeginTransactionAsync ile transaction alıyoruz
            await using var transaction = await _context.Database.BeginTransactionAsync();
            try
            {
                var affected = await _context.SaveChangesAsync();
                await transaction.CommitAsync();
                _logger?.LogInformation("UnitOfWork: Transaction committed. Affected rows: {count}", affected);
            }
            catch (Exception ex)
            {
                _logger?.LogError(ex, "UnitOfWork: Transaction failed, rolling back.");
                try
                {
                    await transaction.RollbackAsync();
                }
                catch (Exception rbEx)
                {
                    _logger?.LogError(rbEx, "UnitOfWork: Rollback failed.");
                }
                throw;
            }
        }

        // IMPORTANT: Do NOT dispose the DbContext here if it's provided by the DI container (scoped).
        // Let the DI container manage DbContext lifetime. Removing manual dispose avoids double-dispose issues.
        public void Dispose()
        {
            // intentionally left blank
            // _context is disposed by the DI container (the request scope). Do not call _context.Dispose() here.
        }

    }
}
