using Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dto.HesapHareketDto
{
    public class HesapHareketDto
    {
        public int Id { get; set; }

        public string Borclu { get; set; }

        public string Alacak { get; set; }

        public string Dosya { get; set; }

        public decimal Tutar { get; set; }


        public string HareketDurumu { get; set; }

        public string HareketTuru { get; set; }

        public string Aciklama { get; set; }

        public DateTime OdemeTarihi { get; set; }

        public DateTime OdemeYapıldığıTarih { get; set; }

        public DateTime SonOdemeTarihi { get; set; }

        public string OdemeDurumu { get; set; }


    }
}
