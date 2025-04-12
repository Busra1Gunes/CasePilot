using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dto.HesapHareketDto
{
    public class HesapBakiyeDto
    {
        public decimal ToplamBorc{ get; set; }
        public decimal ToplamAlacak { get; set; }
        public decimal BekleyenBorc { get; set; }
        public decimal BekleyenAlacak { get; set; }
        public decimal NetBakiye { get; set; }
    }
}
