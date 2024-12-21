using System;
namespace Modules.Users.Application.Interfaces
{
	public interface ITokenService
	{
        Task<string> GetToken(string mobilePhoneNumber, int ExpiryMinutes);

        Task<bool> VerifyToken(string mobilePhoneNumber, string tokenCode);

        //string RandomSixDigitNumber();
    }
}

