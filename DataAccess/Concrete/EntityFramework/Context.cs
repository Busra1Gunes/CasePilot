using DataAccess.Configuration;
using Entities.Concrete;
using Entities.Seeds;
using Microsoft.EntityFrameworkCore;
using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
	public class Context:DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
            //optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-IUMMNFO\SQLEXPRESS;Initial Catalog=StockWise;Integrated Security=True;Trust Server Certificate=True");
            //optionsBuilder.UseSqlServer("Data Source=DESKTOP-IUMMNFO\\SQLEXPRESS;Initial Catalog=StockWise;Integrated Security=True;Trust Server Certificate=True");
            //	optionsBuilder.UseSqlServer("Data Source=DESKTOP-IUMMNFO\\SQLEXPRESS01;Initial Catalog=StockWise;Integrated Security=True;Trust Server Certificate=True");
          optionsBuilder.UseSqlServer("Data Source=DESKTOP-IUMMNFO\\SQLEXPRESS01;Initial Catalog=HukukAsistani;Integrated Security=True;Trust Server Certificate=True");
          //  optionsBuilder.UseSqlServer("Data Source=AYZASOFT-0000;Initial Catalog=HukukAsistani;Integrated Security=True;Trust Server Certificate=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
		    modelBuilder.ApplyConfiguration(new DosyaConfiguration());
			modelBuilder.ApplyConfiguration(new DosyaSeed());
			modelBuilder.ApplyConfiguration(new IlSeed());
            modelBuilder.ApplyConfiguration(new IlceSeed());
            modelBuilder.ApplyConfiguration(new DavaTurSeed());
            modelBuilder.ApplyConfiguration(new BasvuruTurSeed());
            modelBuilder.ApplyConfiguration(new KullaniciSeed());
            
            base.OnModelCreating(modelBuilder);
        }
        DbSet<Il> Iller { get; set; }
		DbSet<Ilce> Ilceler { get; set; }
		DbSet<DavaTur> DavaTurleri { get; set; }
		DbSet<BasvuruTur> BasvuruTurleri { get; set; }
		DbSet<Kullanici> Kullanicilar { get; set; }
		DbSet<Dosya> Dosyalar { get; set; }


	}
}
