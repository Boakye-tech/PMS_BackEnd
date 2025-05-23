﻿// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


using System.Security.Claims;

namespace Modules.Users.Domain.Interfaces.Entities
{
	public interface ITokenStoreRepository : IRepository<TokenStore>
	{
        Task<string> GetToken(string mobilePhoneNumber_OR_emailAddress, int ExpiryMinutes);

        Task<string> VerifyToken(string mobilePhoneNumber_OR_emailAddress, string tokenCode);

        string VerifyTokenExpiry(string mobilePhoneNumber_OR_emailAddress, string tokenCode);

        string CheckVerifiedToken(string mobilePhoneNumber_OR_emailAddress, string tokenCode);

        JwTokenResponse GetJwToken(ApplicationIdentityUser user, int validityInHours);

        RefreshToken GetJwRefreshToken();

        ClaimsPrincipal GetClaimsPrincipalFromExpiredBearerToken(string bearerToken);
    }
}

