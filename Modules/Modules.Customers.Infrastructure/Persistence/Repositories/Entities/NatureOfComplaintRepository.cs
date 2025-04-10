using System;
namespace Modules.Customers.Infrastructure.Persistence.Repositories.Entities
{
	public class NatureOfComplaintRepository: Repository<NatureOfComplaint>, INatureOfComplaintRepository
    {
		public NatureOfComplaintRepository(ApplicationDBContext dbContext) : base(dbContext)
        {
		}
	}
}

