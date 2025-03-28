using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Davali:Entity,IEntity
    {
        public int Id { get; set; }
        public int DavaliAdi { get; set; }

        public ICollection<DosyaDavali> DosyaDavalilar { get; set; } // İlişkili evraklar
    }
}
