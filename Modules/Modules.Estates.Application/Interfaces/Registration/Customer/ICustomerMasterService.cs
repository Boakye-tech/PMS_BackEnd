// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/Interfaces/Registration/Customer/ICustomerMasterService.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 25/07/2025 10:54 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


namespace Modules.Estates.Application.Interfaces.Registration.Customer
{
    public interface ICustomerMasterService
    {
        Task<CustomerRegistrationResponseDto> CreateCustomer(ProspectiveCustomerCreateDto values);
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

        Task<IEnumerable<CustomerListDto>> GetCustomerListAsync(string? searchParam, string? locality);

        Task<IEnumerable<CustomerListDto>> GetPendingCustomerListAsync();

        Task<CustomerRegistrationResponseDto> UpdateCustomer(UpdateProspectiveCustomerDto values);

        Task<CustomerRegistrationResponseDto> UpdateCustomer(UpdateCompanyCustomerDto values);
        Task<CustomerRegistrationResponseDto> UpdateCustomer(UpdateIndividualResidentCustomerDto values);
        Task<CustomerRegistrationResponseDto> UpdateCustomer(UpdateJointOwnershipCustomerDto values);
        Task<CustomerRegistrationResponseDto> UpdateCustomer(UpdateMultiOwnershipCustomerDto values);


        Task<int> DeleteCustomerAsync(DeleteCustomerRequestDto values);

        Task<int> ApproveCustomerAsync(ApproveCustomerDto values);

    }
}

