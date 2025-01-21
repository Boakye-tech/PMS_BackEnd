using System;
using Modules.Customers.Application.Dtos;

namespace Modules.Customers.Application.Profiles
{
	public class CustomerTransactionsProfile : Profile
	{
		public CustomerTransactionsProfile()
		{
            CreateMap<CustomerTransactions, CustomerTransactionsDto>();
            CreateMap<CustomerTransactionsDto, CustomerTransactions>();

        }
    }
}

