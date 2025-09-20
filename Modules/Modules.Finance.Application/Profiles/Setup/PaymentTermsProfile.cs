// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 20/09/2025 4:50 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

using Modules.Finance.Application.Dtos.Setup;
using Modules.Finance.Domain.Entities.Setup;

namespace Modules.Finance.Application.Profiles.Setup
{
    public class PaymentTermsProfile : Profile
    {
        public PaymentTermsProfile()
        {
            CreateMap<PaymentTerms, PaymentTermsReadDto>();
            CreateMap<PaymentTermsCreateDto, PaymentTerms>();
            CreateMap<PaymentTermsUpdateDto, PaymentTerms>();
            CreateMap<PaymentTermsDeleteDto, PaymentTerms>();
        }
    }
}
