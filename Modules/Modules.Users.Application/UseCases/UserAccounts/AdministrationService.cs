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

        public async Task<IdentityResult> CreateUserRole(RolesCreateDto role)
        {
            //throw new NotImplementedException();
            //ValidationResult validationResult = await _validator.ValidateAsync(role);

            var validationResult = _validationService.Validate(role);

            if (validationResult.IsValid)
            {
                ApplicationIdentityRole identityRole = new ApplicationIdentityRole
                {
                    Name = role.RoleName,
                    CreatedBy = role.CreatedBy,
                    CreatedOn = DateTime.UtcNow,
                    Status = 0
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
                identityRole.ModifiedBy = role.ModifiedBy;

                IdentityResult result = await _roleManager.UpdateAsync(identityRole);

                return result;
            }

            return null!;
        }

        //public IEnumerable<IdentityRole> GetUserRoles()
        public IEnumerable<RolesDto> GetUserRoles()
        {
            //var result = _roleManager.Roles.Select(role => new RolesDto(role.Id, role.Name!)).ToList();

            return _roleManager.Roles.Select(role => new RolesDto(role.Id, role.Name!,role.CreatedBy!, role.CreatedOn, role.ApprovedBy!, role.ApprovedOn, role.Status)).ToList();
        }

        public async void VerifyUserAccount(VerifyUserAccountDto accountVerification)
        {
            //throw new NotImplementedException();
            var user = _userManager.FindByEmailAsync(accountVerification.EmailAddress!);
            if(user is null)
            {
            }

            var staff = _userManager.FindByEmailAsync(accountVerification.verifiedBy);
            if(staff is null) { }

            var userAccount = await _unitOfWork.Users.Get(u => u.Email == accountVerification.EmailAddress);
            userAccount.Status = accountVerification.status;  //1 //verified
            userAccount.VerifiedBy = accountVerification.verifiedBy;
            userAccount.VerifiedDate = DateTime.UtcNow;

            _unitOfWork.Users.Update(userAccount);
            await _unitOfWork.Complete();
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

