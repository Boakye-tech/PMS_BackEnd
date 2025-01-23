using System;
namespace Modules.Users.Domain.Interfaces.Entities
{
	public interface ITokenStoreRepository : IRepository<TokenStore>
	{
        Task<string> GetToken(string mobilePhoneNumber_OR_emailAddress, int ExpiryMinutes);

        Task<bool> VerifyToken(string mobilePhoneNumber_OR_emailAddress, string tokenCode);

        //Task<JwTokenResponseDto> GetJwToken(ApplicationIdentityUser user, string password, int validityInHours);
        Task<string> GetJwToken(ApplicationIdentityUser user, int validityInHours);
        //string RandomSixDigitNumber();
    }
}

