// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Customers.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Customers.Application/Interfaces/ICustomerOpeningBalancesService.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 28/06/2025 8:51 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
namespace Modules.Customers.Application.Interfaces
{
	public interface ICustomerOpeningBalancesService
	{
        Task<IEnumerable<CustomerOpeningBalancesDto>> GetCustomerOpeningBalances();


        Task<IEnumerable<CustomerOpeningBalancesDto>> GetCustomerOpeningBalances(string customerCode, string propertyNumber, int year);

        Task<GenericResponseDto> AddCustomerOpeningBalance(CustomerOpeningBalancesDto values);
        Task<GenericResponseDto> UpdateCustomerOpeningBalance(CustomerOpeningBalancesDto values);
        Task<GenericResponseDto> DeleteCustomerOpeningBalance(int complaintTypeid);

    }
}

