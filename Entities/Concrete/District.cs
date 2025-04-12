using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class District : IEntity
    {
        public int Id { get; set; }
        public int cityID { get; set; }
        public string Name { get; set; }
        public City City { get; set; }
        public ICollection<User> Users { get; set; }
		public ICollection<CaseFile> Dosyalar { get; set; }

	}
}
