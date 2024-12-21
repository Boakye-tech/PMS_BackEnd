using System;
namespace Modules.Users.Application.Dtos.Administration
{
	public record RolesDto(string RoleName);
    public record RolesUpdateDto(string RoleId, string RoleName);
    public record RolesDeleteDto(string RoleId);

}

