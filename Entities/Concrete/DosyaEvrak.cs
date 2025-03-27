using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class DosyaEvrak : Entity, IEntity
    {
        public int Id { get; set; }
        public int DosyaId { get; set; }

        public int EvrakId { get; set; }
        public byte[] EvrakDosyasi { get; set; }
        public Dosya Dosya { get; set; } // Navigation property
        public EvrakTur Evrak { get; set; } // Navigation property
    }
}
