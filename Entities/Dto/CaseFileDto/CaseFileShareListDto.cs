using Entities.Dto.DosyaDto;
using Entities.Dto.HesapHareketDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dto.CaseFileDto
{
    public class CaseFileShareListDto
    {
        public List<CaseFileShareDto> ShareDto { get; set; }
        public CaseFileShareTotalDto Total { get; set; }
    }
}
