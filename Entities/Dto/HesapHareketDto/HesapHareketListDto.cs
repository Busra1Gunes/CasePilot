using Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dto.HesapHareketDto
{
    public class HesapHareketListDto
    {
        public int Id { get; set; }

        public string Gonderen { get; set; }

        public string Alici { get; set; }

        public string? Dosya { get; set; }

        public decimal Tutar { get; set; }

        public HareketTuru HareketTuru { get; set; }
        public string Aciklama { get; set; }
        public DateTime OdemeTarihi { get; set; }

        public DateTime OdemeYapıldığıTarih { get; set; }
        public DateTime SonOdemeTarihi { get; set; }
        public bool OdemeDurumu { get; set; }//Odendi 1 Odenmedi 0
    }
}
