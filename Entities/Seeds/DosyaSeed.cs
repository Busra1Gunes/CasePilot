using Entities.Concrete;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Seeds
{
	public class DosyaSeed : IEntityTypeConfiguration<Dosya>
	{
		public void Configure(EntityTypeBuilder<Dosya> builder)
		{
			builder.HasData(new Dosya
			{
				Id = 1,
				davaturId = 1,
				basvuruturId = 1,
				ilId = 1,
				ilceId = 1,
				Adi = "Deneme",
				Soyadi = "Dosya",
				Tc = "11111111111",
				Telefon = "5555555555",
				DogumTarihi = DateTime.Now,
				HaklilikOrani = 10,
				SakatlikOrani = 10,
				KazaTarihi = DateTime.Now,
				AcilisTarihi = DateTime.Now,
				KapanisTarihi = DateTime.Now,
				DosyaDurum = 1,
				EklenmeTarihi = DateTime.Now,
				Durum = false
			});
		
		}
	}
}
