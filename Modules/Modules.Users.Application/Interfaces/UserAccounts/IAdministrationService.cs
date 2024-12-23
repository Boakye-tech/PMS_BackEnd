using System;
using Microsoft.AspNetCore.Identity;
using Modules.Users.Application.Dtos.Administration;

namespace Modules.Users.Application.Interfaces.UserAccounts
{
	public interface IAdministrationService
	{
        //IEnumerable<IdentityRole> GetUserRoles();
        IEnumerable<RolesDto> GetUserRoles();
        Task<IdentityResult> CreateUserRole(RolesCreateDto role);
        Task<IdentityResult> UpdateUserRole(RolesUpdateDto role);
        Task<IdentityResult> DeleteUserRole(RolesDeleteDto roleId);

        void VerifyUserAccount(VerifyUserAccountDto accountVerification);
        void ApproveUserAccount(ApproveUserAccountDto accountApproval);
        void ActivateUserAccount(ActivateUserAccountDto accountActivation);

    }
}

