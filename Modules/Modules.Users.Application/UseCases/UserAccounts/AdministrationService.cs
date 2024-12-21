using System;
using System.ComponentModel.DataAnnotations;
using System.Data;
using FluentValidation;
using FluentValidation.Results;
using Microsoft.AspNetCore.Identity;
using Modules.Users.Application.Dtos.Administration;
using Modules.Users.Application.Validations;

namespace Modules.Users.Application.UseCases.UserAccounts
{
	public class AdministrationService : IAdministrationService
    {
        private readonly RoleManager<ApplicationIdentityRole> _roleManager;
        private readonly UserManager<ApplicationIdentityUser> _userManager;
        private readonly IUnitOfWork _unitOfWork;

        private readonly ValidationService _validationService;

        //private readonly IValidator<RolesDto> _validator;
        //private readonly IValidator<RolesUpdateDto> _updateValidator;
        //private readonly IValidator<RolesDeleteDto> _deleteValidator;

        public AdministrationService(RoleManager<ApplicationIdentityRole> roleManager, UserManager<ApplicationIdentityUser> userManager, IUnitOfWork unitOfWork,
                                     ValidationService validationService) //,IValidator<RolesDto> validator, IValidator<RolesUpdateDto> updateValidator, IValidator<RolesDeleteDto> deleteValidator
        {
            _roleManager = roleManager;
            _userManager = userManager;
            _unitOfWork = unitOfWork;
            _validationService = validationService;

            //_validator = validator;
            //_updateValidator = updateValidator;
            //_deleteValidator = deleteValidator;
        }

        public async Task<IdentityResult> CreateUserRole(RolesDto role)
        {
            //throw new NotImplementedException();
            //ValidationResult validationResult = await _validator.ValidateAsync(role);

            var validationResult = _validationService.Validate(role);

            if (validationResult.IsValid)
            {
                ApplicationIdentityRole identityRole = new ApplicationIdentityRole
                {
                    Name = role.RoleName,
                    CreatedBy = "",
                    CreatedOn = DateTime.UtcNow
                    
                };

                IdentityResult result = await _roleManager.CreateAsync(identityRole);

                return result;
            }

            return null!;
        }


        public async Task<IdentityResult> DeleteUserRole(RolesDeleteDto roleId)
        {
            //ValidationResult validationResult = await _deleteValidator.ValidateAsync(roleId);
            var validationResult = _validationService.Validate(roleId);

            if (validationResult.IsValid)
            {
                ApplicationIdentityRole identityRole = await _roleManager.FindByIdAsync(roleId.RoleId!);
                IdentityResult result = await _roleManager.DeleteAsync(identityRole!);

                return result;
            }

            return null!;
        }


        public async Task<IdentityResult> UpdateUserRole(RolesUpdateDto role)
        {
            //throw new NotImplementedException();

            //ValidationResult validationResult = await _updateValidator.ValidateAsync(role);
            var validationResult = _validationService.Validate(role);

            if (validationResult.IsValid)
            {
                ApplicationIdentityRole identityRole = await _roleManager.FindByIdAsync(role.RoleId);

                identityRole!.Name = role.RoleName;
                identityRole.NormalizedName = role.RoleName!.ToUpper();

                IdentityResult result = await _roleManager.UpdateAsync(identityRole);

                return result;
            }

            return null!;
        }

        public IEnumerable<IdentityRole> GetUserRoles()
        {
            return _roleManager.Roles;
        }

        public void VerifyUserAccount(VerifyUserAccountDto accountVerification)
        {
            throw new NotImplementedException();
        }

        public void ApproveUserAccount(ApproveUserAccountDto accountApproval)
        {
            throw new NotImplementedException();
        }

        public void ActivateUserAccount(ActivateUserAccountDto accountActivation)
        {
            throw new NotImplementedException();
        }
    }
}

