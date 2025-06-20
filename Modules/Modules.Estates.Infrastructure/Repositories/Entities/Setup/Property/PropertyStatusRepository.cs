// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Infrastructure
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Infrastructure/Repositories/Entities/Setup/Property/PropertyStatusRepository.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 15/05/2025 8:29 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
namespace Modules.Estates.Infrastructure.Repositories.Entities.Setup.Property
{
	public class PropertyStatusRepository : Repository<PropertyStatus>, IPropertyStatusRepository
    {
		public PropertyStatusRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}

