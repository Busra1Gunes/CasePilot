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
	public class BasvuruTurSeed : IEntityTypeConfiguration<BasvuruTur>
	{
		public void Configure(EntityTypeBuilder<BasvuruTur> builder)
		{
			builder.HasData(new BasvuruTur { Id = 1, DavaTurId = 1, Adi = "Araç Hasarı", Durum = false },
			new BasvuruTur { Id = 2, DavaTurId = 1, Adi = "Manevi", Durum = false },
			new BasvuruTur { Id = 3, DavaTurId = 1, Adi = "İdari Dava", Durum = false },
			new BasvuruTur { Id = 4, DavaTurId = 4, Adi = "Kamulaştırma", Durum = false });
		}
	}
}