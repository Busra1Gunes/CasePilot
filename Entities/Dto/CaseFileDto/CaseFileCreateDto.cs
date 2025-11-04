using Entities.Dto.CaseFileDto;
using Entities.Dto.HesapHareketDto;

namespace Entities.Dto.DosyaDto
{
    public class CaseFileCreateDto
    {
        public CaseFileAddDto CaseFile { get; set; }

        public List<CaseFileShareAddDto> Shares { get; set; }

        
    }

}
