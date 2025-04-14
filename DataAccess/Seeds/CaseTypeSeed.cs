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
	public class CaseTypeSeed : IEntityTypeConfiguration<CaseType>
	{
		public void Configure(EntityTypeBuilder<CaseType> builder)
		{
			builder.HasData(new CaseType { ID = 1, Name = "Trafik Kazası", Status = false },
			new CaseType { ID = 2, Name = "Arabuluculuk", Status = false },
			new CaseType { ID = 3, Name= "İdari Dava", Status = false },
			new CaseType { ID = 4, Name = "Kamulaştırma", Status = false });
		}
	}
}
