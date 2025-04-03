using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class DosyaPay : Entity, IEntity
    {
        public int Id { get; set; }
        public int DosyaId { get; set; }
        public int KullaniciId { get; set; }
        public decimal Pay { get; set; }
        public string DosyaYetki { get; set; }
        public Dosya Dosya { get; set; } // İlişkili evraklar
        public Kullanici Kullanici { get; set; } // İlişkili evraklar
    }
}

