using Business.Utilities.Security;
using Core.Utilities.Security.Encryption;
using Core.Utilities.Security.JWT;
using Core.Extensions;
using Entities.Concrete;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Business.Utilities.Security.JWT
{
    public class JwtHelper : ITokenHelper
    {
        public IConfiguration Configuration { get; }
        private TokenOptions _tokenOptions;
        private DateTime _accessTokenExpiration;

        public JwtHelper(IConfiguration configuration)
        {
            Configuration = configuration;
            _tokenOptions = Configuration.GetSection("JWT").Get<TokenOptions>();
        }

        public AccessToken CreateToken(User user)
        {
            _accessTokenExpiration = DateTime.Now.AddMinutes(_tokenOptions.AccessTokenExpiration);
            var securityKey = SecurityKeyHelper.CreateSecurityKey(_tokenOptions.SecurityKey);
            var signingCredentials = SigningCredentialsHelper.CreateSigningCredentials(securityKey);

            var jwt = CreateJwtSecurityToken(_tokenOptions, user, signingCredentials);

            var tokenHandler = new JwtSecurityTokenHandler();
            var token = tokenHandler.WriteToken(jwt);
            // Yetkileri buradan toplayalım
            var permissions = user.UserRoles?
                .Where(ur => ur.Role != null)
                .SelectMany(ur => ur.Role.RolePermissions ?? new List<RolePermission>())
                .Where(rp => rp.Permission != null)
                .Select(rp => rp.Permission.Name)
                .Distinct()
                .ToList() ?? new List<string>();

            return new AccessToken
            {
                Token = token,
                Expiration = _accessTokenExpiration,
                Permissions= string.Join(",", permissions)
            };
        }

        public JwtSecurityToken CreateJwtSecurityToken(TokenOptions tokenOptions, User user,
            SigningCredentials signingCredentials)
        {
            return new JwtSecurityToken(
                issuer: tokenOptions.Issuer,
                audience: tokenOptions.Audience,
                expires: _accessTokenExpiration,
                notBefore: DateTime.Now,
                claims: SetClaims(user),
                signingCredentials: signingCredentials
            );
        }

        private IEnumerable<Claim> SetClaims(User user)
        {
            var claims = new List<Claim>();

            // Temel bilgiler
            claims.Add(new Claim(ClaimTypes.NameIdentifier, user.ID.ToString()));
            claims.Add(new Claim(ClaimTypes.Email, user.Mail ?? ""));
            claims.Add(new Claim(ClaimTypes.Name, $"{user.Name} {user.Surname}"));

            // Roller ve yetkiler
            if (user.UserRoles != null)
            {
                // Roller
                var roles = user.UserRoles
                    .Where(ur => ur.Role != null)
                    .Select(ur => ur.Role.Name)
                    .Distinct()
                    .ToList();

                foreach (var role in roles)
                    claims.Add(new Claim(ClaimTypes.Role, role));

                // Yetkiler
                var permissions = user.UserRoles
                    .Where(ur => ur.Role != null)
                    .SelectMany(ur => ur.Role.RolePermissions ?? new List<RolePermission>())
                    .Where(rp => rp.Permission != null)
                    .Select(rp => rp.Permission.Name)
                    .Distinct()
                    .ToList();

                foreach (var permission in permissions)
                    claims.Add(new Claim("permission", permission));
            }

            return claims;
        }
    }
}
