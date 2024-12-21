using System;
namespace Modules.Users.Application.Dtos.Administration
{
	public record UsersRolesDto();


    public record AssignUserRoleDto(string EmailAddress, string RoleName);
    public record UsersAndRolesReadDto(string userId, string userName, string roleId, string roleName);
}

