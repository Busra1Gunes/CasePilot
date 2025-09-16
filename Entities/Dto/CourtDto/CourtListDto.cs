using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dto.CourtDto
{
    public class CourtListDto
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string CityName { get; set; }
        public string DistrictName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string CourtType { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
