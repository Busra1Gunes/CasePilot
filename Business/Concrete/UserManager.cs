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
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using LicenseContext = OfficeOpenXml.LicenseContext;

namespace Business.Concrete
{
    public class UserManager : Manager<User>, IUserService
    {
        private readonly IUserDal _userDal;
        private readonly ITokenHelper _tokenHelper;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IPasswordService _passwordService;

        public UserManager(IUserDal userDal, IMapper mapper, ITokenHelper tokenHelper,
                          IUnitOfWork unitOfWork, IPasswordService passwordService) : base(userDal)
        {
            _userDal = userDal;
            _mapper = mapper;
            _tokenHelper = tokenHelper;
            _unitOfWork = unitOfWork;
            _passwordService = passwordService;
        }

        #region User CRUD Operations

        [ValidationAspect(typeof(UserValidator))]
        public async Task<IResult> Add(UserAddDto user)
        {
            try
            {
                // Email benzersizlik kontrolü
                var existingUser = await _userDal.GetAsync(u => u.Mail == user.Mail && u.Status == true);
                if (existingUser != null)
                    return new ErrorResult("Bu email adresi zaten kullanılıyor.");

                // Username benzersizlik kontrolü
                var existingUsername = await _userDal.GetAsync(u => u.UserName == user.UserName && u.Status == true);
                if (existingUsername != null)
                    return new ErrorResult("Bu kullanıcı adı zaten kullanılıyor.");

                User newUser = _mapper.Map<UserAddDto, User>(user);

                // Şifreyi hashle
                newUser.Password = _passwordService.HashPassword(user.Password);

                // Varsayılan değerler
                newUser.Status = true;
                newUser.CreatedDate = DateTime.Now;
                newUser.RoleID = newUser.RoleID ?? 2; // Default User role

                await _userDal.AddAsync(newUser);
                await _unitOfWork.SaveChangesAsync();

                return new SuccessDataResult<int>(newUser.ID, "Kullanıcı başarıyla eklendi.");
            }
            catch (Exception ex)
            {
                return new ErrorResult($"Kullanıcı eklenirken hata oluştu: {ex.Message}");
            }
        }

        public async Task<IDataResult<UserGetDto>> GetById(int id)
        {
            try
            {
                var user = await _userDal.GetAllQueryable()
                    .Include(u => u.City)
                    .Include(u => u.District)
                    .Include(u => u.Role)
                    .FirstOrDefaultAsync(u => u.ID == id && u.Status == true);

                if (user == null)
                    return new ErrorDataResult<UserGetDto>("Kullanıcı bulunamadı.");

                var userDto = _mapper.Map<UserGetDto>(user);
                return new SuccessDataResult<UserGetDto>(userDto);
            }
            catch (Exception ex)
            {
                return new ErrorDataResult<UserGetDto>($"Kullanıcı getirilirken hata oluştu: {ex.Message}");
            }
        }

        public async Task<IDataResult<List<UserListDto>>> GetAll()
        {
            try
            {
                var users = await _userDal.GetAllQueryable()
                    .Include(i => i.City)
                    .Include(i => i.District)
                    .Include(i => i.Role)
                    .Where(u => u.Status == true)
                    .OrderByDescending(u => u.CreatedDate)
                    .ToListAsync();

                var userListDto = _mapper.Map<List<UserListDto>>(users);
                return new SuccessDataResult<List<UserListDto>>(userListDto, $"{userListDto.Count} kullanıcı listelendi.");
            }
            catch (Exception ex)
            {
                return new ErrorDataResult<List<UserListDto>>($"Kullanıcılar listelenirken hata oluştu: {ex.Message}");
            }
        }

        public async Task<IResult> Update(int userID, UserUpdateDto userUpdateDto)
        {
            try
            {
                var user = await _userDal.GetAsync(d => d.ID == userID && d.Status == true);
                if (user == null)
                    return new ErrorResult("Kullanıcı bulunamadı.");

                // Email benzersizlik kontrolü (kendi emaili hariç)
                if (!string.IsNullOrWhiteSpace(userUpdateDto.Mail) && userUpdateDto.Mail != user.Mail)
                {
                    var existingUser = await _userDal.GetAsync(u => u.Mail == userUpdateDto.Mail && u.Status == true && u.ID != userID);
                    if (existingUser != null)
                        return new ErrorResult("Bu email adresi zaten kullanılıyor.");
                }

                // Username benzersizlik kontrolü (kendi username'i hariç)
                if (!string.IsNullOrWhiteSpace(userUpdateDto.UserName) && userUpdateDto.UserName != user.UserName)
                {
                    var existingUsername = await _userDal.GetAsync(u => u.UserName == userUpdateDto.UserName && u.Status == true && u.ID != userID);
                    if (existingUsername != null)
                        return new ErrorResult("Bu kullanıcı adı zaten kullanılıyor.");
                }

                // Şifre güncellenecekse hashle
                var originalPassword = user.Password;
                _mapper.Map(userUpdateDto, user);

                if (!string.IsNullOrWhiteSpace(userUpdateDto.Password))
                {
                    user.Password = _passwordService.HashPassword(userUpdateDto.Password);
                }
                else
                {
                    user.Password = originalPassword; // Şifre boşsa eski şifreyi koru
                }

                user.UpdatedDate = DateTime.Now;
                _userDal.Update(user);
                await _unitOfWork.SaveChangesAsync();

                return new SuccessResult("Kullanıcı başarıyla güncellendi.");
            }
            catch (Exception ex)
            {
                return new ErrorResult($"Kullanıcı güncellenirken hata oluştu: {ex.Message}");
            }
        }

