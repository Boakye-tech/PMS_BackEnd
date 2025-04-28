// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

namespace Modules.Estates.Application.Interfaces.Management.Property
{
	public interface IPropertyMasterService
	{
        Task<PropertyMasterCreatePlotResponseDto> CreateProperty(PropertyMasterCreatePlotDto values);
        //Task<AllocationTypeReadDto> UpdateAllocationTypeAsync(AllocationTypeUpdateDto values);
        Task<IEnumerable<PropertyMasterDto>> GetProperties(int localityId);
        //Task<AllocationTypeReadDto> GetAllocationTypeAsync(int value);
        //Task<AllocationTypeReadDto> GetAllocationTypeAsync(string value);

    }
}

