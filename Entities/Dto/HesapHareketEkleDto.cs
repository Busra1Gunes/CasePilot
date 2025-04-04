using Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dto
{
    public class HesapHareketEkleDto
    {    
        // <summary>
        /// Parayı ödeyen kişi veya hesap ID
        /// </summary>
        public int GonderenId { get; set; }
        /// <summary>
        /// Parayı alan kişi veya hesap ID
        /// </summary>
        public int AliciId { get; set; }
        /// <summary>
        /// Eger HareketTuru=DosyaMasrafi ise DosyaId deger alır yoksa null
        /// </summary>
        public int? DosyaId { get; set; }
        /// <summary>
        /// İşlem Tutarı       
        /// </summary>
        public decimal Tutar { get; set; }
        /// <summary>
        ///  Maaş, Masraf, Fatura vb.
        /// </summary>
        public HareketTuru HareketTuru { get; set; } 
        public string Aciklama { get; set; } 
    }
}
