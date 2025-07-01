// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Facilities.Infrastructure
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Facilities.Infrastructure/Repositories/Entities/Setup/ServiceProvidersRepository.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/07/2025 8:44 AM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

namespace Modules.Facilities.Infrastructure.Repositories.Entities.Setup
{
    public class ServiceProvidersRepository : Repository<ServiceProviders>, IServiceProvidersRepository
    {
        public ServiceProvidersRepository(FacilitiesDbContext dbContext) : base(dbContext)
        {
        }
    }
}