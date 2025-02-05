using System;
using Microsoft.AspNetCore.Identity;
using Modules.Users.Application.Dtos.Administration;

namespace Modules.Users.Application.Interfaces.UserAccounts
{
	public interface IAdministrationService
	{
        //IEnumerable<IdentityRole> GetUserRoles();
        IEnumerable<RolesDto> GetApprovedUserRoles();
        IEnumerable<RolesDto> GetUserRoles();
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
        //Task<IEnumerable<AdministrationCustomerDto>> GetAdministrationStaff();
        //Task<IEnumerable<AdministrationPartnerBanksDto>> GetAdministrationStaff();
        //Task<IEnumerable<AdministrationDepartmentMembersDto>> GetAdministrationStaff();
        //Task<IEnumerable<AdministrationDepartmentUnitMembersDto>> GetAdministrationStaff();






    }
}

