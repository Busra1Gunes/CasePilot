using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Entities.Dto.DosyaDto
{
    public class DosyaEvrakEkleDto
    {
        public int DosyaId { get; set; }

        public int EvrakId { get; set; }
        public IFormFile? EvrakUrl { get; set; }
    }
}
