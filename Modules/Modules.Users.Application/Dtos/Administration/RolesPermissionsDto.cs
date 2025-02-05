using System;
using Modules.Users.Application.Dtos.Entities.Menu;

namespace Modules.Users.Application.Dtos.Administration
{
	public record RolesPermissionsDto
	{
		public string? RoleName { get; set; }
		public IEnumerable<RolesWithActionsDto>? Permissions { get; set; }
	}

    public record RolesWithActionsDto(int MenuId, int SubMenuId, int SubMenuItemsId, bool NoAccess, bool Create, bool Read, bool Update, bool Delete, bool Approve);

    public record AssignPermissionToRoleResponseDto(string response);
}

