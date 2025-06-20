// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


using System;
namespace Modules.Common.Infrastructure.Authentication
{
	public interface IUserContextService
	{
        string? GetUserId();
        bool? GetUserRole(string roleName);
        string? GetUserRole();
        string? GetAccessToken();

        string? UserCode();

        string? UserEmail();

        //string? UserFirebaseId();
    }
}

