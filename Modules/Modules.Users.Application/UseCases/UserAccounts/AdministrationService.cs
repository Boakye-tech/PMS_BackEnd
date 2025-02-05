using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Modules.Users.Application.Dtos.Administration;
using Modules.Users.Application.Enums;
using Modules.Users.Application.Validations;

namespace Modules.Users.Application.UseCases.UserAccounts
{
	public class AdministrationService : IAdministrationService
    {
        private readonly RoleManager<ApplicationIdentityRole> _roleManager;
        private readonly UserManager<ApplicationIdentityUser> _userManager;
        private readonly IUnitOfWork _unitOfWork;

        private readonly ValidationService _validationService;
        private readonly ILogger<AdministrationService> _logger;

        //private readonly IValidator<RolesDto> _validator;
        //private readonly IValidator<RolesUpdateDto> _updateValidator;
        //private readonly IValidator<RolesDeleteDto> _deleteValidator;

        public AdministrationService(RoleManager<ApplicationIdentityRole> roleManager, UserManager<ApplicationIdentityUser> userManager, IUnitOfWork unitOfWork,
                                     ValidationService validationService, ILogger<AdministrationService> logger) //,IValidator<RolesDto> validator, IValidator<RolesUpdateDto> updateValidator, IValidator<RolesDeleteDto> deleteValidator
        {
            _roleManager = roleManager;
            _userManager = userManager;
            _unitOfWork = unitOfWork;
            _validationService = validationService;
            _logger = logger;

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
                ApplicationIdentityRole? identityRole = await _roleManager.FindByIdAsync(roleId.RoleId!);
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
                ApplicationIdentityRole? identityRole = await _roleManager.FindByIdAsync(role.RoleId);

                identityRole!.Name = role.RoleName;
                identityRole.NormalizedName = role.RoleName!.ToUpper();
                identityRole.ModifiedBy = role.ModifiedBy;

                IdentityResult result = await _roleManager.UpdateAsync(identityRole);

                return result;
            }

            return null!;
        }

        public async Task<IdentityResult> ApproveUserRole(RolesApprovalDto role)
        {
            //throw new NotImplementedException();
            var validationResult = _validationService.Validate(role);

            if (validationResult.IsValid)
            {
                ApplicationIdentityRole? identityRole = await _roleManager.FindByIdAsync(role.RoleId);

                identityRole!.ApprovedBy = role.ApprovedBy;
                identityRole.ApprovedOn = DateTime.UtcNow;
                identityRole.Status = (int)RegistrationStatus.Approved;

                IdentityResult result = await _roleManager.UpdateAsync(identityRole);

                return result;
            }

            return null!;
        }

        public IEnumerable<RolesDto> GetApprovedUserRoles()
        {
            //var result = _roleManager.Roles.Select(role => new RolesDto(role.Id, role.Name!)).ToList();

            return _roleManager.Roles
                .Where(r => r.Status == (int)RegistrationStatus.Verified)
                .Select(role => new RolesDto(role.Id, role.Name!, role.CreatedBy!, role.CreatedOn, role.ApprovedBy!, role.ApprovedOn, role.Status)).ToList();
        }

        //public IEnumerable<IdentityRole> GetUserRoles()
        public IEnumerable<RolesDto> GetUserRoles()
        {
            //var result = _roleManager.Roles.Select(role => new RolesDto(role.Id, role.Name!)).ToList();

            return _roleManager.Roles.Select(role => new RolesDto(role.Id, role.Name!,role.CreatedBy!, role.CreatedOn, role.ApprovedBy!, role.ApprovedOn, role.Status)).ToList();
        }

