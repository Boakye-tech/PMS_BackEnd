// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 19/09/2025 4:50 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

using Modules.Finance.Application.Dtos.Setup;
using Modules.Finance.Domain.Entities.Setup;

namespace Modules.Finance.Application.Profiles.Setup
{
    public class DebtorTypesProfile : Profile
    {
        public DebtorTypesProfile()
        {
            CreateMap<DebtorTypes, DebtorTypesReadDto>();
            CreateMap<DebtorTypesCreateDto, DebtorTypes>();
            CreateMap<DebtorTypesUpdateDto, DebtorTypes>();
            CreateMap<DebtorTypesDeleteDto, DebtorTypes>();

            //CreateMap<DebtorTypes, DebtorTypeReadDto>();

            CreateMap<DebtorTypes, DebtorTypeReadDto>()
                .ForMember(dest => dest.GroupNumbers, opt => opt.MapFrom(src => src.DebtorGroups));

        }
    }

}
