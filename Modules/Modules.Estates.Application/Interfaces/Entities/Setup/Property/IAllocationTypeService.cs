// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


namespace Modules.Estates.Application.Interfaces.Entities.Setup.Property;

public interface IAllocationTypeService
{
    Task<ReturnResponsesDto> CreateAllocationTypeAsync(AllocationTypeCreateDto values);
    Task<ReturnResponsesDto> UpdateAllocationTypeAsync(AllocationTypeUpdateDto values);
    Task<IEnumerable<AllocationTypeReadDto>> GetAllocationTypeAsync();
    Task<AllocationTypeReadDto> GetAllocationTypeAsync(int value);
    Task<AllocationTypeReadDto> GetAllocationTypeAsync(string value);
    Task<ReturnResponsesDto> DeleteAllocationType(int allocationTypeId);
}

