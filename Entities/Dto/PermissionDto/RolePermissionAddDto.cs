using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dto.PermissionDto
{
    public class RolePermissionAddDto
    {
        public int RoleID { get; set; }
        public List<int> PermissionIDs { get; set; }
    }
}
