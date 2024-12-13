using System;
namespace Modules.Finance.Application.Profiles.Setup
{
	public class PaypointProfile : Profile
	{
		public PaypointProfile()
		{
			CreateMap<Paypoints, PaypointsReadDto>();
			CreateMap<PaypointsCreateDto, Paypoints>();
			CreateMap<PaypointsUpdateDto, Paypoints>();
			CreateMap<PaypointsDeleteDto, Paypoints>();
		}
	}
}

