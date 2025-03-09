using System;
namespace Modules.Users.Application.Dtos.Entities
{
	public record TokenStoreReadDto(int TokenStoreId, string MobilePhoneNumber, string EmailAddress, string? Token, DateTime CreatedDate, DateTime ExpiryDate, bool IsVerified, DateTime VerifiedDate);
    public record TokenStoreCreateDto(int TokenStoreId, string MobilePhoneNumber, string EmailAddress, string? Token, DateTime CreatedDate, DateTime ExpiryDate, bool IsVerified, DateTime VerifiedDate, string CreatedBy);
    //public record TokenStoreDto(int TokenStoreId, string MobilePhoneNumber, string EmailAddress, string? Token, DateTime CreatedDate, DateTime ExpiryDate, bool IsVerified, DateTime VerifiedDate, string ModifiedBy);
    //public record TokenStoreDto(int TokenStoreId);

    public record TokenRequestParameterDto(string phone_OR_email);
    public record TokenResponseDto(string response);


    public record VerifyTokenRequestDto(string phone_OR_email, string token);
    
}

