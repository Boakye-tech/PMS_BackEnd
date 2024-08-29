// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Documents.Infrastructure
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Documents.Infrastructure/Repositories/FormTemplatesRepository.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 29/08/2025 1:54 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;


namespace Modules.Documents.Infrastructure.Repositories
{
	public class FormTemplatesRepository : Repository<FormTemplates>, IFormTemplatesRepository
	{
		public FormTemplatesRepository(ApplicationDbContext dbContext) : base(dbContext)
		{
		}
	}
}

