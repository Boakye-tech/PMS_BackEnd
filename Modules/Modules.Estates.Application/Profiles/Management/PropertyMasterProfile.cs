using System;
using Modules.Estates.Application.DTO.Management;
using Modules.Estates.Domain.Entities.Registration;

namespace Modules.Estates.Application.Profiles.Management
{
	public class PropertyMasterProfile : Profile
	{
		public PropertyMasterProfile()
		{
            //CreateMap<PropertyMaster, PropertyMasterReadDto>();

            CreateMap<PropertyMasterCreatePlotDto, PropertyMaster>();

            CreateMap<PropertyMasterUpdateDto, PropertyMaster>();
            CreateMap<PropertyMasterUpdateLeaseDetailsDto, PropertyMaster>();

        }
    }
}

