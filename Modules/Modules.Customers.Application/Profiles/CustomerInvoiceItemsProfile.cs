using System;
using Modules.Customers.Application.Dtos;

namespace Modules.Customers.Application.Profiles
{
	public class CustomerInvoiceItemsProfile : Profile
	{
		public CustomerInvoiceItemsProfile()
		{
            CreateMap<CustomerInvoiceItems, CustomerInvoiceItemsDto>();
            CreateMap<CustomerInvoiceItemsDto, CustomerInvoiceItems>();

        }
    }
}

