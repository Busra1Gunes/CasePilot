using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Defendant:Entity //davalilar
    {
        public string Name { get; set; }

        public ICollection<CaseFileDefendant> CaseFileDefendant { get; set; } // İlişkili evraklar
    }
}
