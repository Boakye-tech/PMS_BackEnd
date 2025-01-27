using System;
using System.Security.Claims;

namespace Modules.Users.Domain.Interfaces.Entities
{
	public interface ITokenStoreRepository : IRepository<TokenStore>
	{
        Task<string> GetToken(string mobilePhoneNumber_OR_emailAddress, int ExpiryMinutes);

        Task<bool> VerifyToken(string mobilePhoneNumber_OR_emailAddress, string tokenCode);

        JwTokenResponse GetJwToken(ApplicationIdentityUser user, int validityInHours);
        
        RefreshToken GetJwRefreshToken();

        ClaimsPrincipal GetClaimsPrincipalFromExpiredBearerToken(string bearerToken);
    }
}

