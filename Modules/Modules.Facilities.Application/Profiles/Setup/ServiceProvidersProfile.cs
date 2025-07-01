// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Facilities.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Facilities.Application/Profiles/Setup/ServiceProvidersProfile.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/07/2025 10:02 AM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

namespace Modules.Facilities.Application.Profiles.Setup
{
    public class ServiceProvidersProfile : Profile
    {
        public ServiceProvidersProfile()
        {
            CreateMap<ServiceProviders, ServiceProvidersReadDto>();
            CreateMap<ServiceProvidersCreateDto, ServiceProviders>();
            CreateMap<ServiceProvidersUpdateDto, ServiceProviders>();
            CreateMap<ServiceProvidersDeleteDto, ServiceProviders>();
        }
    }
}