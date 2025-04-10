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
	public class Context : DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{

             optionsBuilder.UseSqlServer("workstation id=HukukAsistani.mssql.somee.com;packet size=4096;user id=busra_SQLLogin_1;pwd=rbqtkxnu4h;data source=HukukAsistani.mssql.somee.com;persist security info=False;initial catalog=HukukAsistani;TrustServerCertificate=True");
            //optionsBuilder.UseSqlServer("Data Source=DESKOP123;Initial Catalog=HukukAsistani;Integrated Security=True;Trust Server Certificate=True");
            //optionsBuilder.UseSqlServer("Data Source=DESKTOP-IUMMNFO\\SQLEXPRESS01;Initial Catalog=HukukAsistani;Integrated Security=True;Trust Server Certificate=True");
        }
		protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());//Bütün Configurationları tek seferde bulup uygular
           // modelBuilder.ApplyConfiguration(new DosyaConfiguration()); üsteki koddan dolayi gerek kalmadı
			//modelBuilder.ApplyConfiguration(new DosyaSeed());
			//modelBuilder.ApplyConfiguration(new IlSeed());
			//modelBuilder.ApplyConfiguration(new IlceSeed());
			//modelBuilder.ApplyConfiguration(new DavaTurSeed());
			//modelBuilder.ApplyConfiguration(new BasvuruTurSeed());
			//modelBuilder.ApplyConfiguration(new KullaniciSeed());
			//modelBuilder.ApplyConfiguration(new EvrakTurSeed());
           // modelBuilder.ApplyConfiguration(new HesapHareketConfiguration());
            base.OnModelCreating(modelBuilder);
		}
		DbSet<Il> Iller { get; set; }
		DbSet<Ilce> Ilceler { get; set; }
		DbSet<DavaTur> DavaTurleri { get; set; }
		DbSet<BasvuruTur> BasvuruTurleri { get; set; }
		DbSet<Kullanici> Kullanicilar { get; set; }
		DbSet<Dosya> Dosyalar { get; set; }
		DbSet<EvrakTur> EvrakTurler { get; set; }
		DbSet<DosyaEvrak> DosyaEvraklar { get; set; }
		DbSet<Davali> Davalilar { get; set; }
		DbSet<DosyaPay> DosyaPaylar { get; set; }
		DbSet<DosyaDavali> DosyaDavalilar { get; set; }
        DbSet<HesapHareket> HesapHareketler { get; set; }
    }
}
