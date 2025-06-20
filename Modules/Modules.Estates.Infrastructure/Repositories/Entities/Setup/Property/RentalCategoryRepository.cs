// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Infrastructure
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Infrastructure/Repositories/Entities/Setup/Property/RentalCategoryRepository.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 23/05/2025 11:55 AM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


namespace Modules.Estates.Infrastructure.Repositories.Entities.Setup.Property
{
	public class RentalCategoryRepository : Repository<RentalCategory>, IRentalCategoryRepository
    {
		public RentalCategoryRepository(ApplicationDbContext dbContext) : base(dbContext)
		{
		}
	}
}

