using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IRoleService
    {
        Task<List<Role>> GetAllRolesAsync();
        Task<Role> GetRoleByIdAsync(int id);
        Task<Role> CreateRoleAsync(string name, List<int> permissionIds);
        Task<Role> UpdateRoleAsync(int id, string name, List<int> permissionIds);
        Task<bool> DeleteRoleAsync(int id);
    }
}
