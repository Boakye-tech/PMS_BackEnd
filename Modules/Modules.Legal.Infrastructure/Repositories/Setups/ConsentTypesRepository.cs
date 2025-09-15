// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Legal.Infrastructure
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Legal.Infrastructure/Repositories/Setups/ConsentTypesRepository.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 15/09/2025 5:45 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;


namespace Modules.Legal.Infrastructure.Repositories.Setups
{
    public class ConsentTypesRepository : Repository<ConsentType>, IConsentTypesRepository
    {
        public ConsentTypesRepository(LegalDbContext dbContext) : base(dbContext)
        {
        }
    }
}



