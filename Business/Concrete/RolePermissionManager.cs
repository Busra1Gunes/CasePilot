using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dto.CaseFileDto;
using Entities.Dto.PermissionDto;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class RolePermissionManager : IRolePermissionService
    {
        private readonly IRolePermissionDal _rolePermissionDal;
        private readonly IRoleDal _roleDal;
        private readonly IPermissionDal _permissionDal;
        private readonly IUnitOfWork _unitOfWork;

        public RolePermissionManager(
            IRolePermissionDal rolePermissionDal,
            IRoleDal roleDal,
            IPermissionDal permissionDal,
            IUnitOfWork unitOfWork)
        {
            _rolePermissionDal = rolePermissionDal;
            _roleDal = roleDal;
            _permissionDal = permissionDal;
            _unitOfWork = unitOfWork;
        }

        public async Task<IResult> AddPermissionToRoleAsync(int roleId, int permissionId)
        {
            var role = await _roleDal.GetAsync(r => r.ID == roleId && r.Status);
            if (role == null)
                return new ErrorResult("Role bulunamadı");

            var permission = await _permissionDal.GetAsync(p => p.ID == permissionId && p.Status);
            if (permission == null)
                return new ErrorResult("Yetki bulunamadı");

            // Aynı eşleşme var mı kontrol et
            bool alreadyExists = _rolePermissionDal
                .Where(rp => rp.RoleID == roleId && rp.PermissionID == permissionId && rp.Status)
                .Any();

            if (alreadyExists)
                return new ErrorResult("Bu yetki zaten bu role atanmış");

            RolePermission rp = new RolePermission
            {
                RoleID = roleId,
                PermissionID = permissionId,
                CreatedDate = DateTime.Now,
                Status = true
            };

            await _rolePermissionDal.AddAsync(rp);
            await _unitOfWork.SaveChangesAsync();

            return new SuccessResult("Yetki role başarıyla eklendi");
        }

        public async Task<IResult> RemovePermissionFromRoleAsync(int roleId, int permissionId)
        {
            var rp = await _rolePermissionDal
                .GetAsync(x => x.RoleID == roleId && x.PermissionID == permissionId && x.Status);

            if (rp == null)
                return new ErrorResult("Role ait böyle bir yetki yok");

            rp.Status = false; // soft delete
            rp.UpdatedDate = DateTime.Now;

            _rolePermissionDal.Update(rp);
            await _unitOfWork.SaveChangesAsync();

            return new SuccessResult("Yetki rolden kaldırıldı");
        }

        public async Task<IDataResult<List<Permissions>>> GetPermissionsByRoleAsync(int roleId)
        {
            var permissions = await _rolePermissionDal.Where(p => p.Status.Equals(true))
                .Include(rp => rp.Permission)
                .Where(rp => rp.RoleID == roleId && rp.Status && rp.Permission.Status)
                .Select(rp => rp.Permission)
                .ToListAsync();

            return new SuccessDataResult<List<Permissions>>(permissions);
        }

        public async Task<IResult> ClearPermissionsFromRoleAsync(int roleId)
        {
            var rolePermissions = _rolePermissionDal
                .Where(rp => rp.RoleID == roleId && rp.Status)
                .ToList();

            if (!rolePermissions.Any())
                return new ErrorResult("Role ait aktif yetki bulunamadı");

            foreach (var rp in rolePermissions)
            {
                rp.Status = false;
                rp.UpdatedDate = DateTime.Now;
                _rolePermissionDal.Update(rp);
            }

            await _unitOfWork.SaveChangesAsync();
            return new SuccessResult("Rolün tüm yetkileri silindi");
        }

        public async Task<IResult> AddPermissionsToRoleAsync(RolePermissionAddDto dto)
        {
            var role = await _roleDal.GetAsync(r => r.ID == dto.RoleID && r.Status);
            if (role == null)
                return new ErrorResult("Role bulunamadı");

            if (dto.PermissionIDs == null || !dto.PermissionIDs.Any())
                return new ErrorResult("Eklenecek yetki bulunamadı");

            var validPermissions = _permissionDal
                .Where(p => dto.PermissionIDs.Contains(p.ID) && p.Status)
                .ToList();

            if (!validPermissions.Any())
                return new ErrorResult("Geçerli yetki bulunamadı");

            // Role’e zaten atanmış olanları kontrol et
            var existingPermissionIds = _rolePermissionDal
                .Where(rp => rp.RoleID == dto.RoleID && rp.Status)
                .Select(rp => rp.PermissionID)
                .ToList();

            var newPermissionIds = dto.PermissionIDs.Except(existingPermissionIds).ToList();

            if (!newPermissionIds.Any())
                return new ErrorResult("Tüm yetkiler zaten role atanmış");

            foreach (var pid in newPermissionIds)
            {
                RolePermission rp = new RolePermission
                {
                    RoleID = dto.RoleID,
                    PermissionID = pid,
                    CreatedDate = DateTime.Now,
                    Status = true
                };

                await _rolePermissionDal.AddAsync(rp);
            }

            await _unitOfWork.SaveChangesAsync();
            return new SuccessResult("Yetkiler role başarıyla eklendi");
        }
    }
}