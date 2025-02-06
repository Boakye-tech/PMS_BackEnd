using System;

namespace Modules.Users.Application.Dtos.Entities.Permissions;

public record PermissionAccessSubMenusWithActionsDto(string sectionName, PermissionsActionsDto permissionsActions, List<PermissionAccessSubMenuItemsWithActionsDto> items);