using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class CaseFileShare : Entity
    {
        public int CaseFileID { get; set; }
        public int UserID { get; set; }
        public decimal ShareRate { get; set; } //Pay
        public string FilePermission { get; set; }
        public CaseFile CaseFile { get; set; } // İlişkili evraklar
        public User User { get; set; } // İlişkili evraklar
    }
}

