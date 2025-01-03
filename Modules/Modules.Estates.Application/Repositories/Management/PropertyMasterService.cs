using System;
using Modules.Estates.Application.DTO.Management;
using Modules.Estates.Application.Interfaces.Management.Property;
using Modules.Estates.Domain.Entities.Registration;

namespace Modules.Estates.Application.Repositories.Management
{
	public class PropertyMasterService : IPropertyMasterService
	{
		public PropertyMasterService()
		{
		}

        public Task<PropertyMasterDto> CreateProperty(PropertyMasterCreatePlotDto values)
        {
            //throw new NotImplementedException();

            //PropertyMaster property = PropertyMaster.Create(values.PropertyMasterId, values.PropertyTypeId, values.LandUseId)
        }

        public Task<IEnumerable<PropertyMasterDto>> GetProperties(int localityId)
        {
            throw new NotImplementedException();
        }
    }
}

