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
	public class  ApplicationTypeSeed : IEntityTypeConfiguration<ApplicationType>
	{
		public void Configure(EntityTypeBuilder<ApplicationType> builder)
		{
			builder.HasData(new ApplicationType { ID = 1, CaseTypeID = 1, Name = "Araç Hasarı", Durum = false },
			new ApplicationType { ID = 2, CaseTypeID = 1, Name = "Manevi", Durum = false },
			new ApplicationType { ID = 3, CaseTypeID = 1, Name = "İdari Dava", Durum = false },
			new ApplicationType { ID = 4, CaseTypeID = 4, Name = "Kamulaştırma", Durum = false });
		}
	}
}