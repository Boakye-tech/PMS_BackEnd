using System;

namespace Modules.Customers.Infrastructure.Persistence.Repositories.Entities
{
	public class CustomerDetailsRepository : Repository<CustomerDetails>, ICustomerDetailsRepository
    {
		public CustomerDetailsRepository(ApplicationDBContext dbContext) : base(dbContext)
        {
		}
	}
}

