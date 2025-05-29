// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


namespace Modules.Users.Application.Dtos.Administration
{
	public record UsersRolesDto();


    public record AssignUserRoleDto(string EmailAddress, string RoleName);
    public record UsersAndRolesReadDto(string userId, string userName, string roleId, string roleName);

    public record UsersPerRole(string userId, string fullName, string phoneNumber, string emailAddress);
}

