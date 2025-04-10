using System;
namespace Modules.Customers.Infrastructure.Persistence.Repositories.Entities
{
	public class ComplaintTypeRepository : Repository<ComplaintType>, IComplaintTypeRepository
    {
		public ComplaintTypeRepository(ApplicationDBContext dbContext) : base(dbContext)
        {
		}
	}
}

