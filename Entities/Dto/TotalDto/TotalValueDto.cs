using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dto.TotalDto
{
    public class TotalValueDto
    {
        public decimal TotalCaseFile { get; set; }
        public decimal TotalDebt { get; set; }
        public decimal TotalCredit { get; set; }
        public decimal TotalUser { get; set; }
    }
}
