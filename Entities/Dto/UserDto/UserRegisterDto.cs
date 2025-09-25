using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dto.UserDto
{
    public class UserRegisterDto
    {
        [Required(ErrorMessage = "Ad alanı zorunludur")]
        [StringLength(50, ErrorMessage = "Ad en fazla 50 karakter olabilir")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Soyad alanı zorunludur")]
        [StringLength(50, ErrorMessage = "Soyad en fazla 50 karakter olabilir")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Email alanı zorunludur")]
        [EmailAddress(ErrorMessage = "Geçerli bir email adresi giriniz")]
        [StringLength(100, ErrorMessage = "Email en fazla 100 karakter olabilir")]
        public string Mail { get; set; }

        [Required(ErrorMessage = "Kullanıcı adı zorunludur")]
        [StringLength(50, ErrorMessage = "Kullanıcı adı en fazla 50 karakter olabilir")]
        [RegularExpression("^[a-zA-Z0-9._-]+$", ErrorMessage = "Kullanıcı adı sadece harf, rakam, nokta, tire ve alt çizgi içerebilir")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Şifre zorunludur")]
        [StringLength(100, MinimumLength = 8, ErrorMessage = "Şifre en az 8, en fazla 100 karakter olmalıdır")]

        public string Password { get; set; }

        [Required(ErrorMessage = "Şifre tekrarı zorunludur")]
        [Compare("Password", ErrorMessage = "Şifreler eşleşmiyor")]
        public string ConfirmPassword { get; set; }

        public int? CityID { get; set; }
        public int? DistrictID { get; set; }
        public int? RoleID { get; set; }
    }

}