        public async Task<CustomerVerificationResponseDto> VerifyCustomerAccount(VerifyUserAccountDto accountVerification)
        {
            //throw new NotImplementedException();
            var user = await _userManager.FindByEmailAsync(accountVerification.EmailAddress!);
            if(user is null)
            {
                _logger.LogWarning($"Customer account with email address {accountVerification.EmailAddress} not found.", accountVerification.EmailAddress);
                return new CustomerVerificationResponseDto
                {
                    IsSuccess = false,
                    ErrorResponse = new CustomerVerificationErrorResponseDto
                    {
                        StatusCode = StatusCodes.Status404NotFound,
                        StatusMessage = $"Customer with email address {accountVerification.EmailAddress} not found."
                    }
                };
            }

            if((RegistrationStatus)user.Status == RegistrationStatus.Verified)
            {
                _logger.LogWarning($"Customer account with email address {accountVerification.EmailAddress} has already been verified", accountVerification.EmailAddress);
                return new CustomerVerificationResponseDto
                {
                    IsSuccess = false,
                    ErrorResponse = new CustomerVerificationErrorResponseDto
                    {
                        StatusCode = StatusCodes.Status404NotFound,
                        StatusMessage = $"Customer with email address {accountVerification.EmailAddress} not found."
                    }
                };

            }

            var staff = await _userManager.FindByIdAsync(accountVerification.verifiedBy);
            if(staff is null)
            {
                _logger.LogWarning($"Verification officer with id {accountVerification.verifiedBy} not found.", accountVerification.verifiedBy);
                return new CustomerVerificationResponseDto
                {
                    IsSuccess = false,
                    ErrorResponse = new CustomerVerificationErrorResponseDto
                    {
                        StatusCode = StatusCodes.Status404NotFound,
                        StatusMessage = $"Verification officer with id {accountVerification.verifiedBy} not found."
                    }
                };

            }

            var userAccount = await _unitOfWork.Users.Get(u => u.Email == accountVerification.EmailAddress);
            userAccount.Status = (int)RegistrationStatus.Verified; // 1- verified
            userAccount.VerifiedBy = accountVerification.verifiedBy;
            userAccount.VerifiedDate = DateTime.UtcNow;

            _unitOfWork.Users.Update(userAccount);
            await _unitOfWork.Complete();

            _logger.LogInformation($"Customer account id {user.Id} with email address {user.Email} has been successfully verified by verification officer with account id {staff.Id} and staff id {staff.IdentificationNumber}.", user.Id);
            return new CustomerVerificationResponseDto
            {
                IsSuccess = true,
                SuccessResponse = new CustomerVerificationSuccessResponseDto
                {
                    StatusCode = StatusCodes.Status200OK,
                    StatusMessage = $"Customer account id {user.Id} with email address {user.Email} has been successfully verified by verification officer with account id {staff.Id} and staff id {staff.IdentificationNumber}"
                }
            };
        }

