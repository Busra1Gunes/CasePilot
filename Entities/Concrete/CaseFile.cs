using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
	public class CaseFile :Entity //Dosya
	{

        public int ApplicationTypeID { get; set; }
        public int CaseTypeID { get; set; }
        public int CityID { get; set; }
        public int DistrictID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string IdentityNumber { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime DateOfBirth { get; set; }
        public decimal EntitlementRate { get; set; } //haklılık oranı
        public decimal DisabilityRate { get; set; } //sakatlık oranı
        public DateTime AccidentDate { get; set; } //kaza tarihi
        public DateTime OpeningDate { get; set; }     // AcilisTarihi → OpeningDate
        public DateTime ClosingDate { get; set; }     // KapanisTarihi → ClosingDate
        public int CaseStatus { get; set; } = 1;       // DosyaDurum → CaseStatus
        public City City { get; set; }
		public District District { get; set; }

        public CaseType CaseType { get; set; }
		public ApplicationType ApplicationType { get; set; }
        public ICollection<CaseFileDocument> CaseFileDocuments { get; set; } // İlişkili evraklar
        public ICollection<CaseFileDefendant> CaseFileDefendant { get; set; } // İlişkili evraklar
        public ICollection<CaseFileShare> CaseFileShares { get; set; } // İlişkili evraklar
    }
}
