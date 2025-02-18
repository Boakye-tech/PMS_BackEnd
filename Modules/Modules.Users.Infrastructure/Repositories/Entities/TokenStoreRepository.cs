using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Modules.Users.Application.Dtos.Entities.Permissions;
using Modules.Users.Application.Interfaces;

namespace Modules.Users.Infrastructure.Repositories.Entities
{
	public class TokenStoreRepository : Repository<TokenStore>, ITokenStoreRepository
	{

        string mobilePhoneNumber = string.Empty, emailAddress = string.Empty;

        Regex emailRegex = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        Regex phoneRegex = new Regex(@"^0[25][1-9]{8}$");

        private IConfiguration _configuration { get; }

        private readonly UserDbContext _userDbContext;
        readonly UserManager<ApplicationIdentityUser> _userManager;
        //readonly IMenuService _menuService;

        private readonly HttpClient _httpClient;


        public TokenStoreRepository(UserDbContext dbContext, UserManager<ApplicationIdentityUser> userManager,  IConfiguration configuration, HttpClient httpClient) : base(dbContext) //IMenuService menuService,
        {
            _userDbContext = dbContext;
            _userManager = userManager;
            //_menuService = menuService;
            _configuration = configuration;
            _httpClient = httpClient;
        }

        private async Task SendTokenViaNotification(string userid, string token)
        {
            var user = await _userManager.FindByEmailAsync(userid);

            var sb = new StringBuilder();

            sb.AppendLine($"Dear {user!.FirstName} {user.LastName},<br>");
            sb.AppendLine("<br>");
            sb.AppendLine($"We received a request for verification on your account. To ensure the security of your account, please use the One-Time Password (OTP) below to continue:<br>");
            sb.AppendLine("<br>");
            sb.AppendLine($"Your OTP: <b>{token}</b><br>");
            sb.AppendLine("<br>");
            sb.AppendLine($"This OTP is valid for the next 3-5 minutes. For your protection, please do not share this code with anyone.<br>");
            sb.AppendLine("<br>");
            sb.AppendLine($"If you didn’t make this request, kindly ignore this email or contact our support team immediately.<br>");
            sb.AppendLine("<br>");
            sb.AppendLine($"Thank you for your attention.<br>");
            sb.AppendLine("<br>");
            sb.AppendLine($"Kind regards,<br>");
            sb.AppendLine("<br>");
            sb.AppendLine($"TDC MIS Team<br>");
            sb.AppendLine($"TDC Ghana Ltd.<br>");
            sb.AppendLine($"0302211211<br>");

            
            var email_payload = new { userId = userid, displayName = "Notifications", subject = "OTP VERIFICATION", message = sb.ToString(), type = 0 };
            var sms_payload = new { userId = user.PhoneNumber, displayName = string.Empty, subject = string.Empty, message = $"Kindly use OTP {token}  for account verification. 'NEVER SHARE THIS OTP WITH ANYONE'" , type = 1 };


            string json_smspayload = JsonSerializer.Serialize(sms_payload);
            var sms_httpContent = new StringContent(json_smspayload, Encoding.UTF8, "application/json");
            HttpResponseMessage sms_response = await _httpClient.PostAsync("https://mindsprings-002-site1.ltempurl.com/api/v1/Notification/SendNotification", sms_httpContent);
            var result_sms = sms_response.IsSuccessStatusCode;

            string json_emailpayload = JsonSerializer.Serialize(email_payload);
            var email_httpContent = new StringContent(json_emailpayload, Encoding.UTF8, "application/json");
            HttpResponseMessage response = await _httpClient.PostAsync("https://mindsprings-002-site1.ltempurl.com/api/v1/Notification/SendNotification", email_httpContent);
            var result = response.IsSuccessStatusCode;

        }

