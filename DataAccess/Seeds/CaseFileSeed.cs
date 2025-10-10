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
    public class CaseFileSeed : IEntityTypeConfiguration<CaseFile>
	{
		public void Configure(EntityTypeBuilder<CaseFile> builder)
		{
			//builder.HasData(new CaseFile
			//{
			//	ID = 1,
			//	CaseTypeID = 1,
			//	ApplicationTypeID = 1,
			//	CityID = 1,
			//	DistrictID = 1,
			//	Name = "Deneme",
			//	Surname = "Dosya",
			//	IdentityNumber = "11111111111",
			//	PhoneNumber = "5555555555",
			//	DateOfBirth = DateTime.Now,
			//	EntitlementRate = 10,
			//	DisabilityRate = 10,
			//	AccidentDate = DateTime.Now,
			//	OpeningDate = DateTime.Now,
			//	ClosingDate = DateTime.Now,
			//	CaseStatus = 1,
			//	CreatedDate = DateTime.Now,
			//	Status = false
			//});

		}
    }
    
    }
