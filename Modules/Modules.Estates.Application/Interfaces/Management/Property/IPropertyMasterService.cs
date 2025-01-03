using System;
using Modules.Estates.Application.DTO.Management;
using Modules.Estates.Domain.Entities.Registration;

namespace Modules.Estates.Application.Interfaces.Management.Property
{
	public interface IPropertyMasterService
	{
        Task<PropertyMasterDto> CreateProperty(PropertyMasterCreatePlotDto values);
        //Task<AllocationTypeReadDto> UpdateAllocationTypeAsync(AllocationTypeUpdateDto values);
        Task<IEnumerable<PropertyMasterDto>> GetProperties(int localityId);
        //Task<AllocationTypeReadDto> GetAllocationTypeAsync(int value);
        //Task<AllocationTypeReadDto> GetAllocationTypeAsync(string value);

    }
}

