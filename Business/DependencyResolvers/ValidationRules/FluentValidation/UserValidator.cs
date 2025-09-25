using Entities.Concrete;
using Entities.Dto.KullaniciDto;
using Entities.Dto.UserDto;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DependencyResolvers.ValidationRules.FluentValidation
{
    public class UserValidator : AbstractValidator<UserAddDto>
    {
        public UserValidator()
        {
            RuleFor(u => u.Name)
                .NotEmpty().WithMessage("Ad alanı zorunludur.")
                .Length(2, 50).WithMessage("Ad 2-50 karakter arasında olmalıdır.")
                .Matches(@"^[a-zA-ZçğıöşüÇĞIİÖŞÜ\s]+$").WithMessage("Ad sadece harf içermelidir.");

            RuleFor(u => u.Surname)
                .NotEmpty().WithMessage("Soyad alanı zorunludur.")
                .Length(2, 50).WithMessage("Soyad 2-50 karakter arasında olmalıdır.")
                .Matches(@"^[a-zA-ZçğıöşüÇĞIİÖŞÜ\s]+$").WithMessage("Soyad sadece harf içermelidir.");

            RuleFor(u => u.Mail)
                .NotEmpty().WithMessage("Email alanı zorunludur.")
                .EmailAddress().WithMessage("Geçerli bir email adresi giriniz.")
                .Length(5, 100).WithMessage("Email 5-100 karakter arasında olmalıdır.");

            RuleFor(u => u.UserName)
                .NotEmpty().WithMessage("Kullanıcı adı zorunludur.")
                .Length(3, 50).WithMessage("Kullanıcı adı 3-50 karakter arasında olmalıdır.")
                .Matches(@"^[a-zA-Z0-9._-]+$").WithMessage("Kullanıcı adı sadece harf, rakam, nokta, tire ve alt çizgi içerebilir.");

            RuleFor(u => u.Password)
                .NotEmpty().WithMessage("Şifre zorunludur.")
                .MinimumLength(8).WithMessage("Şifre en az 8 karakter olmalıdır.")
                .MaximumLength(100).WithMessage("Şifre en fazla 100 karakter olmalıdır.")
                .Matches(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[\W_]).+$")
                .WithMessage("Şifre en az bir büyük harf, bir küçük harf, bir rakam ve bir özel karakter içermelidir.");

            RuleFor(u => u.CityID)
                .GreaterThan(0).WithMessage("Geçerli bir şehir seçiniz.")
                .When(u => u.CityID.HasValue);

            RuleFor(u => u.DistrictID)
                .GreaterThan(0).WithMessage("Geçerli bir ilçe seçiniz.")
                .When(u => u.DistrictID.HasValue);

            RuleFor(u => u.RoleID)
                .GreaterThan(0).WithMessage("Geçerli bir rol seçiniz.")
                .When(u => u.RoleID.HasValue);
        }
    }

    public class UserUpdateValidator : AbstractValidator<UserUpdateDto>
    {
        public UserUpdateValidator()
        {
            RuleFor(u => u.Name)
                .NotEmpty().WithMessage("Ad alanı zorunludur.")
                .Length(2, 50).WithMessage("Ad 2-50 karakter arasında olmalıdır.")
                .Matches(@"^[a-zA-ZçğıöşüÇĞIİÖŞÜ\s]+$").WithMessage("Ad sadece harf içermelidir.");

            RuleFor(u => u.Surname)
                .NotEmpty().WithMessage("Soyad alanı zorunludur.")
                .Length(2, 50).WithMessage("Soyad 2-50 karakter arasında olmalıdır.")
                .Matches(@"^[a-zA-ZçğıöşüÇĞIİÖŞÜ\s]+$").WithMessage("Soyad sadece harf içermelidir.");

            RuleFor(u => u.Mail)
                .NotEmpty().WithMessage("Email alanı zorunludur.")
                .EmailAddress().WithMessage("Geçerli bir email adresi giriniz.")
                .Length(5, 100).WithMessage("Email 5-100 karakter arasında olmalıdır.");

            RuleFor(u => u.UserName)
                .NotEmpty().WithMessage("Kullanıcı adı zorunludur.")
                .Length(3, 50).WithMessage("Kullanıcı adı 3-50 karakter arasında olmalıdır.")
                .Matches(@"^[a-zA-Z0-9._-]+$").WithMessage("Kullanıcı adı sadece harf, rakam, nokta, tire ve alt çizgi içerebilir.");

            RuleFor(u => u.Password)
                .MinimumLength(8).WithMessage("Şifre en az 8 karakter olmalıdır.")
                .MaximumLength(100).WithMessage("Şifre en fazla 100 karakter olmalıdır.")
                .Matches(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[\W_]).+$")
                .WithMessage("Şifre en az bir büyük harf, bir küçük harf, bir rakam ve bir özel karakter içermelidir.")
                .When(u => !string.IsNullOrWhiteSpace(u.Password)); // Şifre isteğe bağlı

            RuleFor(u => u.CityID)
                .GreaterThan(0).WithMessage("Geçerli bir şehir seçiniz.")
                .When(u => u.CityID.HasValue);

            RuleFor(u => u.DistrictID)
                .GreaterThan(0).WithMessage("Geçerli bir ilçe seçiniz.")
                .When(u => u.DistrictID.HasValue);

            RuleFor(u => u.RoleID)
                .GreaterThan(0).WithMessage("Geçerli bir rol seçiniz.")
                .When(u => u.RoleID.HasValue);
        }
    }

    public class UserRegisterValidator : AbstractValidator<UserRegisterDto>
    {
        public UserRegisterValidator()
        {
            RuleFor(u => u.Name)
                .NotEmpty().WithMessage("Ad alanı zorunludur.")
                .Length(2, 50).WithMessage("Ad 2-50 karakter arasında olmalıdır.")
                .Matches(@"^[a-zA-ZçğıöşüÇĞIİÖŞÜ\s]+$").WithMessage("Ad sadece harf içermelidir.");

            RuleFor(u => u.Surname)
                .NotEmpty().WithMessage("Soyad alanı zorunludur.")
                .Length(2, 50).WithMessage("Soyad 2-50 karakter arasında olmalıdır.")
                .Matches(@"^[a-zA-ZçğıöşüÇĞIİÖŞÜ\s]+$").WithMessage("Soyad sadece harf içermelidir.");

            RuleFor(u => u.Mail)
                .NotEmpty().WithMessage("Email alanı zorunludur.")
                .EmailAddress().WithMessage("Geçerli bir email adresi giriniz.")
                .Length(5, 100).WithMessage("Email 5-100 karakter arasında olmalıdır.");

            RuleFor(u => u.UserName)
                .NotEmpty().WithMessage("Kullanıcı adı zorunludur.")
                .Length(3, 50).WithMessage("Kullanıcı adı 3-50 karakter arasında olmalıdır.")
                .Matches(@"^[a-zA-Z0-9._-]+$").WithMessage("Kullanıcı adı sadece harf, rakam, nokta, tire ve alt çizgi içerebilir.");

            RuleFor(u => u.Password)
                .NotEmpty().WithMessage("Şifre zorunludur.")
                .MinimumLength(8).WithMessage("Şifre en az 8 karakter olmalıdır.")
                .MaximumLength(100).WithMessage("Şifre en fazla 100 karakter olmalıdır.")
                .Matches(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[!""#$%&'()*+,\-./:;<=>?@[\\\]^_`{|}~]).+$")
                .WithMessage("Şifre en az bir büyük harf, bir küçük harf, bir rakam ve bir özel karakter içermelidir.");

            RuleFor(u => u.ConfirmPassword)
                .NotEmpty().WithMessage("Şifre tekrarı zorunludur.")
                .Equal(u => u.Password).WithMessage("Şifreler eşleşmiyor.");

            RuleFor(u => u.CityID)
                .GreaterThan(0).WithMessage("Geçerli bir şehir seçiniz.")
                .When(u => u.CityID.HasValue);

            RuleFor(u => u.DistrictID)
                .GreaterThan(0).WithMessage("Geçerli bir ilçe seçiniz.")
                .When(u => u.DistrictID.HasValue);
        }
    }

    public class ChangePasswordValidator : AbstractValidator<ChangePasswordDto>
    {
        public ChangePasswordValidator()
        {
            RuleFor(u => u.CurrentPassword)
                .NotEmpty().WithMessage("Mevcut şifre zorunludur.");

            RuleFor(u => u.NewPassword)
                .NotEmpty().WithMessage("Yeni şifre zorunludur.")
                .MinimumLength(8).WithMessage("Şifre en az 8 karakter olmalıdır.")
                .MaximumLength(100).WithMessage("Şifre en fazla 100 karakter olmalıdır.")
                 .Matches(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[!""#$%&'()*+,\-./:;<=>?@[\\\]^_`{|}~]).+$")
                .WithMessage("Şifre en az bir büyük harf, bir küçük harf, bir rakam ve bir özel karakter içermelidir.")
                .NotEqual(u => u.CurrentPassword).WithMessage("Yeni şifre mevcut şifreden farklı olmalıdır.");

            RuleFor(u => u.ConfirmNewPassword)
                .NotEmpty().WithMessage("Şifre tekrarı zorunludur.")
                .Equal(u => u.NewPassword).WithMessage("Yeni şifreler eşleşmiyor.");
        }
    }

    public class ResetPasswordValidator : AbstractValidator<ResetPasswordDto>
    {
        public ResetPasswordValidator()
        {
            RuleFor(u => u.Mail)
                .NotEmpty().WithMessage("Email alanı zorunludur.")
                .EmailAddress().WithMessage("Geçerli bir email adresi giriniz.");

            RuleFor(u => u.Token)
                .NotEmpty().WithMessage("Reset token zorunludur.");

            RuleFor(u => u.NewPassword)
                .NotEmpty().WithMessage("Yeni şifre zorunludur.")
                .MinimumLength(8).WithMessage("Şifre en az 8 karakter olmalıdır.")
                .MaximumLength(100).WithMessage("Şifre en fazla 100 karakter olmalıdır.")
               .Matches(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[!""#$%&'()*+,\-./:;<=>?@[\\\]^_`{|}~]).+$")
                .WithMessage("Şifre en az bir büyük harf, bir küçük harf, bir rakam ve bir özel karakter içermelidir.");

            RuleFor(u => u.ConfirmPassword)
                .NotEmpty().WithMessage("Şifre tekrarı zorunludur.")
                .Equal(u => u.NewPassword).WithMessage("Şifreler eşleşmiyor.");
        }
    }
}