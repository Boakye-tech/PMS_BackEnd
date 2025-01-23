using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Text.RegularExpressions;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Modules.Users.Application.Interfaces;
using Modules.Users.Domain.Interfaces.Entities;

namespace Modules.Users.Infrastructure.Repositories.Entities
{
	public class TokenStoreRepository : Repository<TokenStore>, ITokenStoreRepository
	{
        private IConfiguration _configuration { get; }

        private readonly UserDbContext _userDbContext;
        readonly UserManager<ApplicationIdentityUser> _userManager;
        readonly IMenuService _menuService;


        public TokenStoreRepository(UserDbContext dbContext, UserManager<ApplicationIdentityUser> userManager, IMenuService menuService, IConfiguration configuration) : base(dbContext)
		{
            _userDbContext = dbContext;
            _userManager = userManager;
            _menuService = menuService;
            _configuration = configuration;
        }

        public async Task<string> GetJwToken(ApplicationIdentityUser user, int validityInHours)
        {
            //throw new NotImplementedException();
            var userRoles = _userManager.GetRolesAsync(user).Result.FirstOrDefault();

            var claims = await _menuService.GetUserRoleClaims(user.Id);

            var allClaims = new List<Claim>
                    {
                        new Claim(ClaimTypes.NameIdentifier, user.Id),
                        new Claim(ClaimTypes.Role, userRoles!),
                        new Claim(ClaimTypes.Email, user.Email!),
                new Claim(ClaimTypes.MobilePhone, user.PhoneNumber!)
            };

            allClaims.AddRange(claims);

            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_configuration.GetSection("JwTokenKey").GetSection("TokenKey").Value!);

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(allClaims),
                Expires = DateTime.UtcNow.AddHours(validityInHours),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            var tokenString = tokenHandler.WriteToken(token);

            return tokenString.ToString();
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
    }
}

