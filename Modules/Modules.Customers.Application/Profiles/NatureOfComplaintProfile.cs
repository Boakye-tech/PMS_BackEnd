using System;

namespace Modules.Customers.Application.Profiles
{
	public class NatureOfComplaintProfile : Profile
	{
		public NatureOfComplaintProfile()
		{
			CreateMap<NatureOfComplaint, NatureOfComplaintDto>();
            CreateMap<NatureOfComplaintDto, NatureOfComplaint>();
        }
	}
}

