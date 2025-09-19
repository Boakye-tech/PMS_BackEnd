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
    public class RentalTypesProfile : Profile
    {
        public RentalTypesProfile()
        {
            CreateMap<RentalTypes, RentalTypesReadDto>();
            CreateMap<RentalTypesCreateDto, RentalTypes>();
            CreateMap<RentalTypesUpdateDto, RentalTypes>();
            CreateMap<RentalTypesDeleteDto, RentalTypes>();

            //CreateMap<RentalTypes, RentalAndDebtorTypesDto>();

            CreateMap<RentalTypes, RentalAndDebtorTypesDto>()
                .ForCtorParam("RentalTypes", opt => opt.MapFrom(src => src))
                .ForCtorParam("DebtorTypes", opt => opt.MapFrom(src => src.DebtorTypes));

        }
    }
}
