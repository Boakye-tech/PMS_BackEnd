using System;
namespace Modules.Customers.Infrastructure.Persistence.Repositories.Entities
{
	public class CustomerInvoiceRepository : Repository<CustomerInvoice>, ICustomerInvoiceRepository
    {
		public CustomerInvoiceRepository(ApplicationDBContext dbContext) : base(dbContext)
        {
		}
	}
}

