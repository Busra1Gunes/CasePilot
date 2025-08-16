using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class UserRole:Entity
    {
        public int UserID { get; set; }
        public User User { get; set; }

        public int RoleID { get; set; }
        public Role Role { get; set; }
    }
}
