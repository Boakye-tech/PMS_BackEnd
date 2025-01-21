using System;
using Modules.Customers.Application.Dtos;

namespace Modules.Customers.Application.Profiles
{
	public class CustomerPaymentsProfile : Profile
	{
		public CustomerPaymentsProfile()
		{
            CreateMap<CustomerPayments, CustomerPaymentsDto>();
            CreateMap<CustomerPaymentsDto, CustomerPayments>();

        }
    }
}

