using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Role:Entity
    {
        public string Name { get; set; } // e.g. "Lawyer", "Intern"
        public string Description { get; set; }
        public ICollection<RolePermission> RolePermissions { get; set; }
        public ICollection<User> Users { get; set; }
    }
}
