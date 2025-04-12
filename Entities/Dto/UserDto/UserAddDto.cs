using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dto.KullaniciDto
{
    public class UserAddDto
    {
        
        public int cityID { get; set; }
        public int districtID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Mail { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }


    }
}