        public async Task<CustomerRejectionResponseDto> RejectCustomerAccount(RejectUserAccountDto accountRejection)
        {
            //throw new NotImplementedException();
            var user = await _userManager.FindByEmailAsync(accountRejection.EmailAddress!);
            if (user is null)
            {
                _logger.LogWarning($"Customer with email address {accountRejection.EmailAddress} not found.", accountRejection.EmailAddress);
                return new CustomerRejectionResponseDto
                {
                    IsSuccess = false,
                    ErrorResponse = new CustomerRejectionErrorResponseDto
                    {
                        StatusCode = StatusCodes.Status404NotFound,
                        StatusMessage = $"Customer with email address {accountRejection.EmailAddress} not found."
                    }
                };

            }

            if ((RegistrationStatus)user.Status == RegistrationStatus.Rejected)
            {
                _logger.LogWarning($"Customer account with email address {accountRejection.EmailAddress} has already been rejected", accountRejection.EmailAddress);
                return new CustomerRejectionResponseDto
                {
                    IsSuccess = false,
                    ErrorResponse = new CustomerRejectionErrorResponseDto
                    {
                        StatusCode = StatusCodes.Status404NotFound,
                        StatusMessage = $"Customer with email address {accountRejection.EmailAddress} has already been rejected."
                    }
                };

            }

            var staff = await _userManager.FindByIdAsync(accountRejection.RejectedBy);
            if (staff is null)
            {
                _logger.LogWarning($"Verification officer with id {accountRejection.RejectedBy} not found.", accountRejection.RejectedBy);
                return new CustomerRejectionResponseDto
                {
                    IsSuccess = false,
                    ErrorResponse = new CustomerRejectionErrorResponseDto
                    {
                        StatusCode = StatusCodes.Status404NotFound,
                        StatusMessage = $"Verification officer with id {accountRejection.RejectedBy} not found."
                    }
                };

            }

            var userAccount = await _unitOfWork.Users.Get(u => u.Email == accountRejection.EmailAddress);
            userAccount.Status = (int)RegistrationStatus.Rejected; //4 - rejected
            userAccount.RejectedBy = accountRejection.RejectedBy;
            userAccount.RejectedDate = DateTime.UtcNow;
            userAccount.RejectedReasons = accountRejection.RejectedReasons;
            userAccount.EmailConfirmed = false;
            userAccount.PhoneNumberConfirmed = false;


            _unitOfWork.Users.Update(userAccount);
            await _unitOfWork.Complete();

            _logger.LogInformation($"Customer account id {user.Id} with email address {user.Email} has been rejected by verification officer {staff.IdentificationNumber} - {staff.FirstName} {staff.LastName}, with the reason {accountRejection.RejectedReasons}", user.Id);
            return new CustomerRejectionResponseDto
            {
                IsSuccess = true,
                SuccessResponse = new CustomerRejectionSuccessResponseDto
                {
                    StatusCode = StatusCodes.Status200OK,
                    StatusMessage = $"Customer account id {user.Id} with email address {user.Email} has been rejected by verification officer {staff.IdentificationNumber} - {staff.FirstName} {staff.LastName}, with the reason {accountRejection.RejectedReasons}"
                }
            };
        }

        public async Task<ApproveUserAccountResponseDto> ApproveUserAccount(ApproveUserAccountDto accountApproval)
        {
            //throw new NotImplementedException();
            var user = await _userManager.FindByEmailAsync(accountApproval.EmailAddress!);
            if (user is null)
            {
                _logger.LogWarning($"Customer account with email address {accountApproval.EmailAddress} not found.", accountApproval.EmailAddress);
                return new ApproveUserAccountResponseDto
                {
                    IsSuccess = false,
                    ErrorResponse = new ApproveUserAccountErrorResponseDto
                    {
                        StatusCode = StatusCodes.Status404NotFound,
                        StatusMessage = $"Customer with email address {accountApproval.EmailAddress} not found."
                    }
                };
            }

            if ((RegistrationStatus)user.Status == RegistrationStatus.Approved)
            {
                _logger.LogWarning($"Customer account with email address {accountApproval.EmailAddress} has already been approved", accountApproval.EmailAddress);
                return new ApproveUserAccountResponseDto
                {
                    IsSuccess = false,
                    ErrorResponse = new ApproveUserAccountErrorResponseDto
                    {
                        StatusCode = StatusCodes.Status404NotFound,
                        StatusMessage = $"Customer with email address {accountApproval.EmailAddress} not found."
                    }
                };

            }

            var staff = await _userManager.FindByIdAsync(accountApproval.ApprovedBy);
            if (staff is null)
            {
                _logger.LogWarning($"Approval officer with id {accountApproval.ApprovedBy} not found.", accountApproval.ApprovedBy);
                return new ApproveUserAccountResponseDto
                {
                    IsSuccess = false,
                    ErrorResponse = new ApproveUserAccountErrorResponseDto
                    {
                        StatusCode = StatusCodes.Status404NotFound,
                        StatusMessage = $"Approval officer with id {accountApproval.ApprovedBy} not found."
                    }
                };
            }

            var userAccount = await _unitOfWork.Users.Get(u => u.Email == accountApproval.EmailAddress);
            userAccount.Status = (int)RegistrationStatus.Approved; // 2 - approved
            userAccount.ApprovedBy = accountApproval.ApprovedBy;
            userAccount.ApprovedDate = DateTime.UtcNow;

            _unitOfWork.Users.Update(userAccount);
            await _unitOfWork.Complete();

            _logger.LogInformation($"Customer account id {user.Id} with email address {user.Email} has been successfully approved by approval officer with account id {staff.Id} and staff id {staff.IdentificationNumber}.", user.Id);
            return new ApproveUserAccountResponseDto
            {
                IsSuccess = true,
                SuccessResponse = new ApproveUserAccountSuccessResponseDto
                {
                    StatusCode = StatusCodes.Status200OK,
                    StatusMessage = $"Customer account id {user.Id} with email address {user.Email} has been successfully approved by approval officer with account id {staff.Id} and staff id {staff.IdentificationNumber}"
                }
            };
        }

