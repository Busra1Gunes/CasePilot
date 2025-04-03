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
       
        public int GonderenId { get; set; } // Parayı ödeyen kişi veya hesap ID
        public int AliciId { get; set; } // Parayı alan kişi veya hesap ID
        public int DosyaId { get; set; } //Eger HareketTuru=DosyaMasrafi ise DosyaId deger alır yoksa null
        public decimal Tutar { get; set; } // İşlem Tutarı       
        public HareketDurumu BorcDurumu { get; set; } // Borç mu Alacak mı?
        public HareketTuru HareketTuru { get; set; } // Maaş, Masraf, Fatura vb.
        public string Aciklama { get; set; } // Açıklama
       
        public Dosya Dosya { get; set; } 
        public Kullanici Kullanici { get; set; }
        public Kullanici Kullanici2 { get; set; } 
    }
}
