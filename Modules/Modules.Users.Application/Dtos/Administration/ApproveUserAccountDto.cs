// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


namespace Modules.Users.Application.Dtos.Administration
{
	public record ApproveUserAccountDto(string RoleId, string UserId, string ApprovedBy); 
    public record DisapprovedUserAccountDto(string UserId, string DisapprovedBy, string DisapprovedReasons); 

}

