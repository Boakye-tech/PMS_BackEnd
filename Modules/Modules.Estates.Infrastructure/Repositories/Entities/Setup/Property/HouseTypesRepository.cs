// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Infrastructure
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Infrastructure/Repositories/Entities/Setup/Property/HouseTypesRepository.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 23/05/2025 11:57 AM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
namespace Modules.Estates.Infrastructure.Repositories.Entities.Setup.Property
{
	public class HouseTypesRepository : Repository<HouseTypes>, IHouseTypesRepository
    {
		public HouseTypesRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
		}
	}
}

