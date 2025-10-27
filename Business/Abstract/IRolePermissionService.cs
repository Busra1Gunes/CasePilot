using Core.Utilities.Results;
using Entities.Concrete;
using Entities.Dto.PermissionDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IRolePermissionService
    { /// <summary>
      /// Role’e yeni bir yetki ekler
      /// </summary>
        Task<IResult> AddPermissionToRoleAsync(int roleId, int permissionId);

        /// <summary>
        /// Role’den belirli bir yetkiyi kaldırır
        /// </summary>
        Task<IResult> RemovePermissionFromRoleAsync(int roleId, int permissionId);

        /// <summary>
        /// Belirli bir role ait tüm yetkileri getirir
        /// </summary>
        Task<IDataResult<List<Permissions>>> GetPermissionsByRoleAsync(int roleId);

        /// <summary>
        /// Role’nin tüm yetkilerini temizler (opsiyonel)
        /// </summary>
        Task<IResult> ClearPermissionsFromRoleAsync(int roleId);
        Task<IResult> AddPermissionsToRoleAsync(RolePermissionAddDto dto);
    }
}
