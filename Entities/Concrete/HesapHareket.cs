using Core.Entities;
using Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class HesapHareket : Entity, IEntity
    {
        public int Id { get; set; }

        public int BorcluID { get; set; }
        
        public int AlacakId { get; set; }
        
        public int? DosyaId { get; set; } //Eger HareketTuru=DosyaMasrafi ise DosyaId deger alır dosyamasrafı değilse   null
        
        public decimal Tutar { get; set; }

        
        public HareketDurumu HareketDurumu { get; set; }
        
        public HareketTuru HareketTuru { get; set; }
        
        public string Aciklama { get; set; }

        public DateTime OdemeTarihi { get; set; }

        public DateTime OdemeYapıldığıTarih { get; set; }
        
        public DateTime SonOdemeTarihi { get; set; }
        
        public bool OdemeDurumu { get; set; }
        
        public Dosya Dosya { get; set; }
        
        public Kullanici Kullanici1 { get; set; }
        
        public Kullanici Kullanici2 { get; set; }
    }
}
