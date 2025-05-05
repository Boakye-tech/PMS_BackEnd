// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

using System.ComponentModel.DataAnnotations;

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

