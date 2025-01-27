using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

namespace Modules.Users.Infrastructure.Repositories.Entities
{
	public class TokenStoreRepository : Repository<TokenStore>, ITokenStoreRepository
	{
        private IConfiguration _configuration { get; }

        private readonly UserDbContext _userDbContext;
        readonly UserManager<ApplicationIdentityUser> _userManager;
        //readonly IMenuService _menuService;


        public TokenStoreRepository(UserDbContext dbContext, UserManager<ApplicationIdentityUser> userManager,  IConfiguration configuration) : base(dbContext) //IMenuService menuService,
        {
            _userDbContext = dbContext;
            _userManager = userManager;
            //_menuService = menuService;
            _configuration = configuration;
        }



        public async Task<string> GetToken(string mobilePhoneNumber_OR_emailAddress, int ExpiryMinutes)
        {
            //throw new NotImplementedException();
            var token = Application.Helpers.NumberGenerator.Generator(6);

            string mobilePhoneNumber = string.Empty, emailAddress = string.Empty;

            var emailRegex = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$");
            var phoneRegex = new Regex(@"^\+?\d{10,15}$");

            if (emailRegex.IsMatch(mobilePhoneNumber_OR_emailAddress))
            {
                emailAddress = mobilePhoneNumber_OR_emailAddress;
            }

            if (phoneRegex.IsMatch(mobilePhoneNumber_OR_emailAddress))
            {
                mobilePhoneNumber = mobilePhoneNumber_OR_emailAddress;
            }

            //if (mobilePhoneNumber_OR_emailAddress.Contains("@") == true)
            //{
            //    emailAddress = mobilePhoneNumber_OR_emailAddress;
            //}
            //else
            //{
            //    mobilePhoneNumber = mobilePhoneNumber_OR_emailAddress;
            //}

            TokenStore tokenStore = new TokenStore()
            {
                TokenStoreId = 0,
                EmailAddress = emailAddress,
                MobilePhoneNumber = mobilePhoneNumber,
                Token = token,
                CreatedDate = DateTime.Now,
                ExpiryDate = DateTime.Now.AddMinutes(ExpiryMinutes),
                IsVerified = false
            };

            await _userDbContext.TokenStore.AddAsync(tokenStore);
            await _userDbContext.SaveChangesAsync();

            return token;
        }

        public async Task<bool> VerifyToken(string mobilePhoneNumber_OR_emailAddress, string tokenCode)
        {
            //throw new NotImplementedException();
            var result = _userDbContext.TokenStore.SingleOrDefault(t => t.MobilePhoneNumber == mobilePhoneNumber_OR_emailAddress || t.EmailAddress == mobilePhoneNumber_OR_emailAddress && t.Token == tokenCode && t.IsVerified == false);

            if (result is null) 
            {
                return false;
            }

            result!.IsVerified = true;
            result.VerifiedDate = DateTime.UtcNow;

            _userDbContext.TokenStore.Update(result);
            await _userDbContext.SaveChangesAsync();

            return true;
        }

        public JwTokenResponse GetJwToken(ApplicationIdentityUser user, int validityInHours)
        {
            //throw new NotImplementedException();
            var userRoles = _userManager.GetRolesAsync(user).Result.FirstOrDefault();

            //var claims = await _menuService.GetUserRoleClaims(user.Id);

            var allClaims = new List<Claim>
                    {
                        new Claim(ClaimTypes.NameIdentifier, user.Id),
                        new Claim(ClaimTypes.Role, userRoles!),
                        new Claim(ClaimTypes.Email, user.Email!),
                new Claim(ClaimTypes.MobilePhone, user.PhoneNumber!)
            };

            //allClaims.AddRange(claims);

            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_configuration["JwTokenKey:TokenKey"]!);

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(allClaims),
                Expires = DateTime.UtcNow.AddHours(validityInHours),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            var tokenString = tokenHandler.WriteToken(token);

            return new JwTokenResponse
            {
                Token = tokenString.ToString(),
                ExpiresAt = tokenDescriptor.Expires
            };
        }

        public RefreshToken GetJwRefreshToken()
        {
            var randomNumber = new byte[64];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(randomNumber);
                return new RefreshToken
                {
                    Token = Convert.ToBase64String(randomNumber),
                    Expires = DateTime.UtcNow.AddDays(6),
                    Created = DateTime.UtcNow
                };
            }
        }


        public ClaimsPrincipal GetClaimsPrincipalFromExpiredBearerToken(string bearerToken)
        {
            var key = Encoding.ASCII.GetBytes(_configuration["JwTokenKey:TokenKey"]!);
            var tokenValidationParameters = new TokenValidationParameters
            {
                ValidateIssuer = false,
                ValidateAudience = false,
                ValidateLifetime = false,
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new SymmetricSecurityKey(key),
                ClockSkew = TimeSpan.Zero
            };

            var tokenHandler = new JwtSecurityTokenHandler();
            var principal = tokenHandler.ValidateToken(bearerToken, tokenValidationParameters, out SecurityToken securityToken);
            JwtSecurityToken? jwtSecurityToken = securityToken as JwtSecurityToken;
            if (jwtSecurityToken == null || !jwtSecurityToken.Header.Alg.Equals(SecurityAlgorithms.HmacSha256, StringComparison.InvariantCultureIgnoreCase))
            {
                throw new SecurityTokenException("Invalid token");
            }

            return principal;
        }
    }
}

