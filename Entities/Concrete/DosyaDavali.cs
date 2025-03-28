using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class DosyaDavali : Entity, IEntity
    {
        public int Id { get; set; }
        public int DosyaId { get; set; }

        public int DavaliId { get; set; }

        public Dosya Dosya { get; set; }

        public Davali Davali { get; set; }
    }
}
