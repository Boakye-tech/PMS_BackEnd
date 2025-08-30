// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Documents.Infrastructure
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Documents.Infrastructure/Repositories/ApplicationFormResponseRepository.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 30/08/2025 4:48 AM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
namespace Modules.Documents.Infrastructure.Repositories
{
	public class ApplicationFormResponseRepository : Repository<ApplicationFormResponse>, IApplicationFormResponseRepository
    {
		public ApplicationFormResponseRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
		}
	}
}