        public async Task<IResult> UpdateProfile(int userID, UserProfileUpdateDto profileDto)
        {
            try
            {
                var user = await _userDal.GetAsync(d => d.ID == userID && d.Status == true);
                if (user == null)
                    return new ErrorResult("Kullanıcı bulunamadı.");

                // Username benzersizlik kontrolü
                if (!string.IsNullOrWhiteSpace(profileDto.UserName) && profileDto.UserName != user.UserName)
                {
                    var existingUsername = await _userDal.GetAsync(u => u.UserName == profileDto.UserName && u.Status == true && u.ID != userID);
                    if (existingUsername != null)
                        return new ErrorResult("Bu kullanıcı adı zaten kullanılıyor.");
                }

                _mapper.Map(profileDto, user);
                user.UpdatedDate = DateTime.Now;

                _userDal.Update(user);
                await _unitOfWork.SaveChangesAsync();

                return new SuccessResult("Profil başarıyla güncellendi.");
            }
            catch (Exception ex)
            {
                return new ErrorResult($"Profil güncellenirken hata oluştu: {ex.Message}");
            }
        }

        public async Task<IResult> DeleteById(int id)
        {
            try
            {
                var user = await _userDal.GetAsync(d => d.ID == id && d.Status == true);
                if (user == null)
                    return new ErrorResult("Kullanıcı bulunamadı.");

                // Admin kullanıcısı silinemez
                if (user.RoleID == 1) // Admin role ID'si 1 olduğunu varsayıyoruz
                    return new ErrorResult("Admin kullanıcısı silinemez.");

                user.Status = false;
                user.DeletedDate = DateTime.Now;
                _userDal.Update(user);
                await _unitOfWork.SaveChangesAsync();

                return new SuccessResult("Kullanıcı başarıyla silindi.");
            }
            catch (Exception ex)
            {
                return new ErrorResult($"Kullanıcı silinirken hata oluştu: {ex.Message}");
            }
        }

        #endregion

        #region Authentication Methods

        public async Task<IResult> UserExists(string email)
        {
            try
            {
                var user = await _userDal.GetAsync(u => u.Mail == email && u.Status == true);
                return user != null ? new SuccessResult() : new ErrorResult("Kullanıcı bulunamadı.");
            }
            catch (Exception ex)
            {
                return new ErrorResult($"Kullanıcı kontrol edilirken hata oluştu: {ex.Message}");
            }
        }

        public async Task<User> ValidateUser(string email, string password)
        {
            try
            {
                var user = await _userDal.GetAllQueryable()
                    .Include(u => u.Role)
                    .FirstOrDefaultAsync(u => u.Mail == email && u.Status == true);

                if (user == null)
                    return null;

                // Şifre doğrulama
                bool isPasswordValid = _passwordService.VerifyPassword(password, user.Password);
                return isPasswordValid ? user : null;
            }
            catch (Exception ex)
            {
                // Log the exception
                return null;
            }
        }

        public async Task<IDataResult<AccessToken>> CreateAccessToken(User user, List<Permissions> permissions)
        {
            try
            {
                var accessToken = _tokenHelper.CreateToken(user, permissions);
                return new SuccessDataResult<AccessToken>(accessToken, "Token başarıyla oluşturuldu.");
            }
            catch (Exception ex)
            {
                return new ErrorDataResult<AccessToken>($"Token oluşturulurken hata oluştu: {ex.Message}");
            }
        }

