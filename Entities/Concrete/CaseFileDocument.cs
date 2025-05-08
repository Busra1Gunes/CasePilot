using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class CaseFileDocument : Entity
    {
        public int CaseFileID { get; set; }
        public int DocumentTypeID { get; set; }
        public string DocumentUrl { get; set; }

        public CaseFile CaseFile { get; set; } // Tekil
        public DocumentType DocumentType { get; set; }
    }
}
