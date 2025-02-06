using System;

namespace Modules.Users.Application.Dtos.Entities.Permissions;

public record PermissionAccessSubMenuItemsWithActionsDto(string ItemName, PermissionsActionsDto permissionsActions);

