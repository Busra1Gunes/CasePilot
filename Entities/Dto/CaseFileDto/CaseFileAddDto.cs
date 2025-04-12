using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dto.DosyaDto
{
	public class CaseFileAddDto
    {
		public int caseTypeID { get; set; }
		public int applicationTypeID { get; set; }
		public int cityID { get; set; }
		public int districtID { get; set; }
		public string Name { get; set; }
		public string Surname { get; set; }
		public string IdentityNumber { get; set; }
		public string PhoneNumber { get; set; }
		public DateTime DateOfBirth { get; set; }
		public decimal EntitlementRate { get; set; } //haklılık oranı
		public decimal DisabilityRate { get; set; } //sakatlık oranı
		public DateTime AccidentDate { get; set; } //kaza tarihi
	}
}
