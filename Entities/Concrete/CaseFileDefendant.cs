using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class CaseFileDefendant : Entity, IEntity //dosya davalilar
    {
        public int ID { get; set; }
        public int caseFileID { get; set; }

        public int defendantID { get; set; }

        public CaseFile CaseFile { get; set; }

        public Defendant Defendant { get; set; }
    }
}
