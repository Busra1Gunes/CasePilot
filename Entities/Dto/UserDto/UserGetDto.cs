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
        public string Name { get; set; }
        public string Surname { get; set; }
        public string FullName => $"{Name} {Surname}";
        public string Mail { get; set; }
        public string UserName { get; set; }
        public int? CityID { get; set; }
        public string? CityName { get; set; }
        public int? DistrictID { get; set; }
        public string? DistrictName { get; set; }
        public int? RoleID { get; set; }
        public string? RoleName { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool Status { get; set; }
    }
}
