using System;
using Modules.Estates.Application.DTO.Management.Customer;

namespace Modules.Estates.Application.Interfaces.Management.Customer
{
	public interface ICustomerMasterService
	{
        Task<ProspectiveCustomerResponseDto> CreateCustomer(ProspectiveCustomerDto values);
        Task<CompanyCustomerResponseDto> CreateCustomer(CompanyCustomerDto values);

        Task<IndividualResidentCustomerResponseDto> CreateCustomer(IndividualResidentCustomerDto values);
        Task<IndividualNonResidentCustomerResponseDto> CreateCustomer(IndividualNonResidentCustomerDto values);
        Task<IndividualExpatriateCustomerResponseDto> CreateCustomer(IndividualExpatriateCustomerDto values);

        Task<IEnumerable<AllocationTypeReadDto>> GetAllocationTypeAsync();

        //Task<AllocationTypeReadDto> UpdateAllocationTypeAsync(AllocationTypeUpdateDto values);
        //Task<AllocationTypeReadDto> GetAllocationTypeAsync(int value);

        Task<IEnumerable<CustomerListDto>> GetCustomerListAsync();

    }
}

