// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Infrastructure
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Infrastructure/Repositories/Management/PropertyMasterViewRepository.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 17/08/2025 12:58 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
using Modules.Estates.Domain.Entities.Registration.ViewModels;

namespace Modules.Estates.Infrastructure.Repositories.Management
{
	public class PropertyMasterViewRepository : Repository<PropertyMasterView>, IPropertyMasterViewRepository
    {
		public PropertyMasterViewRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
		}
	}
}

