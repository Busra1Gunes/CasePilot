using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dto.CaseFileDto
{
    public class CaseFileShareAddDto
    {
        public int ID { get; set; }
        public int CaseFileID { get; set; }
        public int UserID { get; set; }
        public decimal ShareRate { get; set; } //Pay
        public string FilePermission { get; set; }
    }
}
