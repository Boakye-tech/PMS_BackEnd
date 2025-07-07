// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Finance.Infrastructure
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Finance.Infrastructure/Repositories/Entities/Setup/DepartmentUnitRepository.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 07/07/2025 11:05 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
namespace Modules.Finance.Infrastructure.Repositories.Entities.Setup
{
	public class DepartmentUnitRepository : Repository<DepartmentUnit>, IDepartmentUnitRepository
    {
		public DepartmentUnitRepository(FinanceDbContext dbContext) : base(dbContext)
        {
		}
	}
}

