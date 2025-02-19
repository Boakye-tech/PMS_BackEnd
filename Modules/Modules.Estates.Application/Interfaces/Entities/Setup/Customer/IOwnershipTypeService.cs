using System;
namespace Modules.Estates.Application.Interfaces.Entities.Setup.Customer
{
	public interface IOwnershipTypeService
	{
        Task<OwnershipTypeReadDto> AddOwnershipTypeAsync(OwnershipTypeCreateDto values);
        Task<OwnershipTypeReadDto> UpdateOwnershipTypeAsync(OwnershipTypeUpdateDto values);
        Task<IEnumerable<OwnershipTypeReadDto>> GetOwnershipTypeAsync();

        Task<OwnershipTypeReadDto> GetOwnershipTypeAsync(int value);
        Task<OwnershipTypeReadDto> GetOwnershipTypeAsync(string value);

        Task<string> DeleteOwnershipTypeAsync(int value);

    }
}

