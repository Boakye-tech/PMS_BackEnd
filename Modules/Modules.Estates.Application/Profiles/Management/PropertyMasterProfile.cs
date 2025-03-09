using System;
using Modules.Estates.Application.DTO.Management;
using Modules.Estates.Application.DTO.Management.Property;
using Modules.Estates.Domain.Entities.Registration;

namespace Modules.Estates.Application.Profiles.Management
{
	public class PropertyMasterProfile : Profile
	{
		public PropertyMasterProfile()
		{
            CreateMap<PropertyMaster, PropertyMasterCreatePlotResponseDto>();
            CreateMap<PropertyMasterCreatePlotDto, PropertyMaster>();


            CreateMap<PropertyMasterUpdateDto, PropertyMaster>();
            CreateMap<PropertyMasterUpdateLeaseDetailsDto, PropertyMaster>();

        }
    }
}

