// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Finance.Infrastructure
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Finance.Infrastructure/Repositories/Entities/Setup/PenaltyRuleRepository.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 22/09/2025 3:01 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
namespace Modules.Finance.Infrastructure.Repositories.Entities.Setup
{
	public class PenaltyRuleRepository : Repository<PenaltyRule>, IPenaltyRuleRepository
	{
		public PenaltyRuleRepository(FinanceDbContext dbContext): base(dbContext)
		{
		}
	}
}

