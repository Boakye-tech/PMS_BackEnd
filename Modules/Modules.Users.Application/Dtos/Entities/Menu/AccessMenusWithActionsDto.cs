using System;
namespace Modules.Users.Application.Dtos.Entities.Menu;

public record AccessMenusWithActionsDto(string menuName, bool isOpen, PermissionsActionsDto permissionsActions, List<AccessSubMenusWithActionsDto> sections);
