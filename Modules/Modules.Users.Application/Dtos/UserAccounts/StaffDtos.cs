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
	public record StaffRegistrationRequestDto(
        string StaffIdentificationNumber,
        int DepartmentId,
        int UnitId,
        string FirstName,
        string MiddleName,
        string LastName,

        [EmailAddress]
        string EmailAddress,

        [EmailAddress]
        string UserName,

        [Phone]
        string PhoneNumber,
        int ChannelId,
        //DateTime RegistrationDate,
        //int Status,
        string? ProfilePicture
        //string Password,
        //string ConfirmPassword
        );


}
