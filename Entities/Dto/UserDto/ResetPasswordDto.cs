using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dto.UserDto
{
    public class ResetPasswordDto
    {
        [Required(ErrorMessage = "Email alanı zorunludur")]
        [EmailAddress(ErrorMessage = "Geçerli bir email adresi giriniz")]
        public string Mail { get; set; }

        [Required(ErrorMessage = "Reset token zorunludur")]
        public string Token { get; set; }

        [Required(ErrorMessage = "Yeni şifre zorunludur")]
        [StringLength(100, MinimumLength = 8, ErrorMessage = "Şifre en az 8, en fazla 100 karakter olmalıdır")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]",
            ErrorMessage = "Şifre en az bir büyük harf, bir küçük harf, bir rakam ve bir özel karakter içermelidir")]
        public string NewPassword { get; set; }

        [Required(ErrorMessage = "Şifre tekrarı zorunludur")]
        [Compare("NewPassword", ErrorMessage = "Şifreler eşleşmiyor")]
        public string ConfirmPassword { get; set; }
    }
}
