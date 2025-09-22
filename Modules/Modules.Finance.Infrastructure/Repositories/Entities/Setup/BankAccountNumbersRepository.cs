// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Finance.Infrastructure
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Finance.Infrastructure/Repositories/Entities/Setup/BankAccountNumbersRepository.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 22/09/2025 9:36 AM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
namespace Modules.Finance.Infrastructure.Repositories.Entities.Setup
{
	public class BankAccountNumbersRepository : Repository<BankAccountNumbers>, IBankAccountNumbersRepository
    {
		public BankAccountNumbersRepository(FinanceDbContext dbContext) : base(dbContext)
        {
		}
	}
}