        public async Task<DisapprovedUserAccountResponseDto> DisapproveUserAccount(DisapprovedUserAccountDto accountDisapproval)
        {
            //throw new NotImplementedException();
            var user = await _userManager.FindByEmailAsync(accountDisapproval.EmailAddress!);
            if (user is null)
            {
                _logger.LogWarning($"Customer with email address {accountDisapproval.EmailAddress} not found.", accountDisapproval.EmailAddress);
                return new DisapprovedUserAccountResponseDto
                {
                    IsSuccess = false,
                    ErrorResponse = new DisapprovedUserAccountErrorResponseDto
                    {
                        StatusCode = StatusCodes.Status404NotFound,
                        StatusMessage = $"Customer with email address {accountDisapproval.EmailAddress} not found."
                    }
                };

            }

            if ((RegistrationStatus)user.Status == RegistrationStatus.Disapproved)
            {
                _logger.LogWarning($"Customer account with email address {accountDisapproval.EmailAddress} has already been disapproved", accountDisapproval.EmailAddress);
                return new DisapprovedUserAccountResponseDto
                {
                    IsSuccess = false,
                    ErrorResponse = new DisapprovedUserAccountErrorResponseDto
                    {
                        StatusCode = StatusCodes.Status404NotFound,
                        StatusMessage = $"Customer with email address {accountDisapproval.EmailAddress} has already been rejected."
                    }
                };

            }

            var staff = await _userManager.FindByIdAsync(accountDisapproval.DisapprovedBy);
            if (staff is null)
            {
                _logger.LogWarning($"Disapproval officer with id {accountDisapproval.DisapprovedBy} not found.", accountDisapproval.DisapprovedBy);
                return new DisapprovedUserAccountResponseDto
                {
                    IsSuccess = false,
                    ErrorResponse = new DisapprovedUserAccountErrorResponseDto
                    {
                        StatusCode = StatusCodes.Status404NotFound,
                        StatusMessage = $"Disapproval officer with id {accountDisapproval.DisapprovedBy} not found."
                    }
                };

            }

            var userAccount = await _unitOfWork.Users.Get(u => u.Email == accountDisapproval.EmailAddress);
            userAccount.Status = (int)RegistrationStatus.Disapproved; //5 - Disapproved
            userAccount.DisapprovedBy = accountDisapproval.DisapprovedBy;
            userAccount.DisapprovedDate = DateTime.UtcNow;
            userAccount.DisapprovedReasons = accountDisapproval.DisapprovedReasons;
            userAccount.EmailConfirmed = false;
            userAccount.PhoneNumberConfirmed = false;


            _unitOfWork.Users.Update(userAccount);
            await _unitOfWork.Complete();

            _logger.LogInformation($"Customer account id {user.Id} with email address {user.Email} has been disapproved by disapproval officer {staff.IdentificationNumber} - {staff.FirstName} {staff.LastName}, with the reason {accountDisapproval.DisapprovedReasons}", user.Id);
            return new DisapprovedUserAccountResponseDto
            {
                IsSuccess = true,
                SuccessResponse = new DisapprovedUserAccountSuccessResponseDto
                {
                    StatusCode = StatusCodes.Status200OK,
                    StatusMessage = $"Customer account id {user.Id} with email address {user.Email} has been disapproved by disapproval officer {staff.IdentificationNumber} - {staff.FirstName} {staff.LastName}, with the reason {accountDisapproval.DisapprovedReasons}"
                }
            };
        }

