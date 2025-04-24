using System;
namespace Modules.Customers.Infrastructure.Persistence.Repositories.Entities
{
	public class ComplaintStatusesRepository : Repository<ComplaintStatuses>, IComplaintStatusesRepository
    {
		public ComplaintStatusesRepository(ApplicationDBContext dBContext) : base(dBContext)
        {
		}
	}
}

