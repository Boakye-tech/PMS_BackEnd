using System;
namespace Modules.Users.Application.Dtos.Administration
{
	public record RolesDto(string RoleId, string RoleName, string CreatedBy, DateTime CreatedOn, string ApprovedBy, DateTime ApprovedOn, short Status);
    public record RolesCreateDto(string RoleId, string RoleName, string CreatedBy);
    public record RolesUpdateDto(string RoleId, string RoleName, string ModifiedBy);
    public record RolesDeleteDto(string RoleId);

}

