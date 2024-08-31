using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dto
{
    public class UserLoginRequestDto
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
