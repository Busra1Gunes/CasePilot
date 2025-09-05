using Core.Utilities.Results;
using Entities.Concrete;
using Entities.Dto.RoleDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IRoleService
    {
        Task<IDataResult<List<Role>>> GetAllRolesAsync();
        Task<Role> GetRoleByIdAsync(int id);
        Task<IResult> CreateRoleAsync(CreateRoleDto createRoleDto);
        Task<IResult> UpdateRoleAsync(int id, CreateRoleDto createRoleDto);
        Task<bool> DeleteRoleAsync(int id);
    }
}
