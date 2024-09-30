using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class BasvuruTur:Entity,IEntity
    {
        public int Id { get; set; }
        public int DavaTurId { get; set; }
        public string Adi { get; set; }


        public ICollection<Dosya> Dosyalar { get;set; }
       // public DavaTur DavaTur { get; set; }
    }
}
