using System;
using Modules.Users.Application.Dtos.Entities.Menu;

namespace Modules.Users.Application.Dtos.Administration
{
	public record RolesPermissionsDto
	{
		public string? RoldId { get; set; }
		public IEnumerable<MenusWithActionsDto>? Permissions { get; set; }
	}

    //public record MenusWithActionsDto(int MenuId, string MenuName, string SubmenuName, string NoAccess, string Create, string Read, string Update, string Delete, string Approve);
}

