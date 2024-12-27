using System;
namespace Modules.Users.Application.Interfaces
{
	public interface ITokenService
	{
        Task<string> GetToken(string mobilePhoneNumber, int ExpiryMinutes);

        Task<bool> VerifyToken(string mobilePhoneNumber, string tokenCode);

        //Task<JwTokenResponseDto> GetJwToken(ApplicationIdentityUser user, string password, int validityInHours);
        Task<string> GetJwToken(ApplicationIdentityUser user, int validityInHours);
        //string RandomSixDigitNumber();
    }
}

