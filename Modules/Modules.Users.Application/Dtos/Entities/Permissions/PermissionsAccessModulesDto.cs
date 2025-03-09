using System;
namespace Modules.Users.Application.Dtos.Entities.Permissions;

public record PermissionsAccessModulesDto(string RoleId, List<PermissionAccessMenusWithActionsDto> permissionsAccessModules);

public record PermissionsAccessModulesReadDto(string RoleId, List<PermissionAccessMenusWithActionsReadDto> permissionsAccessModules);

