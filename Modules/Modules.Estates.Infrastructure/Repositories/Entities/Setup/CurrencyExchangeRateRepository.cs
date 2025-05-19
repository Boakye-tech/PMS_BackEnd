// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Infrastructure
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Infrastructure/Repositories/Entities/Setup/CurrencyExchangeRateRepository.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 19/05/2025 2:20 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;

namespace Modules.Estates.Infrastructure.Repositories.Entities.Setup
{
	public class CurrencyExchangeRateRepository : Repository<CurrencyExchangeRate>, ICurrencyExchangeRateRepository
    {
		public CurrencyExchangeRateRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}

