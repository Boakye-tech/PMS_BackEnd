// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/



namespace Modules.Users.Application.Dtos.Entities.Permissions;

public record PermissionAccessSubMenusWithActionsDto(string sectionName, PermissionsActionsDto permissionsActions, List<PermissionAccessSubMenuItemsWithActionsDto> items);

public record PermissionAccessSubMenusWithActionsReadDto(int PermissionsId, int SubPermissionsId, string sectionName, PermissionsActionsDto permissionsActions, List<PermissionAccessSubMenuItemsWithActionsReadDto> items);

