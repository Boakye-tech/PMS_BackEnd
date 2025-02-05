using System.Linq;
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
                    Status = (int)RegistrationStatus.Pending
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


        public async Task<IdentityResult> DisapproveUserRole(RolesApprovalDto role)
        {
            //throw new NotImplementedException();
            var validationResult = _validationService.Validate(role);

            if (validationResult.IsValid)
            {
                ApplicationIdentityRole? identityRole = await _roleManager.FindByIdAsync(role.RoleId);

                identityRole!.ApprovedBy = role.ApprovedBy;
                identityRole.ApprovedOn = DateTime.UtcNow;
                identityRole.Status = (int)RegistrationStatus.Disapproved;

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
                .Select(role => new RolesDto(role.Id, role.Name!, role.CreatedBy!, role.CreatedOn, role.ApprovedBy!, role.ApprovedOn, RegistrationStatusEnumDescription.RegistrationStatusEnum(role.Status).ToString())).ToList();
        }

        //public IEnumerable<IdentityRole> GetUserRoles()
        public IEnumerable<RolesDto> GetUserRoles()
        {
            //var result = _roleManager.Roles.Select(role => new RolesDto(role.Id, role.Name!)).ToList();

            return _roleManager.Roles.Select(role => new RolesDto(role.Id, role.Name!,role.CreatedBy!, role.CreatedOn, role.ApprovedBy!, role.ApprovedOn, RegistrationStatusEnumDescription.RegistrationStatusEnum(role.Status).ToString())).ToList();
        }

        public async Task<CustomerVerificationResponseDto> VerifyCustomerAccount(VerifyUserAccountDto accountVerification)
        {
            //throw new NotImplementedException();
            var user = await _userManager.FindByIdAsync(accountVerification.UserId!);

            if(user is null)
            {
                _logger.LogWarning($"User account with id {accountVerification.UserId} not found.", accountVerification.UserId);
                return new CustomerVerificationResponseDto
                {
                    IsSuccess = false,
                    ErrorResponse = new CustomerVerificationErrorResponseDto
                    {
                        StatusCode = StatusCodes.Status404NotFound,
                        StatusMessage = $"User account with id '{accountVerification.UserId}' not found."
                    }
                };
            }

            if((RegistrationStatus)user.Status == RegistrationStatus.Verified)
            {
                _logger.LogWarning($"User account with id {accountVerification.UserId} has already been verified", accountVerification.UserId);
                return new CustomerVerificationResponseDto
                {
                    IsSuccess = false,
                    ErrorResponse = new CustomerVerificationErrorResponseDto
                    {
                        StatusCode = StatusCodes.Status404NotFound,
                        StatusMessage = $"User account with id '{accountVerification.UserId}; not found."
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

            //var userAccount = await _unitOfWork.Users.Get(u => u.Email == accountVerification.EmailAddress);
            user.Status = (int)RegistrationStatus.Verified; // 1- verified
            user.VerifiedBy = accountVerification.verifiedBy;
            user.VerifiedDate = DateTime.UtcNow;

            _unitOfWork.Users.Update(user);
            await _unitOfWork.Complete();

            _logger.LogInformation($"User account with id {user.Id} with email address {user.Email} has been successfully verified by verification officer with account id {staff.Id} and staff id {staff.IdentificationNumber}.", user.Id);
            return new CustomerVerificationResponseDto
            {
                IsSuccess = true,
                SuccessResponse = new CustomerVerificationSuccessResponseDto
                {
                    StatusCode = StatusCodes.Status200OK,
                    StatusMessage = $"User account with id '{user.Id}', with email address '{user.Email}' has been successfully verified by verification officer with account id '{staff.Id}' and staff id '{staff.IdentificationNumber}'"
                }
            };
        }

        public async Task<CustomerRejectionResponseDto> RejectCustomerAccount(RejectUserAccountDto accountRejection)
        {
            //throw new NotImplementedException();
            var user = await _userManager.FindByIdAsync(accountRejection.UserId!);

            if (user is null)
            {
                _logger.LogWarning($"User account with id {accountRejection.UserId} not found.", accountRejection.UserId);
                return new CustomerRejectionResponseDto
                {
                    IsSuccess = false,
                    ErrorResponse = new CustomerRejectionErrorResponseDto
                    {
                        StatusCode = StatusCodes.Status404NotFound,
                        StatusMessage = $"User with id '{accountRejection.UserId}' not found."
                    }
                };

            }

            if ((RegistrationStatus)user.Status == RegistrationStatus.Rejected)
            {
                _logger.LogWarning($"User account with id {accountRejection.UserId} has already been rejected", accountRejection.UserId);
                return new CustomerRejectionResponseDto
                {
                    IsSuccess = false,
                    ErrorResponse = new CustomerRejectionErrorResponseDto
                    {
                        StatusCode = StatusCodes.Status404NotFound,
                        StatusMessage = $"User account with id '{accountRejection.UserId}' has already been rejected."
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

            //var userAccount = await _unitOfWork.Users.Get(u => u.Email == accountRejection.EmailAddress);
            user.Status = (int)RegistrationStatus.Rejected; //4 - rejected
            user.RejectedBy = accountRejection.RejectedBy;
            user.RejectedDate = DateTime.UtcNow;
            user.RejectedReasons = accountRejection.RejectedReasons;
            user.EmailConfirmed = false;
            user.PhoneNumberConfirmed = false;


            _unitOfWork.Users.Update(user);
            await _unitOfWork.Complete();

            _logger.LogInformation($"User account with id {user.Id} with email address {user.Email} has been rejected by verification officer {staff.IdentificationNumber} - {staff.FirstName} {staff.LastName}, with the reason {accountRejection.RejectedReasons}", user.Id);
            return new CustomerRejectionResponseDto
            {
                IsSuccess = true,
                SuccessResponse = new CustomerRejectionSuccessResponseDto
                {
                    StatusCode = StatusCodes.Status200OK,
                    StatusMessage = $"User account with id '{user.Id}', with email address '{user.Email}' has been rejected by verification officer '{staff.IdentificationNumber} - {staff.FirstName} {staff.LastName}', with the reason '{accountRejection.RejectedReasons}'"
                }
            };
        }

        public async Task<ApproveUserAccountResponseDto> ApproveUserAccount(ApproveUserAccountDto accountApproval)
        {
            //throw new NotImplementedException();
            var user = await _userManager.FindByIdAsync(accountApproval.UserId);

            if (user is null)
            {
                _logger.LogWarning($"User account with id '{accountApproval.UserId}' not found.", accountApproval.UserId);
                return new ApproveUserAccountResponseDto
                {
                    IsSuccess = false,
                    ErrorResponse = new ApproveUserAccountErrorResponseDto
                    {
                        StatusCode = StatusCodes.Status404NotFound,
                        StatusMessage = $"User account with id {accountApproval.UserId} not found."
                    }
                };
            }

            if ((RegistrationStatus)user.Status == RegistrationStatus.Approved)
            {
                _logger.LogWarning($"User account with id {accountApproval.UserId} has already been approved", accountApproval.UserId);
                return new ApproveUserAccountResponseDto
                {
                    IsSuccess = false,
                    ErrorResponse = new ApproveUserAccountErrorResponseDto
                    {
                        StatusCode = StatusCodes.Status404NotFound,
                        StatusMessage = $"User account with id {accountApproval.UserId} not found."
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

            //assign role
            var roleName = await _roleManager.FindByIdAsync(accountApproval.RoleId);
            IdentityResult resultRole = await _userManager.AddToRoleAsync(user, roleName!.Name!);

            //var userAccount = await _unitOfWork.Users.Get(u => u.Id == accountApproval.UserId);
            user.Status = (int)RegistrationStatus.Approved; // 2 - approved
            user.ApprovedBy = accountApproval.ApprovedBy;
            user.ApprovedDate = DateTime.UtcNow;

            _unitOfWork.Users.Update(user);
            await _unitOfWork.Complete();

            _logger.LogInformation($"User account with id '{user.Id}' has been successfully assigned to the role '{roleName!.Name!}' and successfully approved by approval officer with account id '{staff.Id}' and staff id '{staff.IdentificationNumber}'.", user.Id);
            return new ApproveUserAccountResponseDto
            {
                IsSuccess = true,
                SuccessResponse = new ApproveUserAccountSuccessResponseDto
                {
                    StatusCode = StatusCodes.Status200OK,
                    StatusMessage = $"User account with id '{user.Id}' has been successfully assigned to the role '{roleName!.Name!}' and successfully approved by approval officer with account id '{staff.Id}' and staff id '{staff.IdentificationNumber}'."
                }
            };
        }

        public async Task<DisapprovedUserAccountResponseDto> DisapproveUserAccount(DisapprovedUserAccountDto accountDisapproval)
        {
            //throw new NotImplementedException();
            var user = await _userManager.FindByIdAsync(accountDisapproval.UserId!);

            if (user is null)
            {
                _logger.LogWarning($"User account with id {accountDisapproval.UserId} not found.", accountDisapproval.UserId);
                return new DisapprovedUserAccountResponseDto
                {
                    IsSuccess = false,
                    ErrorResponse = new DisapprovedUserAccountErrorResponseDto
                    {
                        StatusCode = StatusCodes.Status404NotFound,
                        StatusMessage = $"User account with id '{accountDisapproval.UserId}' not found."
                    }
                };

            }

            if ((RegistrationStatus)user.Status == RegistrationStatus.Disapproved)
            {
                _logger.LogWarning($"User account with id '{accountDisapproval.UserId}' has already been disapproved", accountDisapproval.UserId);
                return new DisapprovedUserAccountResponseDto
                {
                    IsSuccess = false,
                    ErrorResponse = new DisapprovedUserAccountErrorResponseDto
                    {
                        StatusCode = StatusCodes.Status404NotFound,
                        StatusMessage = $"User account with id '{accountDisapproval.UserId}' has already been disapproved"
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

            //var userAccount = await _unitOfWork.Users.Get(u => u.Email == accountDisapproval.EmailAddress);
            user.Status = (int)RegistrationStatus.Disapproved; //5 - Disapproved
            user.DisapprovedBy = accountDisapproval.DisapprovedBy;
            user.DisapprovedDate = DateTime.UtcNow;
            user.DisapprovedReasons = accountDisapproval.DisapprovedReasons;
            user.EmailConfirmed = false;
            user.PhoneNumberConfirmed = false;


            _unitOfWork.Users.Update(user);
            await _unitOfWork.Complete();

            _logger.LogInformation($"User account with id {user.Id} has been disapproved by disapproval officer {staff.IdentificationNumber} - {staff.FirstName} {staff.LastName}, with the reason {accountDisapproval.DisapprovedReasons}", user.Id);
            return new DisapprovedUserAccountResponseDto
            {
                IsSuccess = true,
                SuccessResponse = new DisapprovedUserAccountSuccessResponseDto
                {
                    StatusCode = StatusCodes.Status200OK,
                    StatusMessage = $"User account with id {user.Id} has been disapproved by disapproval officer {staff.IdentificationNumber} - {staff.FirstName} {staff.LastName}, with the reason {accountDisapproval.DisapprovedReasons}"
                }
            };
        }

        public async Task<ActivateUserAccountResponseDto> ActivateUserAccount(ActivateUserAccountDto accountActivation)
        {
            //throw new NotImplementedException();

            var user = await _userManager.FindByIdAsync(accountActivation.UserId!);
            if (user is null)
            {
                _logger.LogWarning($"User account with id {accountActivation.UserId} not found.", accountActivation.UserId);
                return new ActivateUserAccountResponseDto
                {
                    IsSuccess = false,
                    ErrorResponse = new ActivateUserAccountErrorResponseDto
                    {
                        StatusCode = StatusCodes.Status404NotFound,
                        StatusMessage = $"User account with id {accountActivation.UserId} not found."
                    }
                };
            }

            if ((RegistrationStatus)user.Status == RegistrationStatus.Activated)
            {
                _logger.LogWarning($"User account with id {accountActivation.UserId} has already been activated", accountActivation.UserId);
                return new ActivateUserAccountResponseDto
                {
                    IsSuccess = false,
                    ErrorResponse = new ActivateUserAccountErrorResponseDto
                    {
                        StatusCode = StatusCodes.Status404NotFound,
                        StatusMessage = $"User account with id {accountActivation.UserId} not found."
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


            //var userAccount = await _unitOfWork.Users.Get(u => u.Email == accountActivation.EmailAddress);
            user.Status = (int)RegistrationStatus.Activated; // 3 - activated
            user.ActivatedBy = accountActivation.activatedBy;
            user.ActivatedDate = DateTime.UtcNow;
            user.EmailConfirmed = true;
            user.PhoneNumberConfirmed = true;

            _unitOfWork.Users.Update(user);
            await _unitOfWork.Complete();

            _logger.LogInformation($"User account with id '{user.Id}', with email address {user.Email} has been successfully activated by activation officer with account id {staff.Id} and staff id {staff.IdentificationNumber}.", user.Id);
            return new ActivateUserAccountResponseDto
            {
                IsSuccess = true,
                SuccessResponse = new ActivateUserAccountSuccessResponseDto
                {
                    StatusCode = StatusCodes.Status200OK,
                    StatusMessage = $"User account with id '{user.Id}', with email address '{user.Email}' has been successfully actibvated by activation officer with account id {staff.Id} and staff id {staff.IdentificationNumber}"
                }
            };


        }

        public async Task<DeactivateUserAccountResponseDto> DeactivateUserAccount(DeactivateUserAccountDto accountDeactivation)
        {
            //throw new NotImplementedException();
            var user = await _userManager.FindByIdAsync(accountDeactivation.UserId!);

            if (user is null)
            {
                _logger.LogWarning($"User with id {accountDeactivation.UserId} not found.", accountDeactivation.UserId);
                return new DeactivateUserAccountResponseDto
                {
                    IsSuccess = false,
                    ErrorResponse = new DeactivateUserAccountErrorResponseDto
                    {
                        StatusCode = StatusCodes.Status404NotFound,
                        StatusMessage = $"User account with id '{accountDeactivation.UserId}' not found."
                    }
                };

            }

            if ((RegistrationStatus)user.Status == RegistrationStatus.Rejected)
            {
                _logger.LogWarning($"User account with id {accountDeactivation.UserId} has already been deactivated", accountDeactivation.UserId);
                return new DeactivateUserAccountResponseDto
                {
                    IsSuccess = false,
                    ErrorResponse = new DeactivateUserAccountErrorResponseDto
                    {
                        StatusCode = StatusCodes.Status404NotFound,
                        StatusMessage = $"User account with id {accountDeactivation.UserId} has already been deactivated."
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

            //var userAccount = await _unitOfWork.Users.Get(u => u.Email == accountDeactivation.EmailAddress);
            user.Status = (int)RegistrationStatus.Deactivated; //6 - deactivated
            user.DeactivatedBy = accountDeactivation.DeactivatedBy;
            user.DeactivatedDate = DateTime.UtcNow;
            user.DeactivatedReasons = accountDeactivation.DeactivatedReasons;
            user.EmailConfirmed = false;
            user.PhoneNumberConfirmed = false;


            _unitOfWork.Users.Update(user);
            await _unitOfWork.Complete();

            _logger.LogInformation($"User account with id {user.Id} with email address {user.Email} has been deactivated by deactivation officer {staff.IdentificationNumber} - {staff.FirstName} {staff.LastName}, with the reason {accountDeactivation.DeactivatedReasons}", user.Id);
            return new DeactivateUserAccountResponseDto
            {
                IsSuccess = true,
                SuccessResponse = new DeactivateUserAccountSuccessResponseDto
                {
                    StatusCode = StatusCodes.Status200OK,
                    StatusMessage = $"User account with id '{user.Id}', with email address '{user.Email}' has been deactivated by deactivation officer '{staff.IdentificationNumber} - {staff.FirstName} {staff.LastName}', with the reason '{accountDeactivation.DeactivatedReasons}'"
                }
            };
        }

        public async Task<IEnumerable<AdministrationStaffDto>> GetAdministrationStaff()
        {

            var staff_UserList = (from user in await _unitOfWork.Users.GetAll()
                            join department in await _unitOfWork.Department.GetAll()
                                on user.DepartmentId equals department.DepartmentId
                            join unit in await _unitOfWork.DepartmentUnit.GetAll()
                                on user.UnitId equals unit.UnitId
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

