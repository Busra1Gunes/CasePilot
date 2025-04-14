using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dto.DosyaDto
{
    public class CaseFileShareDto
    {
        public int ID { get; set; }
        public string ShareUserName { get; set; }  //Pay Sahibi
        public decimal ShareRate { get; set; }
        public string FilePermission { get; set; }
    }
}
