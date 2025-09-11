using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dto.UserDto
{
    public class UserGetDto
    {
        public int ID { get; set; }
        public string CityID { get; set; }
        public string DistrictID { get; set; }
        public string RoleID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Mail { get; set; }
        public string UserName { get; set; }
    }
}
