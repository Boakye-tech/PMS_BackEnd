using System;
using Modules.Estates.Application.DTO.Management;
using Modules.Estates.Application.DTO.Management.Customer;

namespace Modules.Estates.Application.Interfaces.Management.Customer
{
	public interface ICustomerMasterService
	{
        Task<CustomerRegistrationResponseDto> CreateCustomer(ProspectiveCustomerDto values);
        Task<CustomerRegistrationResponseDto> CreateCustomer(CreateCompanyCustomerDto values);
        Task<CustomerRegistrationResponseDto> CreateCustomer(IndividualResidentCustomerDto values);
        Task<CustomerRegistrationResponseDto> CreateCustomer(JointOwnershipCustomerDto values);
        Task<CustomerRegistrationResponseDto> CreateCustomer(MultiOwnershipCustomerDto values);

        Task<CustomerMasterDto> GetCustomer(string customerCode);

        Task<ProspectiveCustomerResponseDto> GetProspectiveCustomerDetails(string customerCode);
        Task<CompanyCustomerResponseDto> GetCompanyCustomerDetails(string customerCode);
        Task<IndividualResidentCustomerResponseDto> GetIndividualCustomerDetails(string customerCode);
        Task<JointOwnershipCustomerResponseDto> GetJointCustomerDetails(string customerCode);
        Task<MultiOwnershipCustomerResponseDto> GetMultiCustomerDetails(string customerCode);

        Task<IEnumerable<CustomerListDto>> GetCustomerListAsync();
        Task<IEnumerable<CustomerListDto>> GetPendingCustomerListAsync();

        //Task<CustomerRegistrationResponseDto> UpdateCustomer(ProspectiveCustomerDto values);
        Task<CustomerRegistrationResponseDto> UpdateCustomer(UpdateCompanyCustomerDto values);
        Task<CustomerRegistrationResponseDto> UpdateCustomer(UpdateIndividualResidentCustomerDto values);
        Task<CustomerRegistrationResponseDto> UpdateCustomer(UpdateJointOwnershipCustomerDto values);
        Task<CustomerRegistrationResponseDto> UpdateCustomer(UpdateMultiOwnershipCustomerDto values);

        Task<int> DeleteCustomerAsync(DeleteCustomerRequestDto values);

        Task<int> StopCustomerDebitAsync(StopDebitRequestDto values);

        Task<int> ApproveCustomerAsync(ApproveCustomerDto values);

    }
}

