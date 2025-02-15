using System;
namespace Modules.Users.Application.Dtos.Entities.Permissions;

public record PermissionAccessMenusWithActionsDto(string menuName, PermissionsActionsDto permissionsActions, List<PermissionAccessSubMenusWithActionsDto> sections);

public record PermissionAccessMenusWithActionsReadDto(int PermissionsId, string menuName, PermissionsActionsDto permissionsActions, List<PermissionAccessSubMenusWithActionsReadDto> sections);