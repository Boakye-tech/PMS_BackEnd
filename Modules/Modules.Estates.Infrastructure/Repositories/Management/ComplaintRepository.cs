// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


namespace Modules.Estates.Infrastructure.Repositories.Management
{
	public class ComplaintRepository : Repository<Complaint>, IComplaintRepository
	{
		public ComplaintRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
		}
	}
}

