using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class DavaTur:Entity,IEntity
    {
        public int Id { get; set; }
        public string Adi { get; set; }
    }
}
