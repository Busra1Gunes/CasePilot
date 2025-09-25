using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Security.Cryptography;
using Business.Abstract;

namespace Business.Concrete
{
    public class PasswordManager:IPasswordService
    { // BCrypt ile hashleme (En güvenli ve önerilen yöntem)
        public string HashPassword(string password)
        {
            // Work factor 12 senior level için uygun (2^12 = 4096 iterasyon)
            // Production'da 14-16 arası da kullanılabilir
            return BCrypt.Net.BCrypt.HashPassword(password, workFactor: 12);
        }

        public bool VerifyPassword(string password, string hashedPassword)
        {
            return BCrypt.Net.BCrypt.Verify(password, hashedPassword);
        }
    }
}
