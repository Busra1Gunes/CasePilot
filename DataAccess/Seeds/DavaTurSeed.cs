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
	public class DavaTurSeed : IEntityTypeConfiguration<DavaTur>
	{
		public void Configure(EntityTypeBuilder<DavaTur> builder)
		{
			builder.HasData(new DavaTur { Id = 1, Adi = "Trafik Kazası", Durum = false },
			new DavaTur { Id = 2, Adi = "Arabuluculuk", Durum = false },
			new DavaTur { Id = 3, Adi = "İdari Dava", Durum = false },
			new DavaTur { Id = 4, Adi = "Kamulaştırma", Durum = false });
		}
	}
}
