using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class CaseFileDefendant : Entity 
    {
        public int CaseFileID { get; set; }

        public int DefendantID { get; set; }

        public CaseFile CaseFile { get; set; }

        public Defendant Defendant { get; set; }
    }
}
