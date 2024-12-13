using System;

namespace Modules.Finance.Application.Profiles.Setup
{
	public class PaymentTypeProfile : Profile
    {
		public PaymentTypeProfile()
		{
			CreateMap<PaymentType, PaymentTypeReadDto>();
            CreateMap<PaymentTypeCreateDto, PaymentType>();
            CreateMap<PaymentTypeUpdateDto, PaymentType>();
            CreateMap<PaymentTypeDeleteDto, PaymentType>();

        }
    }
}

