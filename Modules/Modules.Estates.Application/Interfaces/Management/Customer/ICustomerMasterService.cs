using System;
namespace Modules.Estates.Application.Interfaces.Management.Customer
{
	public interface ICustomerMasterService
	{
        Task<AllocationTypeReadDto> CreateCustomer(AllocationTypeCreateDto values);
        //Task<AllocationTypeReadDto> UpdateAllocationTypeAsync(AllocationTypeUpdateDto values);
        Task<IEnumerable<AllocationTypeReadDto>> GetAllocationTypeAsync();
        //Task<AllocationTypeReadDto> GetAllocationTypeAsync(int value);
        //Task<AllocationTypeReadDto> GetAllocationTypeAsync(string value);

    }
}

