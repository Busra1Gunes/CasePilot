using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dto.HesapHareketDto
{
    public class HesapHareketListDto
    {
        public List<HesapHareketDto> Hareketler { get; set; }
        public HesapBakiyeDto Bakiye { get; set; }
    }
}
