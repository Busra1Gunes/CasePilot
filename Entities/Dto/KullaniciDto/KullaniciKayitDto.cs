using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dto.KullaniciDto
{
    public class KullaniciKayitDto
    {
        
        public int IlId { get; set; }
        public int IlceId { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string Mail { get; set; }
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }
    

    }
}
