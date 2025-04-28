// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/03/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


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

