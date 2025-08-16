using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class RolePermission : Entity
    {
        public int RoleID { get; set; }
        public Role Role { get; set; }

        public int PermissionID { get; set; }
        public Permissions Permission { get; set; }
    }
}
