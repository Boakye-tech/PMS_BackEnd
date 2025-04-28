// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


namespace Modules.Users.Infrastructure.Repositories.Entities
{
	public class DepartmentUnitRepository : Repository<DepartmentUnit>, IDepartmentUnitRepository
    {
		public DepartmentUnitRepository(UserDbContext dbContext) : base(dbContext)
		{
		}
	}
}

