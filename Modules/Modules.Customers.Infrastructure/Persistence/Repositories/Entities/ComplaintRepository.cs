using System;
namespace Modules.Customers.Infrastructure.Persistence.Repositories.Entities
{
	public class ComplaintRepository: Repository<Complaint>, IComplaintRepository
    {
		public ComplaintRepository(ApplicationDBContext dbContext) : base(dbContext)
        {
		}
	}
}

