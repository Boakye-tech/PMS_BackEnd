using System;
namespace Modules.Users.Application.Dtos.Entities.Menu
{
    //public record MenuActionDto(int actionId, string actionName);

    public record MenuActionsDto(int actionId, string actionName, string description);

    //public record MenusWithActionsDto(int MenuId, string MenuName, string SubmenuName, string NoAccess, string Create, string Read, string Update, string Delete, string Approve);

}

