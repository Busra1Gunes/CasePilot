using DataAccess.Configuration;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Net.Sockets;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
	public class CasePilotContext : DbContext
    {
        private readonly IConfiguration _configuration;
        public CasePilotContext(DbContextOptions<CasePilotContext> options, IConfiguration configuration)
        : base(options)
        {
            _configuration = configuration;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{



            if (!optionsBuilder.IsConfigured)
            {
                var connStr = _configuration.GetConnectionString("DefaultConnection");
                optionsBuilder.UseSqlServer(connStr);
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());//Bütün Configurationları tek seferde bulup uygular
            base.OnModelCreating(modelBuilder);

		}
		DbSet<City> Cities { get; set; }
		DbSet<District> Districts { get; set; }
		DbSet<CaseType> CaseTypes { get; set; }
		DbSet<ApplicationType> ApplicationTypes { get; set; }
		DbSet<User> Users { get; set; }
		DbSet<CaseFile> CaseFiles { get; set; }
		DbSet<DocumentType> DocumentTypes { get; set; }
		DbSet<CaseFileDocument> CaseFileDocuments { get; set; }
		DbSet<Defendant> Defendants { get; set; }
		DbSet<CaseFileShare> CaseFileShares { get; set; }
		DbSet<CaseFileDefendant> CaseFileDefendant { get; set; }
        DbSet<AccountTransaction> AccountTransactions { get; set; }
        DbSet<Permissions> Permissions { get; set; }
        DbSet<Role> Roles { get; set; }
        DbSet<RolePermission> RolePermissions { get; set; }
       
    }
}
