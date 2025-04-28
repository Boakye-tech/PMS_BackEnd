// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


namespace Modules.Estates.Infrastructure.Repositories.Entities.Setup.Customer
{
	public class ComplaintStatusesRepository : Repository<ComplaintStatuses>, IComplaintStatusesRepository
	{
		public ComplaintStatusesRepository(ApplicationDbContext dbContext) : base(dbContext)
		{
		}
	}
}

