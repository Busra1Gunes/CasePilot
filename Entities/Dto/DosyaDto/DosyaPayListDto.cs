using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dto.DosyaDto
{
    public class DosyaPayListDto
    {
        public int Id { get; set; }
        public string PaySahibi { get; set; }
        public decimal Pay { get; set; }
        public string DosyaYetki { get; set; }
    }
}
