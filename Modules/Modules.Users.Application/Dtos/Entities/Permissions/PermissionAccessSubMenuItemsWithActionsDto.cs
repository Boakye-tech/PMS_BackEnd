using System;

namespace Modules.Users.Application.Dtos.Entities.Permissions;

public record PermissionAccessSubMenuItemsWithActionsDto(string ItemName, PermissionsActionsDto permissionsActions);

public record PermissionAccessSubMenuItemsWithActionsReadDto(int PermissionsId, int SubPermissionsId, int SubPermissionsItemsId, string ItemName, PermissionsActionsDto permissionsActions);