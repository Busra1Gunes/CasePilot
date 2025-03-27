using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class EvrakTur : Entity, IEntity
    {
        public int Id { get; set; }
        public string EvrakTurAdi { get; set; }

        public string Tur { get; set; }  //Dosya Evrakları, Kullanıcı Evrakları

        public ICollection<DosyaEvrak> DosyaEvraklar { get; set; } // İlişkili dosya evrakları
    }
}
