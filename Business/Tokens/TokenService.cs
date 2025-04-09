using Core.Tokens;
using Entities.Concrete;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Business.Tokens
{
    public class TokenService : ITokenService
    {
        private readonly TokenSettings tokenSettings;
        private const string securityAlgorithm = SecurityAlgorithms.HmacSha512Signature;


        public TokenService(IOptions<TokenSettings> options)
        {
            tokenSettings = options.Value;
        }

        public JwtSecurityToken CreateToken(Kullanici user, IList<string> roles)
        {
            List<Claim> claims = new()
            {
                new(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
               
                new(ClaimTypes.NameIdentifier, user.Id.ToString()),
                new(ClaimTypes.Email, user.Mail),
                new(ClaimTypes.Name, user.Adi+ " "+user.Soyadi)
            };

            foreach (var role in roles)
            {
                claims.Add(new(ClaimTypes.Role, role));
            }


            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(tokenSettings.Secret));
            var token = new JwtSecurityToken(
                issuer: tokenSettings.Issuer,
                audience: tokenSettings.Audience,
                expires: DateTime.Now.AddMinutes(tokenSettings.TokenValidityInMinutes),
                claims: claims,
                signingCredentials: new SigningCredentials(key, securityAlgorithm));

            return token;
        }

    }
}
