using AutoMapper;
using Business.Abstract;
using Business.Constants.Messages;
using Business.Exceptions.CaseFile;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.Dto.DosyaDto;
using Entities.Dto.KullaniciDto.KullaniciDto;
using Entities.Dto.RoleDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class RoleManager : IRoleService
    {
        private readonly IRoleDal _roleDal;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;


        public RoleManager(IRoleDal roleDal, IMapper mapper, IUnitOfWork unitOfWork)
        {
            _roleDal = roleDal;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        public async Task<IDataResult<List<Role>>>  GetAllRolesAsync()
        { 
        
          List<Role> roleList =  _roleDal.GetAllAsync(r=>r.Status.Equals(true)).Result;
            return new SuccessDataResult<List<Role>>(roleList);
        }

        public async Task<Role> GetRoleByIdAsync(int id)
        {
            return await _roleDal.GetAsync(z => z.Status.Equals(true) && z.ID.Equals(id));
        }

        public async Task<IResult> CreateRoleAsync(CreateRoleDto createRoleDto)
        {
            Role role = _mapper.Map<CreateRoleDto, Role>(createRoleDto);

            if (_roleDal.Where(k => k.Name == createRoleDto.Name).Any())
                return new ErrorResult("");

            role.CreatedDate = DateTime.Now;
            role.Status = true;

            await _roleDal.AddAsync(role);
            await _unitOfWork.SaveChangesAsync();
            return new SuccessResult(CommonMessages.EntityAdded);
        }

        public async Task<IResult> UpdateRoleAsync(int id, CreateRoleDto createRoleDto)
        {
            Role? role = _roleDal.Where(d => d.Name == createRoleDto.Name && d.Status.Equals(true)).SingleOrDefault();

            if (role == null)
                throw new InvalidCaseFileException();
            _mapper.Map(createRoleDto, role);
            role.UpdatedDate = DateTime.Now;
            _roleDal.Update(role);
            await _unitOfWork.SaveChangesAsync();
            return new SuccessResult(CommonMessages.EntityUpdated);
        }

        public async Task<IResult> DeleteRoleAsync(int id)
        {
            Role? role = _roleDal.Where(d => d.ID == id && d.Status.Equals(true)).SingleOrDefault();

            if (role == null)
                throw new InvalidCaseFileException();
           
            role.DeletedDate = DateTime.Now;
            role.Status = false;
            _roleDal.Update(role);
            await _unitOfWork.SaveChangesAsync();
            return new SuccessResult(CommonMessages.EntityUpdated);
        }
    }
}
