using System;

namespace Modules.Users.Application.UseCases.UserAccounts
{
	public class TokenService : ITokenService
    {
        readonly IUnitOfWork _unitOfWork;

		public TokenService(IUnitOfWork unitOfWork)
		{
            _unitOfWork = unitOfWork;
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

