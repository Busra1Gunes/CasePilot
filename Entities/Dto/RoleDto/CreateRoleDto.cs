using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dto.RoleDto
{
    public class CreateRoleDto
    {
        public string Name { get; set; }
        public List<int> PermissionIDs { get; set; }
    }
}
