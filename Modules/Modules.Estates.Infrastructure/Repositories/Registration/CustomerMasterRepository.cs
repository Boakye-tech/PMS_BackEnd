using System;

namespace Modules.Estates.Infrastructure.Repositories.Registration
{
	public class CustomerMasterRepository : Repository<CustomerMaster>, ICustomerMasterRepository
    {
		public CustomerMasterRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
		}
	}
}

