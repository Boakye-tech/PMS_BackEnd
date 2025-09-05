// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Documents.Infrastructure
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Documents.Infrastructure/Repositories/FormSectionsRepository.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 05/09/2025 8:21 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
namespace Modules.Documents.Infrastructure.Repositories
{
	public class FormSectionsRepository :  Repository<FormSections>,  IFormSectionsRepository
    {
		public FormSectionsRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
		}
	}
}

