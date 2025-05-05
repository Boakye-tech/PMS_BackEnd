// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


namespace Modules.Users.Application.Dtos.Entities.Menu
{
    //public record MenuActionDto(int actionId, string actionName);

    public record MenuActionsDto(int actionId, string actionName, string description);

    //public record MenusWithActionsDto(int MenuId, string MenuName, string SubmenuName, string NoAccess, string Create, string Read, string Update, string Delete, string Approve);

}

