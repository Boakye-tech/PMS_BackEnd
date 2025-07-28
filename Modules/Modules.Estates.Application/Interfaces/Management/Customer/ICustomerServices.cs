// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Presentation
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/Interfaces/Management/Customer/ICustomerServices.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


namespace Modules.Estates.Application.Interfaces.Management.Customer
{
	public interface ICustomerServices
	{
        Task<int> StopCustomerDebitAsync(StopDebitRequestDto values);
        Task<int> StartCustomerDebitAsync(StopDebitRequestDto values);
    }
}