        public async Task<string> GetToken(string mobilePhoneNumber_OR_emailAddress, int ExpiryMinutes)
        {
            string token = Application.Helpers.NumberGenerator.Generator(6);


            if (emailRegex.IsMatch(mobilePhoneNumber_OR_emailAddress))
            {
                emailAddress = mobilePhoneNumber_OR_emailAddress;
            }

            if (emailAddress == string.Empty && !phoneRegex.IsMatch(mobilePhoneNumber_OR_emailAddress))
            {
                return "Invalid mobile phone number provided";
            }

            if (phoneRegex.IsMatch(mobilePhoneNumber_OR_emailAddress))
            {
                mobilePhoneNumber = mobilePhoneNumber_OR_emailAddress;
            }

            if(emailAddress == string.Empty && mobilePhoneNumber == string.Empty)
            {
                return "Invalid mobile phone number or email address provided";
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

            _userDbContext.TokenStore.Add(tokenStore);
            await _userDbContext.SaveChangesAsync();

            await this.SendTokenViaNotification(emailAddress, token);

            return token;
        }

        public async Task<string> VerifyToken(string mobilePhoneNumber_OR_emailAddress, string tokenCode)
        {
            if(string.IsNullOrWhiteSpace(mobilePhoneNumber_OR_emailAddress) is true && string.IsNullOrWhiteSpace(tokenCode) is true)
            {
                return "Invalid mobile phone number or email address provided";
            }

            if (emailRegex.IsMatch(mobilePhoneNumber_OR_emailAddress))
            {
                emailAddress = mobilePhoneNumber_OR_emailAddress;
            }

            if (emailAddress == string.Empty && !phoneRegex.IsMatch(mobilePhoneNumber_OR_emailAddress))
            {
                return "Invalid mobile phone number provided";
            }

            if (phoneRegex.IsMatch(mobilePhoneNumber_OR_emailAddress))
            {
                mobilePhoneNumber = mobilePhoneNumber_OR_emailAddress;
            }

            if (emailAddress == string.Empty && mobilePhoneNumber == string.Empty)
            {
                return "Invalid mobile phone number or email address provided";
            }


            var result = _userDbContext.TokenStore.SingleOrDefault(t => t.MobilePhoneNumber == mobilePhoneNumber_OR_emailAddress || t.EmailAddress == mobilePhoneNumber_OR_emailAddress && t.Token == tokenCode && t.IsVerified == false);

            if (result is null) 
            {
                return "Not Verified";
            }

            result!.IsVerified = true;
            result.VerifiedDate = DateTime.UtcNow;

            _userDbContext.TokenStore.Update(result);
            await _userDbContext.SaveChangesAsync();

            return "Verified";
        }

        public string VerifyTokenExpiry(string mobilePhoneNumber_OR_emailAddress, string tokenCode)
        {
            if (string.IsNullOrWhiteSpace(mobilePhoneNumber_OR_emailAddress) is true && string.IsNullOrWhiteSpace(tokenCode) is true)
            {
                return "Invalid mobile phone number or email address provided";
            }

            if (emailRegex.IsMatch(mobilePhoneNumber_OR_emailAddress))
            {
                emailAddress = mobilePhoneNumber_OR_emailAddress;
            }

            if (emailAddress == string.Empty && !phoneRegex.IsMatch(mobilePhoneNumber_OR_emailAddress))
            {
                return "Invalid mobile phone number provided";
            }

            if (phoneRegex.IsMatch(mobilePhoneNumber_OR_emailAddress))
            {
                mobilePhoneNumber = mobilePhoneNumber_OR_emailAddress;
            }

            if (emailAddress == string.Empty && mobilePhoneNumber == string.Empty)
            {
                return "Invalid mobile phone number or email address provided";
            }


            var result = _userDbContext.TokenStore
                .SingleOrDefault(t =>
                    (t.MobilePhoneNumber == mobilePhoneNumber_OR_emailAddress || t.EmailAddress == mobilePhoneNumber_OR_emailAddress) &&
                     t.Token == tokenCode && t.ExpiryDate >= DateTime.UtcNow);

            if (result is null)
            {
                return "Not Verified";
            }


            return "Verified";
        }

        public JwTokenResponse GetJwToken(ApplicationIdentityUser user, int validityInHours)
        {
            var userRoles = _userManager.GetRolesAsync(user).Result.FirstOrDefault();
            var roleId = _userDbContext.roles
                                       .Where(r => r.Name == userRoles!)
                                       .Select(r => r.Id)
                                       .FirstOrDefault();

            var claims = this.GetModulesPermissions(roleId!);

            var allClaims = new List<Claim>
                    {
                        new Claim(ClaimTypes.NameIdentifier, user.Id),
                        new Claim(ClaimTypes.Role, userRoles!),
                        new Claim(ClaimTypes.Email, user.Email!),
                        new Claim(ClaimTypes.MobilePhone, user.PhoneNumber!)
            };

            foreach (var permission in claims)
            {
                allClaims.Add(new Claim($"Permission:{permission.ModuleName}:{permission.ModulePermission}", permission.ModulePermission!));
            }

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

        private IEnumerable<RoleModulesPermissionsDto> GetModulesPermissions(string roleId)
        {
            //var modulePermissions = (_userDbContext.ApplicationModulesPermissions)
            //   .Where(a => a.RoleId == roleId) // Filter where based on RoleId 
            //   .GroupJoin(_userDbContext.ApplicationModules,
            //       a => a.ModuleId,
            //       b => b.ModuleId,
            //       (a, moduleGroup) => new { a, module = moduleGroup.FirstOrDefault() }) // Left Join on ApplicationModules
            //   .GroupJoin(_userDbContext.Roles,
            //       ab => ab.a.RoleId,
            //       c => c.Id,
            //       (ab, roleGroup) => new RoleModulesPermissionsDto
            //       {
            //           ModulePermissionId = ab.a.ModulePermissionId,
            //           RoleId = ab.a.RoleId,
            //           RoleName = roleGroup.FirstOrDefault()!.Name, // Left Join on Roles
            //           ModuleId = ab.a.ModuleId,
            //           ModuleName = ab.module!.ModuleName,
            //           ModulePermission = ab.a.ModulePermission
            //       })
            //   .ToList();

            var modulePermissions = (from a in _userDbContext.ApplicationModulesPermissions
                                     join b in _userDbContext.ApplicationModules
                                         on a.ModuleId equals b.ModuleId into modules
                                     from module in modules.DefaultIfEmpty() // Left Join on ApplicationModules
                                     join c in _userDbContext.Roles
                                         on a.RoleId equals c.Id into roles
                                     from role in roles.DefaultIfEmpty() // Left Join on Roles
                                     where a.RoleId == roleId // Filter based on RoleId
                                     select new RoleModulesPermissionsDto
                                     {
                                         ModulePermissionId = a.ModulePermissionId,
                                         RoleId = a.RoleId,
                                         RoleName = role != null ? role.Name : "No Role",
                                         ModuleId = a.ModuleId,
                                         ModuleName = module != null ? module.ModuleName : "No Module",
                                         ModulePermission = a.ModulePermission
                                     }).ToList();




            //return _mapper.Map<IEnumerable<RoleModulesPermissionsDto>>(modulePermissions);
            return modulePermissions;

        }

    }
}

