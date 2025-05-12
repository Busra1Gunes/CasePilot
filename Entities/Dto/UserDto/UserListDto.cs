using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dto.KullaniciDto.KullaniciDto
{
    public class UserListDto
    {
        public int ID { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Mail { get; set; }
        public string UserName { get; set; }
    }
}
