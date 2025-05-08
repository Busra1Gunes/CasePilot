using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class City:Entity
    {
        public string Name { get; set; }
        public ICollection<District> Districts { get; set; }
        public ICollection<User> Users { get; set; }
		public ICollection<CaseFile> CaseFiles { get; set; }
	}
}
