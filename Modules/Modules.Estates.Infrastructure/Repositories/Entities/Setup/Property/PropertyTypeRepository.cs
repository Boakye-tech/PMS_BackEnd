// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Infrastructure
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Infrastructure/Repositories/Entities/Setup/Property/PropertyTypeRepository.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 24/07/2025 5:39 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
namespace Modules.Estates.Infrastructure.Repositories.Entities.Setup.Property
{
	public class PropertyTypeRepository : Repository<PropertyType>, IPropertyTypeRepository
    {
		public PropertyTypeRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
		}
	}
}

