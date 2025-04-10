using System.Data;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Modules.Users.Application.Dtos.Administration;
using Modules.Users.Application.Enums;
using Modules.Users.Application.Helpers;
using Modules.Users.Application.Validations;
using Modules.Users.Domain.Entities;

namespace Modules.Users.Application.UseCases.UserAccounts
{
	public class AdministrationService : IAdministrationService
    {
        private readonly RoleManager<ApplicationIdentityRole> _roleManager;
        private readonly UserManager<ApplicationIdentityUser> _userManager;
        private readonly IUnitOfWork _unitOfWork;

        private readonly ValidationService _validationService;
        private readonly ILogger<AdministrationService> _logger;
        private readonly INotificationServices _notifyService;

        public AdministrationService(RoleManager<ApplicationIdentityRole> roleManager, UserManager<ApplicationIdentityUser> userManager, IUnitOfWork unitOfWork,
                                     ValidationService validationService, ILogger<AdministrationService> logger, INotificationServices notifyService) //, HttpClient httpClient 
        {
            _roleManager = roleManager;
            _userManager = userManager;
            _unitOfWork = unitOfWork;
            _validationService = validationService;
            _logger = logger;
            _notifyService = notifyService;

        }

        public async Task<IdentityResult> CreateUserRole(RolesCreateDto role)
        {
            var validationResult = _validationService.Validate(role);

            if (validationResult.IsValid)
            {
                ApplicationIdentityRole identityRole = new ApplicationIdentityRole
                {
                    Name = role.RoleName,
                    DepartmentId = role.DepartmentId,
                    UnitId = role.UnitId,
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
            var validationResult = _validationService.Validate(roleId);

            if (validationResult.IsValid)
            {
                ApplicationIdentityRole? identityRole = await _roleManager.FindByIdAsync(roleId.RoleId!);

                if(identityRole!.Status != (int)RegistrationStatus.Approved)
                {

                    identityRole.DeletedBy = roleId.DeletedBy;
                    identityRole.DeletedOn = DateTime.UtcNow;
                    identityRole.Status = (int)RegistrationStatus.Rejected;

                    IdentityResult result = await _roleManager.UpdateAsync(identityRole);

                    return result;

                }
            }

            return null!;
        }

        public async Task<IdentityResult> UpdateUserRole(RolesUpdateDto role)
        {
            var validationResult = _validationService.Validate(role);

            if (validationResult.IsValid)
            {
                ApplicationIdentityRole? identityRole = await _roleManager.FindByIdAsync(role.RoleId);

                identityRole!.Name = role.RoleName;
                identityRole.NormalizedName = role.RoleName!.ToUpper();
                identityRole.DepartmentId = role.DepartmentId;
                identityRole.UnitId = role.UnitId;
                identityRole.ModifiedBy = role.ModifiedBy;

                IdentityResult result = await _roleManager.UpdateAsync(identityRole);

                return result;
            }

            return null!;
        }

        public async Task<IdentityResult> ApproveUserRole(RolesApprovalDto role)
        {
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

        public async Task<List<RolesDto>> GetApprovedUserRoles()
        {
            var roles = await _roleManager.Roles
                .Where(r => r.Status == (int)RegistrationStatus.Approved)
                .OrderByDescending(role => role.ApprovedOn)
                .ToListAsync(); 

            var roleDtos = new List<RolesDto>();

            foreach (var role in roles)
            {
                var department = await _unitOfWork.Department.Get(role.DepartmentId);
                var unit = await _unitOfWork.DepartmentUnit.Get(role.UnitId);

                var createdByUser = await _userManager.Users
                    .Where(u => u.Id == role.CreatedBy)
                    .Select(u => (u.FirstName + " " + (string.IsNullOrEmpty(u.MiddleName) ? "" : u.MiddleName + " ") + u.LastName).Trim())
                    .FirstOrDefaultAsync();

                var approvedByUser = await _userManager.Users
                    .Where(u => u.Id == role.ApprovedBy)
                    .Select(u => (u.FirstName + " " + (string.IsNullOrEmpty(u.MiddleName) ? "" : u.MiddleName + " ") + u.LastName).Trim())
                    .FirstOrDefaultAsync();

                roleDtos.Add(new RolesDto(
                    role.Id,
                    role.Name!,
                    role.DepartmentId,
                    department?.DepartmentName ?? string.Empty,
                    role.UnitId,
                    unit?.UnitName ?? string.Empty,
                    createdByUser ?? string.Empty,
                    role.CreatedOn,
                    approvedByUser ?? string.Empty,
                    role.ApprovedOn,
                    RegistrationStatusEnumDescription.RegistrationStatusEnum(role.Status).ToString()
                ));
            }

            return roleDtos;
        }

        public async Task<List<RolesDto>> GetDepartmentUserRoles(int departmentId)
        {
            var roles = await _roleManager.Roles
                .Where(r => r.Status == (int)RegistrationStatus.Approved && r.DepartmentId == departmentId)
                .OrderByDescending(role => role.ApprovedOn)
                .ToListAsync();

            var roleDtos = new List<RolesDto>();

            foreach (var role in roles)
            {
                var department = await _unitOfWork.Department.Get(role.DepartmentId);
                var unit = await _unitOfWork.DepartmentUnit.Get(role.UnitId);

                var createdByUser = await _userManager.Users
                    .Where(u => u.Id == role.CreatedBy)
                    .Select(u => (u.FirstName + " " + (string.IsNullOrEmpty(u.MiddleName) ? "" : u.MiddleName + " ") + u.LastName).Trim())
                    .FirstOrDefaultAsync();

                var approvedByUser = await _userManager.Users
                    .Where(u => u.Id == role.ApprovedBy)
                    .Select(u => (u.FirstName + " " + (string.IsNullOrEmpty(u.MiddleName) ? "" : u.MiddleName + " ") + u.LastName).Trim())
                    .FirstOrDefaultAsync();

                roleDtos.Add(new RolesDto(
                    role.Id,
                    role.Name!,
                    role.DepartmentId,
                    department?.DepartmentName ?? string.Empty,
                    role.UnitId,
                    unit?.UnitName ?? string.Empty,
                    createdByUser ?? string.Empty,
                    role.CreatedOn,
                    approvedByUser ?? string.Empty,
                    role.ApprovedOn,
                    RegistrationStatusEnumDescription.RegistrationStatusEnum(role.Status).ToString()
                ));
            }

            return roleDtos;
        }

        public async Task<List<RolesDto>> GetDepartmentUnitUserRoles(int unitId)
        {
            var roles = await _roleManager.Roles
                .Where(r => r.Status == (int)RegistrationStatus.Approved && r.UnitId == unitId)
                .OrderByDescending(role => role.ApprovedOn)
                .ToListAsync();

            var roleDtos = new List<RolesDto>();

            foreach (var role in roles)
            {
                var department = await _unitOfWork.Department.Get(role.DepartmentId);
                var unit = await _unitOfWork.DepartmentUnit.Get(role.UnitId);

                var createdByUser = await _userManager.Users
                    .Where(u => u.Id == role.CreatedBy)
                    .Select(u => (u.FirstName + " " + (string.IsNullOrEmpty(u.MiddleName) ? "" : u.MiddleName + " ") + u.LastName).Trim())
                    .FirstOrDefaultAsync();

                var approvedByUser = await _userManager.Users
                    .Where(u => u.Id == role.ApprovedBy)
                    .Select(u => (u.FirstName + " " + (string.IsNullOrEmpty(u.MiddleName) ? "" : u.MiddleName + " ") + u.LastName).Trim())
                    .FirstOrDefaultAsync();

                roleDtos.Add(new RolesDto(
                    role.Id,
                    role.Name!,
                    role.DepartmentId,
                    department?.DepartmentName ?? string.Empty,
                    role.UnitId,
                    unit?.UnitName ?? string.Empty,
                    createdByUser ?? string.Empty,
                    role.CreatedOn,
                    approvedByUser ?? string.Empty,
                    role.ApprovedOn,
                    RegistrationStatusEnumDescription.RegistrationStatusEnum(role.Status).ToString()
                ));
            }

            return roleDtos;
        }

        public async Task<List<RolesDto>> GetRejectedUserRoles()
        {
            var roles = await _roleManager.Roles
                 .Where(r => r.Status == (int)RegistrationStatus.Rejected)
                 .OrderByDescending(role => role.CreatedOn)
                 .ToListAsync(); 

            var roleDtos = new List<RolesDto>();

            foreach (var role in roles)
            {
                var department = await _unitOfWork.Department.Get(role.DepartmentId);
                var unit = await _unitOfWork.DepartmentUnit.Get(role.UnitId);

                var createdByUser = await _userManager.Users
                    .Where(u => u.Id == role.CreatedBy)
                    .Select(u => (u.FirstName + " " + (string.IsNullOrEmpty(u.MiddleName) ? "" : u.MiddleName + " ") + u.LastName).Trim())
                    .FirstOrDefaultAsync();

                var approvedByUser = await _userManager.Users
                    .Where(u => u.Id == role.ApprovedBy)
                    .Select(u => (u.FirstName + " " + (string.IsNullOrEmpty(u.MiddleName) ? "" : u.MiddleName + " ") + u.LastName).Trim())
                    .FirstOrDefaultAsync();

                roleDtos.Add(new RolesDto(
                    role.Id,
                    role.Name!,
                    role.DepartmentId,
                    department?.DepartmentName ?? string.Empty,
                    role.UnitId,
                    unit?.UnitName ?? string.Empty,  
                    createdByUser ?? string.Empty,
                    role.CreatedOn,
                    approvedByUser ?? string.Empty,
                    role.ApprovedOn,
                    RegistrationStatusEnumDescription.RegistrationStatusEnum(role.Status).ToString()
                ));
            }

            return roleDtos;
        }

        public async Task<List<RolesDto>> GetUserRoles()
        {

            var roles = await _roleManager.Roles
                 .OrderByDescending(role => role.CreatedOn)
                 .ToListAsync();

            var roleDtos = new List<RolesDto>();

            foreach (var role in roles)
            {
                var department = await _unitOfWork.Department.Get(role.DepartmentId);
                var unit = await _unitOfWork.DepartmentUnit.Get(role.UnitId);

                var createdByUser = await _userManager.Users
                    .Where(u => u.Id == role.CreatedBy)
                    .Select(u => (u.FirstName + " " + (string.IsNullOrEmpty(u.MiddleName) ? "" : u.MiddleName + " ") + u.LastName).Trim())
                    .FirstOrDefaultAsync();

                var approvedByUser = await _userManager.Users
                    .Where(u => u.Id == role.ApprovedBy)
                    .Select(u => (u.FirstName + " " + (string.IsNullOrEmpty(u.MiddleName) ? "" : u.MiddleName + " ") + u.LastName).Trim())
                    .FirstOrDefaultAsync();

                roleDtos.Add(new RolesDto(
                    role.Id,
                    role.Name!,
                    role.DepartmentId,
                    department?.DepartmentName ?? string.Empty,
                    role.UnitId,
                    unit?.UnitName ?? string.Empty,
                    createdByUser ?? string.Empty,
                    role.CreatedOn,
                    approvedByUser ?? string.Empty,
                    role.ApprovedOn,
                    RegistrationStatusEnumDescription.RegistrationStatusEnum(role.Status).ToString()
                ));
            }

            return roleDtos;
        }

        public async Task<List<RolesDto>> GetUserRoles(int departmentId)
        {

            var roles = await _roleManager.Roles
                 .Where(r => r.DepartmentId == departmentId)
                 .OrderByDescending(role => role.CreatedOn)
                 .ToListAsync();

            var roleDtos = new List<RolesDto>();

            foreach (var role in roles)
            {
                var department = await _unitOfWork.Department.Get(role.DepartmentId);
                var unit = await _unitOfWork.DepartmentUnit.Get(role.UnitId);

                var createdByUser = await _userManager.Users
                    .Where(u => u.Id == role.CreatedBy)
                    .Select(u => (u.FirstName + " " + (string.IsNullOrEmpty(u.MiddleName) ? "" : u.MiddleName + " ") + u.LastName).Trim())
                    .FirstOrDefaultAsync();

                var approvedByUser = await _userManager.Users
                    .Where(u => u.Id == role.ApprovedBy)
                    .Select(u => (u.FirstName + " " + (string.IsNullOrEmpty(u.MiddleName) ? "" : u.MiddleName + " ") + u.LastName).Trim())
                    .FirstOrDefaultAsync();

                roleDtos.Add(new RolesDto(
                    role.Id,
                    role.Name!,
                    role.DepartmentId,
                    department?.DepartmentName ?? string.Empty,
                    role.UnitId,
                    unit?.UnitName ?? string.Empty,
                    createdByUser ?? string.Empty,
                    role.CreatedOn,
                    approvedByUser ?? string.Empty,
                    role.ApprovedOn,
                    RegistrationStatusEnumDescription.RegistrationStatusEnum(role.Status).ToString()
                ));
            }

            return roleDtos;
        }

        public async Task<List<RolesDto>> GetUnitUserRoles(int unitId)
        {

            var roles = await _roleManager.Roles
                 .Where(r => r.UnitId == unitId)
                 .OrderByDescending(role => role.CreatedOn)
                 .ToListAsync();

            var roleDtos = new List<RolesDto>();

            foreach (var role in roles)
            {
                var department = await _unitOfWork.Department.Get(role.DepartmentId);
                var unit = await _unitOfWork.DepartmentUnit.Get(role.UnitId);

                var createdByUser = await _userManager.Users
                    .Where(u => u.Id == role.CreatedBy)
                    .Select(u => (u.FirstName + " " + (string.IsNullOrEmpty(u.MiddleName) ? "" : u.MiddleName + " ") + u.LastName).Trim())
                    .FirstOrDefaultAsync();

                var approvedByUser = await _userManager.Users
                    .Where(u => u.Id == role.ApprovedBy)
                    .Select(u => (u.FirstName + " " + (string.IsNullOrEmpty(u.MiddleName) ? "" : u.MiddleName + " ") + u.LastName).Trim())
                    .FirstOrDefaultAsync();

                roleDtos.Add(new RolesDto(
                    role.Id,
                    role.Name!,
                    role.DepartmentId,
                    department?.DepartmentName ?? string.Empty,
                    role.UnitId,
                    unit?.UnitName ?? string.Empty,
                    createdByUser ?? string.Empty,
                    role.CreatedOn,
                    approvedByUser ?? string.Empty,
                    role.ApprovedOn,
                    RegistrationStatusEnumDescription.RegistrationStatusEnum(role.Status).ToString()
                ));
            }

            return roleDtos;
        }




        public async Task<CustomerVerificationResponseDto> VerifyCustomerAccount(VerifyUserAccountDto accountVerification)
        {
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


            if((UserAccountType)user.UserType != UserAccountType.Customer)
            {
                _logger.LogWarning($"User account with id {accountVerification.UserId} is not a customer account type. Account cannot be verified", accountVerification.UserId);
                return new CustomerVerificationResponseDto
                {
                    IsSuccess = false,
                    ErrorResponse = new CustomerVerificationErrorResponseDto
                    {
                        StatusCode = StatusCodes.Status404NotFound,
                        StatusMessage = $"User account with id {accountVerification.UserId} is not a customer account type. Account cannot be verified"
                    }
                };
            }


            if ((RegistrationStatus)user.Status != RegistrationStatus.Pending)
            {
                _logger.LogWarning($"User account with id {accountVerification.UserId} is not in a pending state. Account cannot be verified", accountVerification.UserId);
                return new CustomerVerificationResponseDto
                {
                    IsSuccess = false,
                    ErrorResponse = new CustomerVerificationErrorResponseDto
                    {
                        StatusCode = StatusCodes.Status404NotFound,
                        StatusMessage = $"User account with id {accountVerification.UserId} is not in a pending state. Account cannot be verified"
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

            //_unitOfWork.Users.Update(user);
            //await _unitOfWork.Complete();

            await _userManager.UpdateAsync(user);

            //_logger.LogInformation($"User account with id {user.Id} with email address {user.Email} has been successfully verified by verification officer with account id {staff.Id} and staff id {staff.IdentificationNumber}.", user.Id);
            _logger.LogInformation("User account has been successfully verified.");

            return new CustomerVerificationResponseDto
            {
                IsSuccess = true,
                SuccessResponse = new CustomerVerificationSuccessResponseDto
                {
                    StatusCode = StatusCodes.Status200OK,
                    //StatusMessage = $"User account with id '{user.Id}', with email address '{user.Email}' has been successfully verified by verification officer with account id '{staff.Id}' and staff id '{staff.IdentificationNumber}'"
                    StatusMessage = "User account has been successfully verified."

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

            var role = await _roleManager.FindByIdAsync(accountApproval.RoleId);
            if(role is null)
            {
                _logger.LogWarning($"Role Id '{accountApproval.RoleId}' not found.", accountApproval.RoleId);
                return new ApproveUserAccountResponseDto
                {
                    IsSuccess = false,
                    ErrorResponse = new ApproveUserAccountErrorResponseDto
                    {
                        StatusCode = StatusCodes.Status404NotFound,
                        StatusMessage = $"Role Id '{accountApproval.RoleId}' not found."
                    }
                };

            }

            if ((UserAccountType)user.UserType == UserAccountType.Customer && (RegistrationStatus)user.Status != RegistrationStatus.Verified)
            {
                _logger.LogWarning($"User account with id {accountApproval.UserId} is not in a verified state. Account cannot be approved", accountApproval.UserId);
                return new ApproveUserAccountResponseDto
                {
                    IsSuccess = false,
                    ErrorResponse = new ApproveUserAccountErrorResponseDto
                    {
                        StatusCode = StatusCodes.Status404NotFound,
                        StatusMessage = $"User account with id {accountApproval.UserId} is not in a verified state. Account cannot be approved"
                    }
                };

            }

            if ((UserAccountType)user.UserType != UserAccountType.Customer && (RegistrationStatus)user.Status != RegistrationStatus.Pending)
            {
                _logger.LogWarning($"User account with id {accountApproval.UserId} is not in a pending state. Account cannot be approved.", accountApproval.UserId);
                return new ApproveUserAccountResponseDto
                {
                    IsSuccess = false,
                    ErrorResponse = new ApproveUserAccountErrorResponseDto
                    {
                        StatusCode = StatusCodes.Status404NotFound,
                        StatusMessage = $"User account with id {accountApproval.UserId} is not in a pending state. Account cannot be approved."
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

            await _userManager.UpdateAsync(user);
            //_unitOfWork.Users.Update(user);
            //await _unitOfWork.Complete();

           
            _logger.LogInformation("User account with id '{UserId}' has been successfully assigned to the role '{RoleName}' and successfully approved by approval officer with account id '{StaffId}' and staff id '{StaffIdentificationNumber}'.",user.Id, roleName.Name, staff.Id, staff.IdentificationNumber);
            return new ApproveUserAccountResponseDto
            {
                IsSuccess = true,
                SuccessResponse = new ApproveUserAccountSuccessResponseDto
                {
                    StatusCode = StatusCodes.Status200OK,
                    //StatusMessage = $"User account with id '{user.Id}' has been successfully assigned to the role '{roleName!.Name!}' and successfully approved by approval officer with account id '{staff.Id}' and staff id '{staff.IdentificationNumber}'."
                    StatusMessage = $"User account has been successfully approved and assigned to a role."

                }
            };
        }

        public async Task<DisapprovedUserAccountResponseDto> DisapproveUserAccount(DisapprovedUserAccountDto accountDisapproval)
        {
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

            //if ((RegistrationStatus)user.Status != RegistrationStatus.Approved)
            //{
            //    _logger.LogWarning($"User account with id '{accountDisapproval.UserId}' has not been approved. Account cannot be disapproved", accountDisapproval.UserId);
            //    return new DisapprovedUserAccountResponseDto
            //    {
            //        IsSuccess = false,
            //        ErrorResponse = new DisapprovedUserAccountErrorResponseDto
            //        {
            //            StatusCode = StatusCodes.Status404NotFound,
            //            StatusMessage = $"User account with id '{accountDisapproval.UserId}' has not been approved. Account cannot be disapproved"
            //        }
            //    };

            //}

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
            try
            {
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


                if ((RegistrationStatus)user.Status != RegistrationStatus.Approved && (RegistrationStatus)user.Status != RegistrationStatus.Deactivated)
                {
                    _logger.LogWarning($"User account with id '{accountActivation.UserId}' has not been approved. Account cannot be activated", accountActivation.UserId);
                    return new ActivateUserAccountResponseDto
                    {
                        IsSuccess = false,
                        ErrorResponse = new ActivateUserAccountErrorResponseDto
                        {
                            StatusCode = StatusCodes.Status404NotFound,
                            StatusMessage = $"User account with id '{accountActivation.UserId}' has not been approved. Account cannot be activated"
                        }
                    };

                }
                //set temp password
                var tempPassword = PasswordGenerator.GenerateTemporaryPassword();

                //reset password with temp password to enable login...IsFirstTime would be used to re-direct to the change password section
                var token = await _userManager.GeneratePasswordResetTokenAsync(user);
                await _userManager.ResetPasswordAsync(user, token, tempPassword);

                user.Status = (int)RegistrationStatus.Activated; // 3 - activated
                user.ActivatedBy = accountActivation.activatedBy;
                user.ActivatedDate = DateTime.UtcNow;
                user.EmailConfirmed = true;
                user.PhoneNumberConfirmed = true;
                user.IsFirstTime = true;

                _unitOfWork.Users.Update(user);
                await _unitOfWork.Complete();


                //_logger.LogInformation($"User account with id '{user.Id!}', with email address {user.Email!} has been successfully activated by activation officer with account id {staff.Id!} and staff id {staff.IdentificationNumber!}.", user.Id!);

                _logger.LogInformation("User account has been successfully activated by activation officer.");

                await _notifyService.SendTemporaryPasswordEmailNotification(user, tempPassword);

                return new ActivateUserAccountResponseDto
                {
                    IsSuccess = true,
                    SuccessResponse = new ActivateUserAccountSuccessResponseDto
                    {
                        StatusCode = StatusCodes.Status200OK,
                        StatusMessage = "User account has been successfully activated by activation officer." //$"User account with id '{user.Id}', with email address '{user.Email}' has been successfully actibvated by activation officer with account id {staff.Id} and staff id {staff.IdentificationNumber}"
                    }
                };
            }
            catch (Exception ex)
            {
                return new ActivateUserAccountResponseDto
                {
                    IsSuccess = false,
                    ErrorResponse = new ActivateUserAccountErrorResponseDto
                    {
                        StatusCode = StatusCodes.Status500InternalServerError,
                        StatusMessage = ex.ToString()
                    }
                };
            }
        }

        
        public async Task<DeactivateUserAccountResponseDto> DeactivateUserAccount(DeactivateUserAccountDto accountDeactivation)
        {
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

            if ((RegistrationStatus)user.Status != RegistrationStatus.Activated)
            {
                _logger.LogWarning($"User account with id '{accountDeactivation.UserId}' is not active and cannot be deactivated", accountDeactivation.UserId);
                return new DeactivateUserAccountResponseDto
                {
                    IsSuccess = false,
                    ErrorResponse = new DeactivateUserAccountErrorResponseDto
                    {
                        StatusCode = StatusCodes.Status404NotFound,
                        StatusMessage = $"User account with id '{accountDeactivation.UserId}' is not active and cannot be deactivated."
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

        public async Task<IEnumerable<AdministrationStaffDto>> GetAdministrationStaff(string? searchParam, string? status)
        {
            var staff_UserList = (from user in await _unitOfWork.StaffAccounts.GetAll()
                                  orderby user.RegistrationDate descending
                                  select new AdministrationStaffDto
                                (
                                    user.Id,
                                    user.IdentificationNumber,
                                    user.FirstName,
                                    user.MiddleName,
                                    user.LastName,
                                    user.DepartmentName,
                                    user.UnitName,
                                    user.Email,
                                    user.PhoneNumber!,
                                    user.RoleName,
                                    RegistrationStatusEnumDescription.RegistrationStatusEnum(user.Status).ToString(),
                                    user.RegistrationDate
                                ));

            if (!string.IsNullOrWhiteSpace(status))
            {
                staff_UserList = staff_UserList.Where(s => s.Status.Contains(status));
            }

            if (!string.IsNullOrWhiteSpace(searchParam))
            {
                staff_UserList = staff_UserList.Where(s =>
                    s.FirstName!.Contains(searchParam) ||
                    s.MiddleName!.Contains(searchParam) ||
                    s.LastName!.Contains(searchParam) ||
                    s.DepartmentName!.Contains(searchParam) ||
                    s.UnitName!.Contains(searchParam) ||
                    s.IdentificationNumber!.Contains(searchParam) ||
                    s.EmailAddress!.Contains(searchParam) ||
                    s.PhoneNumber!.Contains(searchParam)
                );
            }

            return staff_UserList;

        }
 
        public async Task<IEnumerable<AdministrationCustomerDto>> GetAdministrationCustomer(string? searchParam, string? status)
        {
            var customer_UserList = (from user in await _unitOfWork.Users.GetAll(u => u.UserType == (int)UserAccountType.Customer)
                                     join channel in await _unitOfWork.Channels.GetAll()
                                     on user.ChannelId equals channel.ChannelId
                                     orderby user.RegistrationDate descending
                                     select new AdministrationCustomerDto
                                     (
                                        user.Id,
                                        user.IdentificationNumber!,
                                        $"{user.FirstName} {user.MiddleName} {user.LastName}",
                                        user.Email!,
                                        user.PhoneNumber!,
                                        user.RegistrationDate,
                                        channel.ChannelName!,
                                        RegistrationStatusEnumDescription.RegistrationStatusEnum(user.Status).ToString()

                                     ));

            if (!string.IsNullOrWhiteSpace(status))
            {
                customer_UserList = customer_UserList.Where(c => c.Status.Contains(status));
            }

            if (!string.IsNullOrWhiteSpace(searchParam))
            {
                customer_UserList = customer_UserList.Where(c =>
                    c.CustomerName.Contains(searchParam) ||
                    c.IdentificationNumber.Contains(searchParam) ||
                    c.EmailAddress.Contains(searchParam) ||
                    c.Channel.Contains(searchParam) ||
                    c.PhoneNumber.Contains(searchParam)
                );
            }

            return customer_UserList;

        }
        
        public async Task<IEnumerable<AdministrationPartnersDto>> GetAdministrationPartners(string? searchParam, string? status)
        {
            var partner_UserList = (from user in await _unitOfWork.Users.GetAll(u => u.UserType == (int)UserAccountType.Partners)
                                    orderby user.RegistrationDate descending
                                    select new AdministrationPartnersDto
                                     (
                                         user.Id,
                                         user.PartnerName!,
                                         user.Email!,
                                         user.PhoneNumber!,
                                         user.ContactPerson_FullName!,
                                         user.ContactPerson_Email!,
                                         user.ContactPerson_PhoneNumber!,
                                         user.RegistrationDate,
                                         RegistrationStatusEnumDescription.RegistrationStatusEnum(user.Status).ToString()
                                     ));

            if (!string.IsNullOrWhiteSpace(status))
            {
                partner_UserList = partner_UserList.Where(p => p.Status.Contains(status));
            }

            if (!string.IsNullOrWhiteSpace(searchParam))
            {
                partner_UserList = partner_UserList.Where(p =>
                    p.PartnerName.Contains(searchParam) ||
                    p.EmailAddress.Contains(searchParam) ||
                    p.PhoneNumber.Contains(searchParam)
                );
            }


            return partner_UserList;
        }

        public async Task<IEnumerable<AdministrationStaffDto>> GetAdministrationDepartmentStaff(int departmentId, string? searchParam, string? status)
        {
            var staff_UserList = (from user in await _unitOfWork.Users.GetAll(u => u.UserType == (int)UserAccountType.Staff)
                                  join department in await _unitOfWork.Department.GetAll()
                                      on user.DepartmentId equals department.DepartmentId
                                  join unit in await _unitOfWork.DepartmentUnit.GetAll()
                                      on user.UnitId equals unit.UnitId
                                  join usrole in await _unitOfWork.UsersRoles.GetAll()
                                      on user.Id equals usrole.UserId
                                  join role in await _unitOfWork.Roles.GetAll()
                                      on usrole.RoleId equals role.Id
                                  where user.DepartmentId == departmentId
                                  orderby user.RegistrationDate descending
                                  select new AdministrationStaffDto
                                  (
                                      user.Id,
                                      user.IdentificationNumber!,
                                      user.FirstName!,
                                      user.MiddleName!,
                                      user.LastName!,
                                      department.DepartmentName,
                                      unit.UnitName,
                                      user.Email!,
                                      user.PhoneNumber!,
                                      role.Name!,
                                      RegistrationStatusEnumDescription.RegistrationStatusEnum(user.Status).ToString(),
                                      user.RegistrationDate
                                  ));

            if (!string.IsNullOrWhiteSpace(status))
            {
                staff_UserList = staff_UserList.Where(s => s.Status.Contains(status));
            }

            if (!string.IsNullOrWhiteSpace(searchParam))
            {
                staff_UserList = staff_UserList.Where(s =>
                    s.FirstName!.Contains(searchParam) ||
                    s.MiddleName!.Contains(searchParam) ||
                    s.LastName!.Contains(searchParam) ||
                    s.DepartmentName!.Contains(searchParam) ||
                    s.UnitName!.Contains(searchParam) ||
                    s.IdentificationNumber!.Contains(searchParam) ||
                    s.EmailAddress!.Contains(searchParam) ||
                    s.PhoneNumber!.Contains(searchParam)
                );
            }

            return staff_UserList;

        }

        public async Task<IEnumerable<AdministrationStaffDto>> GetAdministrationDepartmentUnitStaff(int unitId, string? searchParam, string? status)
        {
            //throw new NotImplementedException();
            var staff_UserList = (from user in await _unitOfWork.Users.GetAll(u => u.UserType == (int)UserAccountType.Staff)
                                  join department in await _unitOfWork.Department.GetAll()
                                      on user.DepartmentId equals department.DepartmentId
                                  join unit in await _unitOfWork.DepartmentUnit.GetAll()
                                      on user.UnitId equals unit.UnitId
                                  join usrole in await _unitOfWork.UsersRoles.GetAll()
                                      on user.Id equals usrole.UserId
                                  join role in await _unitOfWork.Roles.GetAll()
                                      on usrole.RoleId equals role.Id
                                  where user.UnitId == unitId
                                  orderby user.RegistrationDate descending
                                  select new AdministrationStaffDto
                                  (
                                      user.Id,
                                      user.IdentificationNumber!,
                                      user.FirstName!,
                                      user.MiddleName!,
                                      user.LastName!,
                                      department.DepartmentName,
                                      unit.UnitName,
                                      user.Email!,
                                      user.PhoneNumber!,
                                      role.Name!,
                                      RegistrationStatusEnumDescription.RegistrationStatusEnum(user.Status).ToString(),
                                      user.RegistrationDate
                                  ));

            if (!string.IsNullOrWhiteSpace(status))
            {
                staff_UserList = staff_UserList.Where(s => s.Status.Contains(status));
            }

            if (!string.IsNullOrWhiteSpace(searchParam))
            {
                staff_UserList = staff_UserList.Where(s =>
                    s.FirstName!.Contains(searchParam) ||
                    s.MiddleName!.Contains(searchParam) ||
                    s.LastName!.Contains(searchParam) ||
                    s.DepartmentName!.Contains(searchParam) ||
                    s.UnitName!.Contains(searchParam) ||
                    s.IdentificationNumber!.Contains(searchParam) ||
                    s.EmailAddress!.Contains(searchParam) ||
                    s.PhoneNumber!.Contains(searchParam)
                );
            }

            return staff_UserList;
        }
    }
}

