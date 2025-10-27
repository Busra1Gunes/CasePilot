using Core.Utilities.Results;
using Entities.Concrete;
using Entities.Dto.PermissionDto;
using Entities.Dto.RoleDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IPermissionService
    {
        Task<IDataResult<List<Permissions>>> GetAllPermissionAsync();
        Task<IDataResult<Permissions>> GetByIdAsync(int id);
        Task<IResult> CreatePermissionAsync(PermissionAddDto permissionAddDto);
        Task<IResult> UpdatePermissionAsync(int id, PermissionAddDto permissionAddDto);
        Task<IResult> DeletePermissionAsync(int id);
    }
}
