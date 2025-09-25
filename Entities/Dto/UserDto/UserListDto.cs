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
        public string Name { get; set; }
        public string Surname { get; set; }
        public string FullName => $"{Name} {Surname}";
        public string Mail { get; set; }
        public string UserName { get; set; }
        public string? CityName { get; set; }
        public string? DistrictName { get; set; }
        public string? RoleName { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool Status { get; set; }
    }
}
