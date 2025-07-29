// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Infrastructure
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Infrastructure/Repositories/Management/PropertyLeaseDetailsRepository.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 29/07/2025 11:00 AM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
namespace Modules.Estates.Infrastructure.Repositories.Management
{
	public class PropertyLeaseDetailsRepository: Repository<PropertyLeaseDetails>, IPropertyLeaseDetailsRepository
	{
		public PropertyLeaseDetailsRepository(ApplicationDbContext dbContext) : base(dbContext)
		{
		}
	}
}

