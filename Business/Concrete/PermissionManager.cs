using AutoMapper;
using Business.Abstract;
using Business.Constants.Messages;
using Business.Exceptions.CaseFile;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.Dto.PermissionDto;
using Entities.Dto.RoleDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PermissionManager : IPermissionService
    {
        private readonly IPermissionDal _permissionDal;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        public PermissionManager(IPermissionDal permissionDal, IMapper mapper, IUnitOfWork unitOfWork)
        {

            _unitOfWork = unitOfWork;
            _permissionDal = permissionDal;
            _mapper = mapper;

        }
        public async Task<IResult> CreatePermissionAsync(PermissionAddDto permissionAddDto)
        {
            Permissions permissions = _mapper.Map<PermissionAddDto, Permissions>(permissionAddDto);

            if (_permissionDal.Where(k => k.Code == permissionAddDto.Code && k.Status.Equals(true)).Any())
                return new ErrorResult("");

            permissions.CreatedDate = DateTime.Now;
            permissions.Status = true;

            await _permissionDal.AddAsync(permissions);
            await _unitOfWork.SaveChangesAsync();
            return new SuccessResult(CommonMessages.EntityAdded);
        }

        public async Task<IResult> DeletePermissionAsync(int id)
        {
            Permissions permissions = _permissionDal.GetAsync(p => p.ID.Equals(id) && p.Status.Equals(true)).Result;
            if (permissions == null)
                return new ErrorResult();
            permissions.Status = false;
             _permissionDal.Update(permissions);
            await _unitOfWork.SaveChangesAsync();
            return new SuccessResult(CommonMessages.EntityDeleted);
        }

        public async Task<List<Permissions>> GetAllPermissionAsync()
        {
            List<Permissions>? permissionList = await _permissionDal.GetAllAsync(d=>d.Status.Equals(true));
            return permissionList;

        }

        public Task<Permissions> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IResult> UpdatePermissionAsync(int id, PermissionAddDto permissionAddDto)
        {
            Permissions? permissions = _permissionDal.Where(d => d.ID == id && d.Status.Equals(true)).SingleOrDefault();

            if (permissions == null)
                throw new InvalidCaseFileException();
            _mapper.Map(permissionAddDto, permissions);
            permissions.UpdatedDate = DateTime.Now;
            _permissionDal.Update(permissions);
            await _unitOfWork.SaveChangesAsync();
            return new SuccessResult(CommonMessages.EntityUpdated);
        }
    }
}
