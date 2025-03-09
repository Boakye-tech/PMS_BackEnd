using System;

namespace Modules.Customers.Application.Profiles
{
	public class CustomerDetailsProfile : Profile
    {
		public CustomerDetailsProfile()
		{
            CreateMap<CustomerDetails, CustomerDetailsReadDto>();
            CreateMap<CustomerDetailsCreateDto, CustomerDetails>();
        }
    }
}

