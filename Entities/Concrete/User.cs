using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class User :Entity, IEntity
    {

        public int ID { get; set; }
        public int? cityID { get; set; }
        public int? districtID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Mail { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public City? City { get; set; }
        public District? District { get; set; }

        public ICollection<CaseFileShare>? CaseFileShares { get; set; }

        public ICollection<AccountTransaction> HesapHareket1 { get; set; } = new List<AccountTransaction>();
        public ICollection<AccountTransaction> HesapHareket2 { get; set; } = new List<AccountTransaction>();



    }
}
