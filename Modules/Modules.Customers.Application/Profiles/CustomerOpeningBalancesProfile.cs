// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Customers.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Customers.Application/Profiles/CustomerOpeningBalancesProfile.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 28/06/2025 8:55 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
namespace Modules.Customers.Application.Profiles
{
	public class CustomerOpeningBalancesProfile : Profile
	{
		public CustomerOpeningBalancesProfile()
		{
            CreateMap<CustomerOpeningBalancesDto, CustomerOpeningBalances>();
            CreateMap<CustomerOpeningBalances, CustomerOpeningBalancesDto>();

        }
    }
}

