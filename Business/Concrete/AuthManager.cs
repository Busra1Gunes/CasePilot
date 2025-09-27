using AutoMapper;
using Business.Abstract;
using Business.Utilities.Security;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dto.KullaniciDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Serilog;

using Log = Serilog.Log;
using Microsoft.EntityFrameworkCore;
using Business.DependencyResolvers.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Entities.Dto.UserDto;

namespace Business.Concrete
{

    public class AuthManager : IAuthService
    {
        private readonly IUserDal _userDal;
        private readonly ITokenHelper _tokenHelper;
        private readonly IPasswordService _passwordService;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;

        public AuthManager(IUserDal userDal, ITokenHelper tokenHelper, IPasswordService passwordService,
                          IMapper mapper, IUnitOfWork unitOfWork)
        {
            _userDal = userDal;
            _tokenHelper = tokenHelper;
            _passwordService = passwordService;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        [ValidationAspect(typeof(UserRegisterValidator))]
        public async Task<IResult> Register(UserRegisterDto userRegisterDto)
        {
            try
            {
                // Email benzersizlik kontrolü
                var existingUserByEmail = await _userDal.GetAsync(u => u.Mail == userRegisterDto.Mail && u.Status == true);
                if (existingUserByEmail != null)
                    return new ErrorResult("Bu email adresi zaten kullanılıyor.");

                // Username benzersizlik kontrolü
                var existingUserByUsername = await _userDal.GetAsync(u => u.UserName == userRegisterDto.UserName && u.Status == true);
                if (existingUserByUsername != null)
                    return new ErrorResult("Bu kullanıcı adı zaten kullanılıyor.");

                // User entity'ye map et
                var userToAdd = _mapper.Map<User>(userRegisterDto);
                userToAdd.Password = _passwordService.HashPassword(userRegisterDto.Password);
                userToAdd.Status = true;
                userToAdd.CreatedDate = DateTime.Now;
                userToAdd.RoleID = 2; // Default User role
                userToAdd.EmailConfirmed = false; // Email doğrulaması gerekiyor

                await _userDal.AddAsync(userToAdd);
                await _unitOfWork.SaveChangesAsync();

                return new SuccessResult("Kayıt başarılı. Email doğrulama linkini kontrol ediniz.");
            }
            catch (Exception ex)
            {
                return new ErrorResult($"Kayıt sırasında hata oluştu: {ex.Message}");
            }
        }

        public async Task<IDataResult<AccessToken>> Login(UserLoginDto userLoginDto)
        {
            const int maxFailedAttempts = 5;
            const int lockoutMinutes = 30;

            try
            {
                var user = await _userDal.GetAllQueryable()
                    .Include(u => u.Role)
                    .FirstOrDefaultAsync(u => u.Mail == userLoginDto.Mail && u.Status == true);

                if (user == null)
                    return new ErrorDataResult<AccessToken>("Email veya şifre hatalı.");

                // Hesap kilidi kontrolü
                if (user.IsLocked && user.LockedUntil.HasValue && user.LockedUntil > DateTime.Now)
                {
                    var remainingTime = user.LockedUntil.Value - DateTime.Now;
                    return new ErrorDataResult<AccessToken>($"Hesabınız kilitli. Kalan süre: {remainingTime.Minutes} dakika.");
                }

                // Hesap kilidi süresi dolmuşsa kilidi kaldır
                if (user.IsLocked && user.LockedUntil.HasValue && user.LockedUntil <= DateTime.Now)
                {
                    user.IsLocked = false;
                    user.LockedUntil = null;
                    user.FailedLoginAttempts = 0;
                 //   _userDal.Update(user);
                    await _unitOfWork.SaveChangesAsync();
                }

                // Şifre doğrulama
                bool isPasswordValid = _passwordService.VerifyPassword(userLoginDto.Password, user.Password);

                if (!isPasswordValid)
                {
                    // Başarısız giriş denemesi sayısını artır
                    user.FailedLoginAttempts++;

                    if (user.FailedLoginAttempts >= maxFailedAttempts)
                    {
                        user.IsLocked = true;
                        user.LockedUntil = DateTime.Now.AddMinutes(lockoutMinutes);
                    }

                    _userDal.Update(user);
                    await _unitOfWork.SaveChangesAsync();

                    return new ErrorDataResult<AccessToken>("Email veya şifre hatalı.");
                }

                // Başarılı giriş
                user.LastLoginDate = DateTime.Now;
                user.FailedLoginAttempts = 0;
                if (user.IsLocked)
                {
                    user.IsLocked = false;
                    user.LockedUntil = null;
                }

           //     _userDal.Update(user);
                await _unitOfWork.SaveChangesAsync();

                // Kullanıcının yetkilerini al
                var permissions = await GetUserPermissions(user.ID);

                // Token oluştur
                var accessToken = _tokenHelper.CreateToken(user, permissions);

                return new SuccessDataResult<AccessToken>(accessToken, "Giriş başarılı.");
            }
            catch (Exception ex)
            {
                return new ErrorDataResult<AccessToken>($"Giriş sırasında hata oluştu: {ex.Message}");
            }
        }

        public async Task<IResult> ForgotPassword(ForgotPasswordDto forgotPasswordDto)
        {
            try
            {
                var user = await _userDal.GetAsync(u => u.Mail == forgotPasswordDto.Mail && u.Status == true);
                if (user == null)
                {
                    // Güvenlik için her zaman başarılı mesaj döndür
                    return new SuccessResult("Şifre sıfırlama bağlantısı email adresinize gönderildi.");
                }

                // Reset token oluştur
                var resetToken = GenerateSecureRandomToken();
                var tokenExpiry = DateTime.Now.AddHours(1); // 1 saat geçerli

                user.ResetToken = resetToken;
                user.ResetTokenExpiry = tokenExpiry;

                _userDal.Update(user);
                await _unitOfWork.SaveChangesAsync();

                // TODO: Email gönderme servisi entegrasyonu
                // await _emailService.SendPasswordResetEmail(user.Mail, resetToken);

                return new SuccessResult("Şifre sıfırlama bağlantısı email adresinize gönderildi.");
            }
            catch (Exception ex)
            {
                return new ErrorResult($"Şifre sıfırlama işlemi sırasında hata oluştu: {ex.Message}");
            }
        }

        [ValidationAspect(typeof(ResetPasswordValidator))]
        public async Task<IResult> ResetPassword(ResetPasswordDto resetPasswordDto)
        {
            try
            {
                var user = await _userDal.GetAsync(u => u.Mail == resetPasswordDto.Mail && u.Status == true);
                if (user == null)
                    return new ErrorResult("Kullanıcı bulunamadı.");

                // Token doğrulaması
                if (string.IsNullOrWhiteSpace(user.ResetToken) ||
                    user.ResetToken != resetPasswordDto.Token ||
                    !user.ResetTokenExpiry.HasValue ||
                    user.ResetTokenExpiry < DateTime.Now)
                {
                    return new ErrorResult("Geçersiz veya süresi dolmuş reset token.");
                }

                // Yeni şifreyi hashle
                user.Password = _passwordService.HashPassword(resetPasswordDto.NewPassword);
                user.UpdatedDate = DateTime.Now;
                user.ResetToken = null;
                user.ResetTokenExpiry = null;

                // Hesap kilidi varsa kaldır
                user.IsLocked = false;
                user.LockedUntil = null;
                user.FailedLoginAttempts = 0;

                _userDal.Update(user);
                await _unitOfWork.SaveChangesAsync();

                return new SuccessResult("Şifre başarıyla sıfırlandı.");
            }
            catch (Exception ex)
            {
                return new ErrorResult($"Şifre sıfırlama sırasında hata oluştu: {ex.Message}");
            }
        }

        public async Task<IResult> ConfirmEmail(string email, string token)
        {
            try
            {
                var user = await _userDal.GetAsync(u => u.Mail == email && u.Status == true);
                if (user == null)
                    return new ErrorResult("Kullanıcı bulunamadı.");

                if (user.EmailConfirmed)
                    return new SuccessResult("Email adresi zaten doğrulanmış.");

                if (user.EmailConfirmationToken != token)
                    return new ErrorResult("Geçersiz doğrulama token'ı.");

                user.EmailConfirmed = true;
                user.EmailConfirmationToken = null;
                user.UpdatedDate = DateTime.Now;

                _userDal.Update(user);
                await _unitOfWork.SaveChangesAsync();

                return new SuccessResult("Email adresi başarıyla doğrulandı.");
            }
            catch (Exception ex)
            {
                return new ErrorResult($"Email doğrulama sırasında hata oluştu: {ex.Message}");
            }
        }

        public async Task<IResult> ResendEmailConfirmation(string email)
        {
            try
            {
                var user = await _userDal.GetAsync(u => u.Mail == email && u.Status == true);
                if (user == null)
                {
                    // Güvenlik için her zaman başarılı mesaj döndür
                    return new SuccessResult("Doğrulama emaili gönderildi.");
                }

                if (user.EmailConfirmed)
                    return new ErrorResult("Email adresi zaten doğrulanmış.");

                // Yeni doğrulama token'ı oluştur
                var confirmationToken = GenerateSecureRandomToken();
                user.EmailConfirmationToken = confirmationToken;

                _userDal.Update(user);
                await _unitOfWork.SaveChangesAsync();

                // TODO: Email gönderme servisi entegrasyonu
                // await _emailService.SendEmailConfirmation(user.Mail, confirmationToken);

                return new SuccessResult("Doğrulama emaili gönderildi.");
            }
            catch (Exception ex)
            {
                return new ErrorResult($"Email gönderme sırasında hata oluştu: {ex.Message}");
            }
        }

        public async Task<IResult> Logout(int userId)
        {
            try
            {
                // TODO: Token blacklist'e ekle veya cache'den sil
                // Bu işlem JWT'nin stateless yapısı nedeniyle farklı stratejiler gerektirir

                return new SuccessResult("Çıkış başarılı.");
            }
            catch (Exception ex)
            {
                return new ErrorResult($"Çıkış sırasında hata oluştu: {ex.Message}");
            }
        }

        public async Task<IDataResult<User>> GetUserByEmail(string email)
        {
            try
            {
                var user = await _userDal.GetAllQueryable()
                    .Include(u => u.Role)
                    .Include(u => u.City)
                    .Include(u => u.District)
                    .FirstOrDefaultAsync(u => u.Mail == email && u.Status == true);

                if (user == null)
                    return new ErrorDataResult<User>("Kullanıcı bulunamadı.");

                return new SuccessDataResult<User>(user);
            }
            catch (Exception ex)
            {
                return new ErrorDataResult<User>($"Kullanıcı getirilirken hata oluştu: {ex.Message}");
            }
        }

        private async Task<List<Permissions>> GetUserPermissions(int userId)
        {
            // Bu method'u kendi iş logiğinize göre implement edin
            // Role tablosundan veya ayrı bir Permission tablosundan yetkileri çekin

            var permissions = new List<Permissions>();

            try
            {
                var user = await _userDal.GetAllQueryable()
                    .Include(u => u.Role)
                    .FirstOrDefaultAsync(u => u.ID == userId && u.Status == true);

                if (user?.Role != null)
                {
                    // Örnek: Role'e göre sabit yetkiler
                    if (user.Role.Name == "Admin")
                    {
                        permissions.Add(new Permissions { Name = "user.create" });
                        permissions.Add(new Permissions { Name = "user.read" });
                        permissions.Add(new Permissions { Name = "user.update" });
                        permissions.Add(new Permissions { Name = "user.delete" });
                        permissions.Add(new Permissions { Name = "admin.panel" });
                    }
                    else if (user.Role.Name == "User")
                    {
                        permissions.Add(new Permissions { Name = "user.read" });
                        permissions.Add(new Permissions { Name = "profile.update" });
                    }
                }
            }
            catch (Exception ex)
            {
                // Log the exception
                Console.WriteLine($"Permission yüklenirken hata: {ex.Message}");
            }

            return permissions;
        }

        private string GenerateSecureRandomToken()
        {
            var randomBytes = new byte[32];
            using (var rng = System.Security.Cryptography.RandomNumberGenerator.Create())
            {
                rng.GetBytes(randomBytes);
            }
            return Convert.ToBase64String(randomBytes)
                .Replace("+", "-")
                .Replace("/", "_")
                .Replace("=", "");
        }
    }
}