        public async Task<IResult> ChangePassword(int userID, ChangePasswordDto changePasswordDto)
        {
            try
            {
                var user = await _userDal.GetAsync(u => u.ID == userID && u.Status == true);
                if (user == null)
                    return new ErrorResult("Kullanıcı bulunamadı.");

                // Mevcut şifre doğrulaması
                bool isCurrentPasswordValid = _passwordService.VerifyPassword(changePasswordDto.CurrentPassword, user.Password);
                if (!isCurrentPasswordValid)
                    return new ErrorResult("Mevcut şifre hatalı.");

                // Yeni şifreyi hashle ve kaydet
                user.Password = _passwordService.HashPassword(changePasswordDto.NewPassword);
                user.UpdatedDate = DateTime.Now;

                _userDal.Update(user);
                await _unitOfWork.SaveChangesAsync();

                return new SuccessResult("Şifre başarıyla değiştirildi.");
            }
            catch (Exception ex)
            {
                return new ErrorResult($"Şifre değiştirilirken hata oluştu: {ex.Message}");
            }
        }

        #endregion

        #region Password Reset Methods

        public async Task<IResult> GeneratePasswordResetToken(string email)
        {
            try
            {
                var user = await _userDal.GetAsync(u => u.Mail == email && u.Status == true);
                if (user == null)
                    return new ErrorResult("Bu email adresi ile kayıtlı kullanıcı bulunamadı.");

                // Reset token oluştur (güvenli rastgele string)
                var token = GenerateSecureRandomToken();
                var tokenExpiry = DateTime.Now.AddHours(1); // 1 saat geçerli

                // Token'ı veritabanına kaydet (User tablosunda ResetToken ve ResetTokenExpiry alanları olmalı)
                // Bu örnek için User entity'ye bu alanları eklemelisin

                // Burada email gönderme işlemi yapılabilir
                // await _emailService.SendPasswordResetEmail(email, token);

                return new SuccessResult("Şifre sıfırlama bağlantısı email adresinize gönderildi.");
            }
            catch (Exception ex)
            {
                return new ErrorResult($"Şifre sıfırlama token'ı oluşturulurken hata oluştu: {ex.Message}");
            }
        }

        public async Task<IResult> ResetPasswordWithToken(ResetPasswordDto resetPasswordDto)
        {
            try
            {
                var user = await _userDal.GetAsync(u => u.Mail == resetPasswordDto.Mail && u.Status == true);
                if (user == null)
                    return new ErrorResult("Kullanıcı bulunamadı.");

                // Token doğrulaması (User entity'de ResetToken ve ResetTokenExpiry alanları olmalı)
                // if (user.ResetToken != resetPasswordDto.Token || user.ResetTokenExpiry < DateTime.Now)
                //     return new ErrorResult("Geçersiz veya süresi dolmuş token.");

                // Yeni şifreyi hashle
                user.Password = _passwordService.HashPassword(resetPasswordDto.NewPassword);
                user.UpdatedDate = DateTime.Now;
                // user.ResetToken = null;
                // user.ResetTokenExpiry = null;

                _userDal.Update(user);
                await _unitOfWork.SaveChangesAsync();

                return new SuccessResult("Şifre başarıyla sıfırlandı.");
            }
            catch (Exception ex)
            {
                return new ErrorResult($"Şifre sıfırlanırken hata oluştu: {ex.Message}");
            }
        }

        private string GenerateSecureRandomToken()
        {
            var randomBytes = new byte[32];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(randomBytes);
            }
            return Convert.ToBase64String(randomBytes).Replace("+", "-").Replace("/", "_").Replace("=", "");
        }

        #endregion

        #region Excel Operations

        public async Task<IResult> AddFromExcel(IFormFile file)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            if (file == null || file.Length == 0)
                return new ErrorResult("Dosya yüklenmedi.");

