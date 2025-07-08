// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Users.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Users.Application/Interfaces/IModulesServices.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


namespace Modules.Users.Application.Interfaces
{
	public interface IModulesService
    {
        //Task SendTokenViaNotification(ApplicationIdentityUser user, string temp_password);

        Task<bool> SendTemporaryPasswordEmailNotification(ApplicationIdentityUser user, string temp_password);

        Task<bool> SendDepartmentDetailsAsync(DepartmentCreateDto payload);
        Task<bool> SendModifiedDepartmentDetailsAsync(DepartmentUpdateDto payload);

        Task<bool> SendDepartmentUnitDetailsAsync(DepartmentUnitCreateDto payload);
        Task<bool> SendModifiedDepartmentUnitDetailsAsync(DepartmentUnitUpdateDto payload);


    }
}

