// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Customers.Infrastructure
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Customers.Infrastructure/Persistence/Repositories/Entities/CustomerOpeningBalancesRepository.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 28/06/2025 8:21 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;


namespace Modules.Customers.Infrastructure.Persistence.Repositories.Entities
{
	public class CustomerOpeningBalancesRepository : Repository<CustomerOpeningBalances>, ICustomerOpeningBalancesRepository
    {
		public CustomerOpeningBalancesRepository(ApplicationDBContext dbContext) : base(dbContext)
        {
		}
	}
}

