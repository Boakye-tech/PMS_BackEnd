// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Infrastructure
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Infrastructure/Repositories/Entities/Setup/Property/SchemeTypeRepository.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 15/06/2025 12:17 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
namespace Modules.Estates.Infrastructure.Repositories.Entities.Setup.Property
{
	public class SchemeTypeRepository : Repository<SchemeType>, ISchemeTypeRepository
    {
        public SchemeTypeRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}

