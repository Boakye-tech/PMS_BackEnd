using System;
using Modules.Users.Application.Dtos.Entities.Menu;

namespace Modules.Users.Application.Dtos.Administration
{
	public record RolesPermissionsDto
	{
		public string? RoleName { get; set; }
		public IEnumerable<RolesWithActionsDto>? Permissions { get; set; }
	}

    public record RolesWithActionsDto(int MenuId, int SubMenuId, string NoAccess, string Create, string Read, string Update, string Delete, string Approve);

    public record AssignPermissionToRoleResponseDto(string response);
}