        public async Task<ActivateUserAccountResponseDto> ActivateUserAccount(ActivateUserAccountDto accountActivation)
        {
            //throw new NotImplementedException();

            var user = await _userManager.FindByEmailAsync(accountActivation.EmailAddress!);
            if (user is null)
            {
                _logger.LogWarning($"{accountActivation.UserAccountType} account with email address {accountActivation.EmailAddress} not found.", accountActivation.EmailAddress);
                return new ActivateUserAccountResponseDto
                {
                    IsSuccess = false,
                    ErrorResponse = new ActivateUserAccountErrorResponseDto
                    {
                        StatusCode = StatusCodes.Status404NotFound,
                        StatusMessage = $"Customer with email address {accountActivation.EmailAddress} not found."
                    }
                };
            }

            if ((RegistrationStatus)user.Status == RegistrationStatus.Activated)
            {
                _logger.LogWarning($"{accountActivation.UserAccountType} account with email address {accountActivation.EmailAddress} has already been activated", accountActivation.EmailAddress);
                return new ActivateUserAccountResponseDto
                {
                    IsSuccess = false,
                    ErrorResponse = new ActivateUserAccountErrorResponseDto
                    {
                        StatusCode = StatusCodes.Status404NotFound,
                        StatusMessage = $"Customer with email address {accountActivation.EmailAddress} not found."
                    }
                };

            }

            var staff = await _userManager.FindByIdAsync(accountActivation.activatedBy);
            if (staff is null)
            {
                _logger.LogWarning($"Activation officer with id {accountActivation.activatedBy} not found.", accountActivation.activatedBy);
                return new ActivateUserAccountResponseDto
                {
                    IsSuccess = false,
                    ErrorResponse = new ActivateUserAccountErrorResponseDto
                    {
                        StatusCode = StatusCodes.Status404NotFound,
                        StatusMessage = $"Activation officer with id {accountActivation.activatedBy} not found."
                    }
                };

            }



            var userAccount = await _unitOfWork.Users.Get(u => u.Email == accountActivation.EmailAddress);
            userAccount.Status = (int)RegistrationStatus.Activated; // 3 - activated
            userAccount.ActivatedBy = accountActivation.activatedBy;
            userAccount.ActivatedDate = DateTime.UtcNow;
            userAccount.EmailConfirmed = true;
            userAccount.PhoneNumberConfirmed = true;

            _unitOfWork.Users.Update(userAccount);
            await _unitOfWork.Complete();

            _logger.LogInformation($"Customer account id {user.Id} with email address {user.Email} has been successfully activated by activation officer with account id {staff.Id} and staff id {staff.IdentificationNumber}.", user.Id);
            return new ActivateUserAccountResponseDto
            {
                IsSuccess = true,
                SuccessResponse = new ActivateUserAccountSuccessResponseDto
                {
                    StatusCode = StatusCodes.Status200OK,
                    StatusMessage = $"Customer account id {user.Id} with email address {user.Email} has been successfully actibvated by activation officer with account id {staff.Id} and staff id {staff.IdentificationNumber}"
                }
            };


        }

