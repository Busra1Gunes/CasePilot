using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class RoleManager:IRoleService
    {
        private readonly IRoleDal _roleDal;
      

        public RoleManager(IRoleDal roleDal)
        {
            _roleDal = roleDal;
        }

        public async Task<List<Role>> GetAllRolesAsync()
        {
            return await _roleDal.GetAllAsync();
        }

        public async Task<Role> GetRoleByIdAsync(int id)
        {
            return await _roleDal.GetByIdAsync(id);
        }

        public async Task<Role> CreateRoleAsync(string name, List<int> permissionIds)
        {
            var role = new Role { Name = name };

            role.RolePermissions = permissionIds.Select(pid => new RolePermission
            {
                PermissionID = pid
            }).ToList();

            await _roleDal.AddAsync(role);
            return role;
        }

        public async  Task<Role> UpdateRoleAsync(int id, string name, List<int> permissionIds)
        {
            var role =await  _roleDal.GetByIdAsync(id);
            if (role == null) return null;

            role.Name = name;
            role.RolePermissions.Clear();

            role.RolePermissions = permissionIds.Select(pid => new RolePermission
            {
                RoleID = id,
                PermissionID = pid
            }).ToList();

             _roleDal.Update(role);
            return role;
        }

        public async Task<bool> DeleteRoleAsync(int id)
        {
            var role = await _roleDal.GetByIdAsync(id);
            if (role == null) return false;

             _roleDal.Remove(role);
            return true;
        }
    }
}