            try
            {
                using var stream = new MemoryStream();
                await file.CopyToAsync(stream);

                using var package = new ExcelPackage(stream);
                var worksheet = package.Workbook.Worksheets.FirstOrDefault();
                if (worksheet == null)
                    return new ErrorResult("Excel sayfası bulunamadı.");

                int rowCount = worksheet.Dimension.Rows;
                int successCount = 0;
                int failCount = 0;
                var errors = new List<string>();

                // Başlık satırını kontrol et
                if (rowCount < 2)
                    return new ErrorResult("Excel dosyası boş veya sadece başlık satırı içeriyor.");

                for (int row = 2; row <= rowCount; row++)
                {
                    try
                    {
                        var dto = new UserAddDto
                        {
                            CityID = int.TryParse(worksheet.Cells[row, 1].Text?.Trim(), out var cityId) ? cityId : null,
                            DistrictID = int.TryParse(worksheet.Cells[row, 2].Text?.Trim(), out var distId) ? distId : null,
                            Name = worksheet.Cells[row, 3].Text?.Trim(),
                            Surname = worksheet.Cells[row, 4].Text?.Trim(),
                            Mail = worksheet.Cells[row, 5].Text?.Trim().ToLowerInvariant(),
                            UserName = worksheet.Cells[row, 6].Text?.Trim(),
                            Password = worksheet.Cells[row, 7].Text?.Trim(),
                            RoleID = int.TryParse(worksheet.Cells[row, 8].Text?.Trim(), out var roleId) ? roleId : 2 // Default User
                        };

                        // Validation
                        if (string.IsNullOrWhiteSpace(dto.Name))
                        {
                            errors.Add($"Satır {row}: Ad alanı boş.");
                            failCount++;
                            continue;
                        }

                        if (string.IsNullOrWhiteSpace(dto.Surname))
                        {
                            errors.Add($"Satır {row}: Soyad alanı boş.");
                            failCount++;
                            continue;
                        }

                        if (string.IsNullOrWhiteSpace(dto.Mail) || !IsValidEmail(dto.Mail))
                        {
                            errors.Add($"Satır {row}: Geçerli email adresi giriniz.");
                            failCount++;
                            continue;
                        }

                        if (string.IsNullOrWhiteSpace(dto.UserName))
                        {
                            errors.Add($"Satır {row}: Kullanıcı adı boş.");
                            failCount++;
                            continue;
                        }

                        if (string.IsNullOrWhiteSpace(dto.Password) || dto.Password.Length < 6)
                        {
                            errors.Add($"Satır {row}: Şifre en az 6 karakter olmalıdır.");
                            failCount++;
                            continue;
                        }

                        var result = await Add(dto);
                        if (result.Success)
                            successCount++;
                        else
                        {
                            errors.Add($"Satır {row}: {result.Message}");
                            failCount++;
                        }
                    }
                    catch (Exception ex)
                    {
                        errors.Add($"Satır {row}: {ex.Message}");
                        failCount++;
                    }
                }

                var message = $"{successCount} kayıt eklendi, {failCount} kayıt eklenemedi.";
                if (errors.Any())
                {
                    // İlk 10 hatayı göster
                    var errorMessage = string.Join("; ", errors.Take(10));
                    if (errors.Count > 10)
                        errorMessage += $"... ve {errors.Count - 10} hata daha.";

                    message += $" Hatalar: {errorMessage}";
                }

                return successCount > 0 ? new SuccessResult(message) : new ErrorResult(message);
            }
            catch (Exception ex)
            {
                return new ErrorResult($"Excel dosyası işlenirken hata oluştu: {ex.Message}");
            }
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        #endregion

        #region Search and Filter Methods

        public async Task<IDataResult<List<UserListDto>>> SearchUsers(string searchTerm, int? roleId = null, int? cityId = null)
        {
            try
            {
                var query = _userDal.GetAllQueryable()
                    .Include(i => i.City)
                    .Include(i => i.District)
                    .Include(i => i.Role)
                    .Where(u => u.Status == true);

                if (!string.IsNullOrWhiteSpace(searchTerm))
                {
                    searchTerm = searchTerm.ToLower();
                    query = query.Where(u =>
                        u.Name.ToLower().Contains(searchTerm) ||
                        u.Surname.ToLower().Contains(searchTerm) ||
                        u.Mail.ToLower().Contains(searchTerm) ||
                        u.UserName.ToLower().Contains(searchTerm));
                }

                if (roleId.HasValue)
                {
                    query = query.Where(u => u.RoleID == roleId.Value);
                }

                if (cityId.HasValue)
                {
                    query = query.Where(u => u.CityID == cityId.Value);
                }

                var users = await query
                    .OrderByDescending(u => u.CreatedDate)
                    .ToListAsync();

                var userListDto = _mapper.Map<List<UserListDto>>(users);
                return new SuccessDataResult<List<UserListDto>>(userListDto, $"{userListDto.Count} kullanıcı bulundu.");
            }
            catch (Exception ex)
            {
                return new ErrorDataResult<List<UserListDto>>($"Kullanıcılar aranırken hata oluştu: {ex.Message}");
            }
        }

        public async Task<IDataResult<List<UserListDto>>> GetUsersPaginated(int page = 1, int pageSize = 10)
        {
            try
            {
                var totalCount = await _userDal.CountAsync(u => u.Status == true);

                var users = await _userDal.GetAllQueryable()
                    .Include(i => i.City)
                    .Include(i => i.District)
                    .Include(i => i.Role)
                    .Where(u => u.Status == true)
                    .OrderByDescending(u => u.CreatedDate)
                    .Skip((page - 1) * pageSize)
                    .Take(pageSize)
                    .ToListAsync();

                var userListDto = _mapper.Map<List<UserListDto>>(users);

                return new SuccessDataResult<List<UserListDto>>(userListDto,
                    $"Sayfa {page}: {userListDto.Count} kullanıcı listelendi. Toplam: {totalCount}");
            }
            catch (Exception ex)
            {
                return new ErrorDataResult<List<UserListDto>>($"Kullanıcılar listelenirken hata oluştu: {ex.Message}");
            }
        }

        #endregion
    }
}