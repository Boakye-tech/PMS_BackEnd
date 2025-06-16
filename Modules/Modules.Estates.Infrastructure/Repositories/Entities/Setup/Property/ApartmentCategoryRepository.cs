// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Infrastructure
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Infrastructure/Repositories/Entities/Setup/Property/ApartmentCategoryRepository.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 16/06/2025 5:33 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/



namespace Modules.Estates.Infrastructure.Repositories.Entities.Setup.Property;

public class ApartmentCategoryRepository : Repository<ApartmentCategory>, IApartmentCategoryRepository
{
	public ApartmentCategoryRepository(ApplicationDbContext dbContext) : base(dbContext)
	{
	}
}

