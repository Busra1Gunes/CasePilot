using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Defendant:Entity,IEntity //davalilar
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public ICollection<CaseFileDefendant> CaseFileDefendant { get; set; } // İlişkili evraklar
    }
}
