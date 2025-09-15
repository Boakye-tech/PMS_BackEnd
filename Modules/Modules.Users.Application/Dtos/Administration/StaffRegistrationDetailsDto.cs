// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Users.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Users.Application/Dtos/Administration/StaffRegistrationDetailsDto.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 15/09/2025 12:46 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
using System.ComponentModel.DataAnnotations;

namespace Modules.Users.Application.Dtos.Administration
{
    public record StaffRegistrationDetailsDto(
        string userId,
        string StaffIdentificationNumber,
        string StaffFullName,
        string Department,
        string? Unit,
        string EmailAddress,
        string PhoneNumber,
        string? ProfilePicture,
        string? StaffRole,
        string  UserName,
        DateTime RegistrationDate,
        string? Status
        );
}

