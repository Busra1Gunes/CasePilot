using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public abstract class Entity:IEntity
    {
		public int ID { get; set; }
		public DateTime? CreatedDate { get; set; } = DateTime.Now;
        public DateTime? UpdatedDate { get; set; } = DateTime.Now;
		public DateTime? DeletedDate { get; set; } = DateTime.Now;
		public bool Status { get; set; } = true;

    }
}
