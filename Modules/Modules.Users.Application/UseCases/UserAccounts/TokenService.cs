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

        readonly UserManager<ApplicationIdentityUser> _userManager;
        readonly SignInManager<ApplicationIdentityUser> _signInManager;

        public TokenService(IUnitOfWork unitOfWork, UserManager<ApplicationIdentityUser> userManager, IConfiguration configuration, SignInManager<ApplicationIdentityUser> signInManager)
		{
            _unitOfWork = unitOfWork;
            _userManager = userManager;
            _signInManager = signInManager;
            _configuration = configuration;

        }

        public async Task<JwTokenResponseDto> GetJwToken(ApplicationIdentityUser user, string password)
        {
            //throw new NotImplementedException();
            if (user is not null)
            {
                var userRoles = _userManager.GetRolesAsync(user).Result.FirstOrDefault();
                var result = await _signInManager.PasswordSignInAsync(user, password, true, false);

                if (result.Succeeded)
                {
                    var tokenHandler = new JwtSecurityTokenHandler();
                    var key = Encoding.ASCII.GetBytes(_configuration.GetSection("ApiTokenKey").GetSection("TokenKey").Value!);

                    var tokenDescriptor = new SecurityTokenDescriptor
                    {
                        Subject = new ClaimsIdentity(new Claim[]
                        {
                                new Claim(ClaimTypes.NameIdentifier, user.Id),
                                new Claim(ClaimTypes.Role, userRoles!),
                                new Claim(ClaimTypes.Email, user.Email!),
                                new Claim(ClaimTypes.MobilePhone, user.PhoneNumber!)
                        }),

                        Expires = DateTime.UtcNow.AddHours(24),
                        SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256)
                    };
                    var token = tokenHandler.CreateToken(tokenDescriptor);
                    var tokenString = tokenHandler.WriteToken(token);

                    return new JwTokenResponseDto { Token = tokenString.ToString(), UserType = userRoles };
                }

                return new JwTokenResponseDto { Token = result.ToString(), UserType = userRoles };
            }

            return new JwTokenResponseDto { Token = "Not Found", UserType = string.Empty }; ;
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
            //throw new NotImplementedException();
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

        //public string RandomSixDigitNumber()
        //{
        //    throw new NotImplementedException();
        //}

    }
}

