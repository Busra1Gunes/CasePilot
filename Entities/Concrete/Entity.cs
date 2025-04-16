using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Entity
    {
        public DateTime? CreatedDate { get; set; } = DateTime.Now;
        public DateTime? UpdatedDate { get; set; } = DateTime.Now;
		public DateTime? DeletedDate { get; set; } = DateTime.Now;
		public bool Status { get; set; } = false;

    }
}
