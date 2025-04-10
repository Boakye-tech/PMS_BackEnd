using System;

namespace Modules.Customers.Application.Profiles
{
	public class ComplaintTypeProfile : Profile
	{
		public ComplaintTypeProfile()
		{
			CreateMap<ComplaintType, ComplaintTypeDto>();
            CreateMap<ComplaintType, ComplaintTypeDto>();

        }
    }
}

