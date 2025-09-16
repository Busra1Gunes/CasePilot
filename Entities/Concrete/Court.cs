using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
   // Court.cs - Mahkeme Entity
public class Court : Entity
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public int CityID { get; set; }
        public int DistrictID { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string CourtType { get; set; } // İş Mahkemesi, Asliye Hukuk, vb.

        // Navigation Properties
        public City City { get; set; }
        public District District { get; set; }
        public ICollection<Hearing> Hearings { get; set; }
        public ICollection<CaseFile> CaseFiles { get; set; }
    }
}
