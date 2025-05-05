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
namespace Modules.Customers.Infrastructure.Persistence.Repositories.Entities
{
	public class CustomerInvoiceItemsRepository : Repository<CustomerInvoiceItems>, ICustomerInvoiceItemsRepository
    {
		public CustomerInvoiceItemsRepository(ApplicationDBContext dbContext) : base(dbContext)
        {
		}
	}
}

