using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Security.Encryption
{
    //Şifreleme sistemlerinde bizim her şeyi byte array formatında oluşturmamız gerekir.
    //Yani bir string ile key oluşturamıyoruz.
    //Bu string değerleri asp.net'in jwt servislerinin anlayacağı hale getirmemiz gerekir.
    public class SecurityKeyHelper
    {
        //Parametreyle gelen WebApi katmanındaki appsettings.json dosyasındaki securityKey'i, SecurityKey formatına dönüştürüyoruz. 
        public static SecurityKey CreateSecurityKey(string securityKey)
        {
            return new SymmetricSecurityKey(Encoding.UTF8.GetBytes(securityKey));
        }
    }
}
