using DataAccess.Configuration;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
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
	public class CaseFileContext : DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{

         // optionsBuilder.UseSqlServer("workstation id=CasePilot.mssql.somee.com;packet size=4096;user id=busra_SQLLogin_1;pwd=rbqtkxnu4h;data source=CasePilot.mssql.somee.com;persist security info=False;initial catalog=CasePilot;TrustServerCertificate=True");
      //    optionsBuilder.UseSqlServer("Data Source=DESKOP123;Initial Catalog=CasePilot;Integrated Security=True;Trust Server Certificate=True");
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-IUMMNFO\\SQLEXPRESS01;Initial Catalog=CasePilot;Integrated Security=True;Trust Server Certificate=True");
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
    }
}
