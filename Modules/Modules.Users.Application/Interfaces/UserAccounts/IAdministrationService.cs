using System;
using Microsoft.AspNetCore.Identity;
using Modules.Users.Application.Dtos.Administration;

namespace Modules.Users.Application.Interfaces.UserAccounts
{
	public interface IAdministrationService
	{
        //IEnumerable<IdentityRole> GetUserRoles();
        Task<List<RolesDto>> GetApprovedUserRoles();
        Task<List<RolesDto>> GetDepartmentUserRoles(int departmentId);
        Task<List<RolesDto>> GetDepartmentUnitUserRoles(int unit);
        Task<List<RolesDto>> GetRejectedUserRoles();

        Task<List<RolesDto>> GetUserRoles();
        Task<List<RolesDto>> GetUserRoles(int departmentId);
        Task<List<RolesDto>> GetUnitUserRoles(int unit);

        Task<IdentityResult> CreateUserRole(RolesCreateDto role);
        Task<IdentityResult> UpdateUserRole(RolesUpdateDto role);
        Task<IdentityResult> DeleteUserRole(RolesDeleteDto roleId);

        Task<IdentityResult> ApproveUserRole(RolesApprovalDto role);
        Task<IdentityResult> DisapproveUserRole(RolesApprovalDto role);


        Task<CustomerVerificationResponseDto> VerifyCustomerAccount(VerifyUserAccountDto accountVerification);
        Task<CustomerRejectionResponseDto> RejectCustomerAccount(RejectUserAccountDto accountRejection);

        Task<ApproveUserAccountResponseDto> ApproveUserAccount(ApproveUserAccountDto accountApproval);
        Task<DisapprovedUserAccountResponseDto> DisapproveUserAccount(DisapprovedUserAccountDto accountDisapproval);

        Task<ActivateUserAccountResponseDto> ActivateUserAccount(ActivateUserAccountDto accountActivation);
        Task<DeactivateUserAccountResponseDto> DeactivateUserAccount(DeactivateUserAccountDto accountDeactivation);


        Task<IEnumerable<AdministrationStaffDto>> GetAdministrationStaff();
        Task<IEnumerable<AdministrationCustomerDto>> GetAdministrationCustomer();
        Task<IEnumerable<AdministrationPartnersDto>> GetAdministrationPartners();
        Task<IEnumerable<AdministrationStaffDto>> GetAdministrationDepartmentStaff(int departmentId);
        Task<IEnumerable<AdministrationStaffDto>> GetAdministrationDepartmentUnitStaff(int unitId);






    }
}

