using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class User : Entity
    {
        public int? CityID { get; set; }
        public int? DistrictID { get; set; }
        public int? RoleID { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(50)]
        public string Surname { get; set; }

        [Required]
        [StringLength(100)]
        [EmailAddress]
        public string Mail { get; set; }

        [Required]
        [StringLength(50)]
        public string UserName { get; set; }

        [Required]
        [StringLength(255)] // BCrypt hash uzunluğu için yeterli
        public string Password { get; set; }

        // Şifre sıfırlama için eklenen alanlar
        [StringLength(255)]
        public string? ResetToken { get; set; }

        public DateTime? ResetTokenExpiry { get; set; }

        // Son giriş tarihi
        public DateTime? LastLoginDate { get; set; }

        // Hesap kilitleme için
        public bool IsLocked { get; set; } = false;
        public DateTime? LockedUntil { get; set; }
        public int FailedLoginAttempts { get; set; } = 0;

        // Email doğrulama için
        public bool EmailConfirmed { get; set; } = false;
        public string? EmailConfirmationToken { get; set; }

        // Navigation Properties
        public City? City { get; set; }
        public District? District { get; set; }
        public Role? Role { get; set; }
        public ICollection<CaseFileShare>? CaseFileShares { get; set; }
        public ICollection<AccountTransaction> HesapHareket1 { get; set; } = new List<AccountTransaction>();
        public ICollection<AccountTransaction> HesapHareket2 { get; set; } = new List<AccountTransaction>();

        // Computed Properties
        public string FullName => $"{Name} {Surname}";
        public bool IsActive => Status && !IsLocked && (LockedUntil == null || LockedUntil < DateTime.Now);
    }
}
