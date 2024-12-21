using System;
using Microsoft.AspNetCore.Identity;
using Modules.Users.Application.Dtos.Administration;

namespace Modules.Users.Application.Interfaces.UserAccounts
{
	public interface IAdministrationService
	{
        IEnumerable<IdentityRole> GetUserRoles();
        Task<IdentityResult> CreateUserRole(RolesDto role);
        Task<IdentityResult> UpdateUserRole(RolesUpdateDto role);
        Task<IdentityResult> DeleteUserRole(RolesDeleteDto roleId);

        void VerifyUserAccount(VerifyUserAccountDto accountVerification);
        void ApproveUserAccount(ApproveUserAccountDto accountApproval);
        void ActivateUserAccount(ActivateUserAccountDto accountActivation);

    }
}

