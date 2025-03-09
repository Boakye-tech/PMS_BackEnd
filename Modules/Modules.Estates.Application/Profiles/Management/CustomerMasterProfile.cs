using System;
using Modules.Estates.Application.DTO.Management;
using Modules.Estates.Domain.Entities.Registration;

namespace Modules.Estates.Application.Profiles.Management
{
	public class CustomerMasterProfile : Profile
	{
		public CustomerMasterProfile()
		{
            CreateMap<CustomerMaster, CustomerMasterDto>();

            CreateMap<CustomerMasterCreateDto, CustomerMaster>();

            CreateMap<CustomerMasterUpdateDto, CustomerMaster>();
            CreateMap<CustomerMasterDeleteDto, CustomerMaster>();

        }
    }
}