        public async Task<DeactivateUserAccountResponseDto> DeactivateUserAccount(DeactivateUserAccountDto accountDeactivation)
        {
            //throw new NotImplementedException();
            var user = await _userManager.FindByEmailAsync(accountDeactivation.EmailAddress!);
            if (user is null)
            {
                _logger.LogWarning($"Customer with email address {accountDeactivation.EmailAddress} not found.", accountDeactivation.EmailAddress);
                return new DeactivateUserAccountResponseDto
                {
                    IsSuccess = false,
                    ErrorResponse = new DeactivateUserAccountErrorResponseDto
                    {
                        StatusCode = StatusCodes.Status404NotFound,
                        StatusMessage = $"Customer with email address {accountDeactivation.EmailAddress} not found."
                    }
                };

            }

            if ((RegistrationStatus)user.Status == RegistrationStatus.Rejected)
            {
                _logger.LogWarning($"Customer account with email address {accountDeactivation.EmailAddress} has already been rejected", accountDeactivation.EmailAddress);
                return new DeactivateUserAccountResponseDto
                {
                    IsSuccess = false,
                    ErrorResponse = new DeactivateUserAccountErrorResponseDto
                    {
                        StatusCode = StatusCodes.Status404NotFound,
                        StatusMessage = $"Customer with email address {accountDeactivation.EmailAddress} has already been rejected."
                    }
                };

            }

            var staff = await _userManager.FindByIdAsync(accountDeactivation.DeactivatedBy);
            if (staff is null)
            {
                _logger.LogWarning($"Deactivation officer with id {accountDeactivation.DeactivatedBy} not found.", accountDeactivation.DeactivatedBy);
                return new DeactivateUserAccountResponseDto
                {
                    IsSuccess = false,
                    ErrorResponse = new DeactivateUserAccountErrorResponseDto
                    {
                        StatusCode = StatusCodes.Status404NotFound,
                        StatusMessage = $"Deactivation officer with id {accountDeactivation.DeactivatedBy} not found."
                    }
                };

            }

            var userAccount = await _unitOfWork.Users.Get(u => u.Email == accountDeactivation.EmailAddress);
            userAccount.Status = (int)RegistrationStatus.Deactivated; //6 - deactivated
            userAccount.DeactivatedBy = accountDeactivation.DeactivatedBy;
            userAccount.DeactivatedDate = DateTime.UtcNow;
            userAccount.DeactivatedReasons = accountDeactivation.DeactivatedReasons;
            userAccount.EmailConfirmed = false;
            userAccount.PhoneNumberConfirmed = false;


            _unitOfWork.Users.Update(userAccount);
            await _unitOfWork.Complete();

            _logger.LogInformation($"Customer account id {user.Id} with email address {user.Email} has been rejected by verification officer {staff.IdentificationNumber} - {staff.FirstName} {staff.LastName}, with the reason {accountDeactivation.DeactivatedReasons}", user.Id);
            return new DeactivateUserAccountResponseDto
            {
                IsSuccess = true,
                SuccessResponse = new DeactivateUserAccountSuccessResponseDto
                {
                    StatusCode = StatusCodes.Status200OK,
                    StatusMessage = $"Customer account id {user.Id} with email address {user.Email} has been rejected by verification officer {staff.IdentificationNumber} - {staff.FirstName} {staff.LastName}, with the reason {accountDeactivation.DeactivatedReasons}"
                }
            };
        }

        public async Task<IEnumerable<AdministrationStaffDto>> GetAdministrationStaff()
        {

            var staff_UserList = (from user in await _unitOfWork.Users.GetAll()
                            join department in await _unitOfWork.Department.GetAll()
                                on user.DepartmentId equals department.DepartmentId
                            join unit in await _unitOfWork.DepartmentUnit.GetAll()
                                on department.DepartmentId equals unit.DepartmentId
                            where user.UserType == (int)UserAccountType.Staff
                            select new AdministrationStaffDto
                            (
                                user.Id,
                                user.IdentificationNumber!,
                                user.FirstName!,
                                user.MiddleName!,
                                user.LastName!,
                                department.DepartmentName,
                                unit.UnitName,
                                user.ProfilePicture!,
                                user.Email!,
                                user.PhoneNumber!,
                                RegistrationStatusEnumDescription.RegistrationStatusEnum(user.Status).ToString()
                            )).ToList();

            return staff_UserList;


        }



    }
}

