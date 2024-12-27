using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

namespace Modules.Users.Application.UseCases.UserAccounts
{
	public class TokenService : ITokenService
    {
        private IConfiguration _configuration { get; }

        readonly IUnitOfWork _unitOfWork;
        readonly IMenuService _menuService;

        readonly UserManager<ApplicationIdentityUser> _userManager;
        //readonly SignInManager<ApplicationIdentityUser> _signInManager;

        public TokenService(IUnitOfWork unitOfWork, IMenuService menuService ,UserManager<ApplicationIdentityUser> userManager, IConfiguration configuration) //, SignInManager<ApplicationIdentityUser> signInManager)

        {
            _unitOfWork = unitOfWork;
            _menuService = menuService;
            _userManager = userManager;
            //_signInManager = signInManager;
            _configuration = configuration;

        }


        //public async Task<JwTokenResponseDto> GetJwToken(ApplicationIdentityUser user, string password, int validityInHours)
        public async Task<string> GetJwToken(ApplicationIdentityUser user, int validityInHours)
        {
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
            var token = Helpers.NumberGenerator.Generator(6);

            string mobilePhoneNumber =string.Empty, emailAddress = string.Empty;

            if (mobilePhoneNumber_OR_emailAddress.Contains("@") == true)
            {
                emailAddress = mobilePhoneNumber_OR_emailAddress;
            }
            else
            {
                mobilePhoneNumber = mobilePhoneNumber_OR_emailAddress;
            }

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

            _unitOfWork.TokenStore.Insert(tokenStore);
            await _unitOfWork.Complete();

            return token;
        }



        public async Task<bool> VerifyToken(string mobilePhoneNumber_OR_emailAddress, string tokenCode)
        {
            var result = await _unitOfWork.TokenStore.Get(t => t.MobilePhoneNumber == mobilePhoneNumber_OR_emailAddress || t.EmailAddress == mobilePhoneNumber_OR_emailAddress && t.Token == tokenCode && t.IsVerified == false);

            if(result is null)
            {
                return false;
            }

            result!.IsVerified = true;
            result.VerifiedDate = DateTime.UtcNow;

            _unitOfWork.TokenStore.Update(result);
            await _unitOfWork.Complete();

            return true;
        }


    }
}

