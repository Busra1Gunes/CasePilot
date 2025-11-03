using Entities.Dto.CaseFileDto;
using Entities.Dto.HesapHareketDto;

namespace Entities.Dto.DosyaDto
{
    public class CaseFileCreateDto
    {
        // Dosya bilgileri
        public CaseFileAddDto CaseFile { get; set; }

        // Pay bilgileri
        public List<CaseFileShareAddDto> Shares { get; set; }

        // Masraf bilgileri
        public List<AccountTransactionAddDto> Transactions { get; set; }

        // Masrafları paylara dağıt
        public bool DistributeExpensesToShares { get; set; }
    }

}
