// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Users.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Users.Application/Dtos/Administration/CustomerRegistrationDetailsDto.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 15/09/2025 11:31 AM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
namespace Modules.Users.Application.Dtos.Administration
{
    public record CustomerRegistrationDetailsDto(
       string UserId,
       string CustomerCode, 
       string CustomerName,
       string EmailAddress,
       string PhoneNumber,
       string? LastReceiptNumber,
       string? LastReceiptImage,
       string? IdentificationType, 
       string? IdentificationUniqueNumber,
       string? IdentificationImage,
       string? IdentificationImageOne,
       string? SelfieImage,
       string? PassportPicture,
       DateTime RegistrationDate,
       string Channel,
        string Status
       );
}

