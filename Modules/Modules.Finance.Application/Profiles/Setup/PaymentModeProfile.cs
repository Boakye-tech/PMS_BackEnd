using System;
namespace Modules.Finance.Application.Profiles.Setup
{
	public class PaymentModeProfile : Profile
    {
		public PaymentModeProfile()
		{
            CreateMap<PaymentMode, PaymentModeReadDto>();
            CreateMap<PaymentModeCreateDto, PaymentMode>();
            CreateMap<PaymentModeUpdateDto, PaymentMode>();
            CreateMap<PaymentModeDeleteDto, PaymentMode>();

        }
    }
}

