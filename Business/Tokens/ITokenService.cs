using Entities.Concrete;
using System.IdentityModel.Tokens.Jwt;

namespace Business.Tokens
{
    public interface ITokenService
    {
        JwtSecurityToken CreateToken(Kullanici user,  IList<string> roles);
    }
}
