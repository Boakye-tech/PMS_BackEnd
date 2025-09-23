// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 20/09/2025 5:50 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

using Modules.Estates.Application.DTO.Setup.Customer;
using Modules.Estates.Domain.Entities.Setup.Customer;

namespace Modules.Estates.Application.Profiles.Customer;

public class ProductAwarenessSourcesProfile : Profile
{
    public ProductAwarenessSourcesProfile()
    {
        CreateMap<ProductAwarenessSources, ProductAwarenessSourcesReadDto>();
        CreateMap<ProductAwarenessSourcesCreateDto, ProductAwarenessSources>();
        CreateMap<ProductAwarenessSourcesUpdateDto, ProductAwarenessSources>();
        CreateMap<ProductAwarenessSourcesDeleteDto, ProductAwarenessSources>();
    }
}
