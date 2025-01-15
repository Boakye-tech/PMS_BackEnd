using System;
namespace Modules.Finance.Application.Profiles.Setup
{
	public class InvoiceTypesProfile : Profile
	{
		public InvoiceTypesProfile()
		{
            CreateMap<InvoiceTypes, InvoiceTypesReadDto>();
            CreateMap<InvoiceTypesCreateDto, InvoiceTypes>();
            CreateMap<InvoiceTypesUpdateDto, InvoiceTypes>();
            CreateMap<InvoiceTypesDeleteDto, InvoiceTypes>();

        }
    }
}

