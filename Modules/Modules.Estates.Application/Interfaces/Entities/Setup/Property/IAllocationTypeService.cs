namespace Modules.Estates.Application.Interfaces.Entities.Setup.Property;

public interface IAllocationTypeService
{
    Task<AllocationTypeReadDto> AddAllocationTypeAsync(AllocationTypeCreateDto values);
    Task<AllocationTypeReadDto> UpdateAllocationTypeAsync(AllocationTypeUpdateDto values);
    Task<IEnumerable<AllocationTypeReadDto>> GetAllocationTypeAsync();
    Task<AllocationTypeReadDto> GetAllocationTypeAsync(int value);
    Task<AllocationTypeReadDto> GetAllocationTypeAsync(string value);
}

