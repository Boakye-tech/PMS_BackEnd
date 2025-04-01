using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Modules.Users.Application.Dtos.UserAccounts
{
	public record CustomerRegistrationRequestDto(
        string CustomerCode,
        string FirstName,
        string MiddleName,
        string LastName,

        [Phone]
        string PhoneNumber,

        [EmailAddress]
        string EmailAddress,

        string LastReceiptNumber,
        string LastReceiptImage,
        int IdentificationTypeId,
        string IdentificationUniqueNumber,
        string IdentificationImage,
        string IdentificationImageOne,
        string? SelfieImage,
        string? PassportPicture,
        int ChannelId,
        string FirebaseId
        );

    
    

}

