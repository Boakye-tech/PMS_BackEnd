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
	public record SubMenusDto(int menuId, int subMenuId, string subMenuName, string description, string createdBy, bool IsOpen);
    public record SubMenusCreateDto(int menuId, int subMenuId, string subMenuName, string description, string createdBy, bool IsOpen);
    public record SubMenusUpdateDto(int subMenuId, string subMenuName, string description, string modifiedBy, bool IsOpen);
    public record SubMenusUpdateResponseDto(int menuId, int subMenuId, string subMenuName, string description, string modifiedBy, bool IsOpen);

    public record SubMenuDeleteDto(int subMenuId);

}

