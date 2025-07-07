// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Finance.Infrastructure
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Finance.Infrastructure/Repositories/Entities/Setup/DepartmentRepository.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 07/07/2025 11:04 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
namespace Modules.Finance.Infrastructure.Repositories.Entities.Setup
{
	public class DepartmentRepository : Repository<Department>, IDepartmentRepository
    {
		public DepartmentRepository(FinanceDbContext dbContext) : base(dbContext)
        {
		}
	}
}

