using Entities.Dto.CaseFileDto;
using Entities.Dto.HesapHareketDto;

namespace Entities.Dto.DosyaDto
{
    public class CaseFileDetailWithSummaryDto
    {
        // Temel dosya bilgileri
        public int ID { get; set; }
        public int CaseTypeID { get; set; }
        public int ApplicationTypeID { get; set; }
        public int CityID { get; set; }
        public int DistrictID { get; set; }
        public int CourtID { get; set; }

        public string Name { get; set; }
        public string Surname { get; set; }
        public string IdentityNumber { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime DateOfBirth { get; set; }
        public decimal EntitlementRate { get; set; }
        public decimal DisabilityRate { get; set; }
        public DateTime AccidentDate { get; set; }
        public DateTime OpeningDate { get; set; }
        public DateTime ClosingDate { get; set; }
        public string CaseNumber { get; set; }
        public int CaseStatus { get; set; }

        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public bool Status { get; set; }

        // İlişkili isimler (frontend için okunabilir)
        public string CityName { get; set; }
        public string DistrictName { get; set; }
        public string CourtName { get; set; }
        public string CaseTypeName { get; set; }
        public string ApplicationTypeName { get; set; }

        // Paylar
        public CaseFileShareListDto CaseFileShares { get; set; } = new CaseFileShareListDto();

        // Davalılar
        public List<CaseFileDefendantListDto> CaseFileDefendants { get; set; } = new List<CaseFileDefendantListDto>();

        // Masraflar
        public AccountTransactionListDto Transactions { get; set; } = new AccountTransactionListDto();

        // Kullanıcı bazlı özet
        public List<UserExpenseSummaryDto> TotalExpensesByUser { get; set; } = new List<UserExpenseSummaryDto>();
        public decimal TotalExpenses { get; set; }
    }


}
