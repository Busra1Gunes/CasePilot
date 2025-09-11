using AutoMapper;
using Business.Abstract;
using Business.Constants.Messages;
using Business.DependencyResolvers.ValidationRules.FluentValidation;
using Business.Exceptions.CaseFile;
using Business.Utilities.Security;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Messages;
using Core.Utilities.Results;
using Core.Utilities.Security;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.Dto.CaseFileDto;
using Entities.Dto.DosyaDto;
using Entities.Dto.KullaniciDto;
using Entities.Dto.KullaniciDto.KullaniciDto;
using Entities.Dto.UserDto;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using LicenseContext = OfficeOpenXml.LicenseContext;

namespace Business.Concrete
{
    public class UserManager : Manager<User>, IUserService
    {

        private IUserDal _userDal;
        private ITokenHelper _tokenHelper;
        private IMapper _mapper;
        private IUnitOfWork _unitOfWork;

        public UserManager(IUserDal userDal, IMapper mapper, ITokenHelper tokenHelper, IUnitOfWork unitOfWork) : base(userDal)
        {

            _userDal = userDal;
            _mapper = mapper;
            _tokenHelper = tokenHelper;
            _unitOfWork = unitOfWork;
        }

        [ValidationAspect(typeof(UserValidator))]
        public async Task<IResult> Add(UserAddDto user)
        {
            User list = _mapper.Map<UserAddDto, User>(user);
            list.Status = true;
            list.CreatedDate = DateTime.Now;
            _userDal.AddAsync(list);
            _unitOfWork.SaveChangesAsync();
            return new SuccessDataResult<int>(list.ID, CommonMessages.EntityAdded);
        }
        public async Task<object> GetById(int id)
        {
            var user = _userDal.Where(u => u.ID.Equals(id) && u.Status.Equals(true)).First();

            return (_mapper.Map<UserGetDto>(user));
        }
        public async Task<object> GetAll()
        {
            var list = _userDal.GetAllQueryable()
                .Include(i => i.City)
                .Include(i => i.District)
                .Include(i => i.Role).Where(u=>u.Status.Equals(true));
            return new SuccessDataResult<List<UserListDto>>(_mapper.Map<List<UserListDto>>(list));
        }


        public async Task<IResult> DeleteById(int id)
        {
            User? users = _userDal.Where(d => d.ID == id && d.Status.Equals(true)).SingleOrDefault();
            if (users == null)
                throw new InvalidDataException();

            users.Status = false;
            users.DeletedDate = DateTime.Now;
            _userDal.Update(users);
            await _unitOfWork.SaveChangesAsync();

            return new SuccessResult(CommonMessages.EntityDeleted);
        }

        public async Task<IResult> UserExists(string email)
        {
            throw new NotImplementedException();
        }

        public async Task<IDataResult<AccessToken>> CreateAccessToken(User user, List<Permissions> permissions)
        {


            var accessToken = _tokenHelper.CreateToken(user, permissions);

            return new SuccessDataResult<AccessToken>(accessToken);
        }


        public async Task<IResult> AddFromExcel(IFormFile file)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            if (file == null || file.Length == 0)
                return new ErrorResult("Dosya yüklenmedi.");

            using var stream = new MemoryStream();
            await file.CopyToAsync(stream);

            using var package = new ExcelPackage(stream);
            var worksheet = package.Workbook.Worksheets.FirstOrDefault();
            if (worksheet == null)
                return new ErrorResult("Excel sayfası bulunamadı.");

            int rowCount = worksheet.Dimension.Rows;
            int successCount = 0;
            int failCount = 0;

            for (int row = 2; row <= rowCount; row++)
            {
                var dto = new UserAddDto
                {
                    CityID = int.TryParse(worksheet.Cells[row, 1].Text, out var cityId) ? cityId : null,
                    DistrictID = int.TryParse(worksheet.Cells[row, 2].Text, out var distId) ? distId : null,
                    Name = worksheet.Cells[row, 3].Text,
                    Surname = worksheet.Cells[row, 4].Text,
                    Mail = worksheet.Cells[row, 5].Text,
                    UserName = worksheet.Cells[row, 6].Text,
                    Password = worksheet.Cells[row, 7].Text
                };

                var result = await Add(dto);
                if (result.Success)
                    successCount++;
                else
                    failCount++;
            }

            return new SuccessResult($"{successCount} kayıt eklendi, {failCount} kayıt eklenemedi.");
        }

        public async Task<IResult> Update(int userID, UserAddDto userAdd)
        {
            User? users = _userDal.Where(d => d.ID == userID && d.Status.Equals(true)).SingleOrDefault();
            if (users == null)
                throw new InvalidDataException();

            _mapper.Map(userAdd, users);
            users.UpdatedDate = DateTime.Now;
            _userDal.Update(users);

            await _unitOfWork.SaveChangesAsync();

            return new SuccessResult(CommonMessages.EntityUpdated);
        }

    }
}
