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
	public record UpdateUserDto(
        string UserId,
        string? MiddleName,
        [Phone]
        string? PhoneNumber,
        string? ProfilePicture
        
        );

    public record UpdateMobileTokenDto(string UserId, string? FirebaseToken);

}
