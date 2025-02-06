using System;
namespace Modules.Users.Application.Dtos.Entities.Menu;

public record AccessSubMenusWithActionsDto(string subMenuName, bool isOpen, PermissionsActionsDto permissionsActions, List<AccessSubMenuItemsWithActionsDto> items);

