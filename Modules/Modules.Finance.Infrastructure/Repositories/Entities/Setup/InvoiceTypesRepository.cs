using System;
namespace Modules.Finance.Infrastructure.Repositories.Entities.Setup
{
	public class InvoiceTypesRepository : Repository<InvoiceTypes>, IInvoiceTypesRepository
	{
		public InvoiceTypesRepository(FinanceDbContext dbContext) : base(dbContext)
        {
		}
	}
}

