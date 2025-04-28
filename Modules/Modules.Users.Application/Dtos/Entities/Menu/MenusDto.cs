// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


namespace Modules.Users.Application.Dtos.Entities.Menu;

public record MenusDto(int menuId, string menuName, string description, string createdBy, bool IsOpen);
public record MenusUpdateDto(int menuId, string menuName, string description, string modifiedBy, bool IsOpen);

public record MenusDeleteDto(int menuId);



//public record MenusDto(int menuId, string menuName, string description, bool IsOpen);