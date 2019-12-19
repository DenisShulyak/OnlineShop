using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using OnlineShop.DataAccess;
using OnlineShop.Services.Options;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Services
{
    public class AuthService: IAuthService
    {
        private readonly OnlineShopContext context;
        private readonly string jwtSecret;

        public AuthService(OnlineShopContext context, IOptions<SecretOptions> secretOptions)
        {
            this.context = context;
            jwtSecret = secretOptions.Value.JWTSecret;
        }
        public async Task<string> Authenticate(string phoneNumber, string code)//------------phoneNumber and code
        {
            var exestUser = await context.Users.FirstOrDefaultAsync(user => user.VerificationCode == code && user.PhoneNumber == phoneNumber);
            if (exestUser == null)
            {
                return null;
            }


            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(jwtSecret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.MobilePhone, phoneNumber)
                }),
                Expires = DateTime.UtcNow.AddYears(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);


            return tokenHandler.WriteToken(token);

        }
    }
}
