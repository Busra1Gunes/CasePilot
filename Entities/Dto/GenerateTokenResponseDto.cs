using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dto
{
    public class GenerateTokenResponseDto
    {
        public string Token { get; set; }
        public DateTime TokenExpireDate { get; set; }
    }
}
