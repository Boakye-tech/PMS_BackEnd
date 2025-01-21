using System;
using Modules.Customers.Application.Dtos;

namespace Modules.Customers.Application.Profiles
{
	public class CustomerInvoiceProfile : Profile
	{
		public CustomerInvoiceProfile()
		{
            CreateMap<CustomerInvoice, CustomerInvoiceDto>();
            CreateMap<CustomerInvoiceDto, CustomerInvoice>();

        }
    }
}

