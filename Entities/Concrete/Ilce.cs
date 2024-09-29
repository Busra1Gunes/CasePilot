using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Ilce:IEntity
    {
        public int Id { get; set; }
        public int IlId { get; set; }
        public string IlceAdi { get; set; }
        public Il Il { get; set; }
        public ICollection<Kullanici> Kullanicilar { get; set; }
		public ICollection<Dosya> Dosyalar { get; set; }

	}
}
