using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Il:IEntity
    {
        public int Id { get; set; }
        public string Adi { get; set; }
        public ICollection<Ilce> Ilceler { get; set; }
        public ICollection<Kullanici> Kullanicilar { get; set; }
		public ICollection<Dosya> Dosyalar { get; set; }
	}
}
