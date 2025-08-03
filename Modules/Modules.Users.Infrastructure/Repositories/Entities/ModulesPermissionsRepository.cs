// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Users.Infrastructure
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Users.Infrastructure/Repositories/Entities/ModulesPermissionsRepository.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 03/08/2025 8:11 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
namespace Modules.Users.Infrastructure.Repositories.Entities
{
	public class ModulesPermissionsRepository : Repository<ModulesPermissions>, IModulesPermissionsRepository
    {
		public ModulesPermissionsRepository(UserDbContext dbContext) : base(dbContext)
		{
		}
	}
}

