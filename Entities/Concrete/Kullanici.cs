using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Kullanici :Entity, IEntity
    {

        public int Id { get; set; }
        public int? IlId { get; set; }
        public int? IlceId { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }
        public Il? Il { get; set; }
        public Ilce? Ilce { get; set; }

        public ICollection<DosyaPay>? DosyaPaylar { get; set; }


    }
}
