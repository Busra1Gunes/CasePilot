using Entities.Dto.DosyaDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dto.CaseFileDto
{
    public class CaseFileListDto
    {
        public int ID { get; set; }
        public string CaseType { get; set; }
        public string ApplicationType { get; set; }
        public string City { get; set; }
        public string District { get; set; }
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
        public string CaseStatus { get; set; }           // DosyaDurum → CaseStatus
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; } 
        public DateTime? DeletedDate { get; set; } 
        public bool Status { get; set; } = false;
        public string Defendants { get; set; }
        public string Shares { get; set; }
        public string ExpenseSummary { get; set; }
		public string CourtName { get; set; }
		public string CaseNumber { get; set; }
	}
}
