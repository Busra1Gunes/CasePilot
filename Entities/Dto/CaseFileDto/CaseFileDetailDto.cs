using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dto.DosyaDto
{
    public class CaseFileDetailDto
	{
        public int ID { get; set; }
        public string CaseType { get; set; }
		public string applicationType { get; set; }
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
        public int CaseStatus { get; set; }           // DosyaDurum → CaseStatus
        public List<CaseFileShareListDto> CaseFileShares { get; set; } = new List<CaseFileShareListDto>();
		//DosyaPays alanını null döndürmemek için new List<DosyaPayListDto>() ile başlatmak mantıklıdır
		public List<CaseFileDefendantListDto> caseFileDefendantListDtos { get; set; } = new List<CaseFileDefendantListDto>();


	}
}
