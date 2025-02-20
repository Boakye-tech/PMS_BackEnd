// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860


using System.ComponentModel;
using System.Reflection;
using Asp.Versioning;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Modules.Users.Application.Dtos.Entities;
using Modules.Users.Application.Dtos.Entities.Menu;
using Modules.Users.Application.Dtos.Entities.Permissions;
using Modules.Users.Application.Enums;
using Modules.Users.Application.UseCases;

namespace Modules.Users.Presentation.Controllers.v1
{
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [Produces("application/json")]

    //[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    //[Authorize(Policy = "Permission:Users.READ")]

    public class AdministrationController : ControllerBase
    {
        readonly IAdministrationService _adminService;
        readonly IMenuService _menuService;
        readonly IDepartmentService _departmentService;
        readonly IDepartmentUnitService _departmentUnitService;
        readonly IChannelService _channelService;
        readonly IIdentificationTypeService _identificationTypeService;

        public AdministrationController(IAdministrationService adminService, IDepartmentService departmentService, IDepartmentUnitService departmentUnitService, IMenuService menuService, IChannelService channelService, IIdentificationTypeService identificationTypeService)
        {
            _adminService = adminService;
            _menuService = menuService;
            _departmentService = departmentService;
            _departmentUnitService = departmentUnitService;
            _channelService = channelService;
            _identificationTypeService = identificationTypeService;
        }

        //----------------------CHANNELS------------
        /// <summary>
        /// Returns a list of exisitng channels
        /// </summary>
        [HttpGet]
        [Route("GetChannels")]
        public async Task<ActionResult<IEnumerable<ChannelReadDto>>> GetChannels()
        {
            return Ok(await _channelService.GetChannelAsync());
        }


        //[Authorize(Policy = "Permission:Users.CREATE")]
        [HttpPost]
        [Route("CreateChannel")]
        public async Task<ActionResult<ChannelReadDto>> CreateChannel([FromBody] ChannelCreateDto values)
        {
            try
            {
                return Ok(await _channelService.AddChannelAsync(values));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.InnerException!.Message);
            }
        }

        [HttpPut]
        [Route("UpdateChannel")]
        public async Task<ActionResult<ChannelReadDto>> UpdateChannel([FromBody] ChannelUpdateDto values)
        {
            return Ok(await _channelService.UpdateChannelAsync(values));
        }

        [HttpDelete("DeleteChannel/{channelId}")]
        public void DeleteChannel(int channelId)
        { }
        


        [HttpGet]
        [Route("GetAccessMenus")]
        public async Task<AccessModulesDto> GetAccessMenus()
        {
            return await _menuService.GetAccessMenus();
        }

        [HttpGet]
        [Route("GetUserActions")]
        public IEnumerable<MenuActionsDto> GetUserActions()
        {
            return _menuService.GetActions();
        }

        [HttpGet]
        [Route("GetMenus")]
        public async Task<IEnumerable<MenusDto>> GetMenus()
        {
            return await _menuService.GetMenus();
        }

        [HttpPost]
        [Route("CreateMenus")]
        public async Task<ActionResult> CreateMenus([FromBody] MenusDto values)
        {
            var result = await _menuService.CreateMenu(values);
            return Ok(result);
        }

        [HttpGet]
        [Route("GetSubMenus")]
        public async Task<IEnumerable<SubMenusDto>> GetSubMenus()
        {
            return await _menuService.GetSubMenus();
        }

        [HttpPost]
        [Route("CreateSubMenus")]
        public async Task<ActionResult> CreateSubMenus([FromBody] SubMenusCreateDto values)
        {
            var result = await _menuService.CreateSubMenu(values);
            return Ok(result);
        }

        [HttpGet]
        [Route("GetSubMenuItems")]
        public async Task<IEnumerable<SubMenuItemsDto>> GetSubMenuItems()
        {
            return await _menuService.GetSubMenuItems();
        }

        [HttpGet]
        [Route("GetApplicationModules")]
        public async Task<IEnumerable<ApplicationModulesDto>> GetApplicationModules()
        {
            return await _menuService.GetModules();
        }

        [HttpPost]
        [Route("AddApplicationModules")]
        public async Task<ActionResult> AddApplicationModules([FromBody] ApplicationModulesCreateDto values)
        {
            var result = await _menuService.AddModules(values);
            return Ok(result);
        }

        [HttpPut]
        [Route("UpdateApplicationModules")]
        public async Task<ActionResult> UpdateApplicationModules([FromBody] ApplicationModulesDto values)
        {
            var result = await _menuService.UpdateModules(values);
            return Ok(result);
        }


        [HttpPost]
        [Route("AssignModulePermission")]
        public async Task<ActionResult> AssignModulePermission([FromBody] ApplicationModulesPermissionsDto values)
        {
            var result = await _menuService.AssignModulePermission(values);
            return Ok(result);
        }

        [HttpGet]
        [Route("GetAssignedModulesPermissions/{roleId}")]
        public async Task<IEnumerable<RoleModulesPermissionsDto>> GetApplicationModulesPermissions(string roleId)
        {
            return await _menuService.GetModulesPermissions(roleId);
        }

        [HttpPost]
        [Route("CreateSubMenuItems")]
        public async Task<ActionResult> CreateSubMenuItems([FromBody] SubMenuItemsCreateDto values)
        {
            var result = await _menuService.CreateSubMenuItems(values);
            return Ok(result);
        }


        /// <summary>
        /// Returns all approved system user roles
        /// </summary>
        [HttpPost]
        [Route("ApproveRole")]
        public async Task<ActionResult> ApproveRole([FromBody] RolesApprovalDto values)
        {
            var result = await _adminService.ApproveUserRole(values);
            return Ok(result);
        }

        /// <summary>
        /// Returns all approved system user roles
        /// </summary>
        [HttpPost]
        [Route("DisapproveRole")]
        public async Task<ActionResult> DisapproveRole([FromBody] RolesApprovalDto values)
        {
            var result = await _adminService.ApproveUserRole(values);
            return Ok(result);
        }

        /// <summary>
        /// Returns all approved system user roles
        /// </summary>
        // GET: api/values
        [HttpGet]
        [Route("GetApprovedUserRoles")]
        public IEnumerable<RolesDto> GetApprovedUserRoles()
        {
            return _adminService.GetApprovedUserRoles();
        }


        /// <summary>
        /// Returns all system user roles
        /// </summary>
        // GET: api/values
        [HttpGet]
        [Route("GetUserRoles")]
        //public IEnumerable<IdentityRole> GetUserRoles()
        public IEnumerable<RolesDto> GetUserRoles()
        {
            return _adminService.GetUserRoles();
        }

        [HttpPost]
        [Route("CreateUserRole")]
        public async Task<ActionResult> CreateUserRole([FromBody] RolesCreateDto values)
        {
            var result = await _adminService.CreateUserRole(values);
            
            if (result.Succeeded)
            {
                return Ok(result.ToString());
            }

            if (!result.Succeeded)
            {
                return BadRequest(result.Errors);
            }

            return BadRequest(result);
        }

        [HttpPut]
        [Route("UpdateUserRole")]
        public async Task<ActionResult> UpdateUserRole([FromBody] RolesUpdateDto values)
        {
            var result = await _adminService.UpdateUserRole(values);

            if (result.Succeeded)
            {
                return Ok(result.ToString());
            }

            if (!result.Succeeded)
            {
                return BadRequest(result.Errors);
            }

            return BadRequest(result);
        }

        [HttpDelete]
        [Route("DeleteUserRole")]
        public async Task<ActionResult> DeleteUserRole([FromBody] RolesDeleteDto values)
        {
            var result = await _adminService.DeleteUserRole(values);

            if (result.Succeeded)
            {
                return Ok(result.ToString());
            }

            if (!result.Succeeded)
            {
                return BadRequest(result.Errors);
            }

            return BadRequest(result);
        }

        //approve role

        /// <summary>
        /// assigns an existing role to an existing user
        /// </summary>
        [HttpPost]
        [Route("AssignRoleToUser")]
        public async Task<ActionResult> AssignRoleToUser([FromBody] AssignUserRoleDto values)
        {
            var result = await _menuService.AssignUserRole(values);

            if(result is null)
            {
                return BadRequest($"Email Address {values.EmailAddress} provided does not exist");
            }

            if (result!.Succeeded)
            {
                return Ok(result);
            }

            return BadRequest(result.Errors);

        }


        [HttpPost]
        [Route("AssignPermissionsToRole")]
        public async Task<ActionResult> AssignPermissionsToRole([FromBody] PermissionsAccessModulesDto values)
        {
            return Ok(await _menuService.AssignPermissionToRole(values));
        }

        [HttpGet]
        [Route("GetUserPermissions/{userId}")]
        public Task<IEnumerable<PermissionsAccessModulesReadDto>> GetUserPermissions(string userId)
        {
            return null!;
            //return await _menuService.GetUserRolePermissions(userId);
        }

        [HttpGet]
        [Route("GetRolePermissions/{roleId}")]
        public async Task<PermissionsAccessModulesReadDto> GetRolePermissions(string roleId)
        {
            return await _menuService.GetRolesPermissions(roleId);
        }

        [HttpPut]
        [Route("UpdatePermissionsAssignedToRole")]
        public async Task<ActionResult> UpdatePermissionsAssignedToRole([FromBody] PermissionsAccessModulesReadDto values)
        {
            return Ok(await _menuService.UpdatePermissionsAssignedToRole(values));
        }

        [HttpPut]
        [Route("VerifyUserAccount")]
        public async Task<ActionResult> VerifyUserAccount([FromBody] VerifyUserAccountDto values)
        {
            var result = await _adminService.VerifyCustomerAccount(values);

            if(result.IsSuccess)
            {
                return Ok(result.SuccessResponse);
            }

            return Problem(result.ErrorResponse?.StatusMessage ?? "An unexpected error occurred.");
        }

        [HttpPut]
        [Route("RejectUserAccount")]
        public async Task<ActionResult> RejectUserAccount([FromBody] RejectUserAccountDto values)
        {
            var result = await _adminService.RejectCustomerAccount(values);

            if (result.IsSuccess)
            {
                return Ok(result.SuccessResponse);
            }

            return Problem(result.ErrorResponse?.StatusMessage ?? "An unexpected error occurred.");
        }

        [HttpPut]
        [Route("ApproveUserAccount")]
        public async Task<ActionResult> ApproveUserAccount([FromBody] ApproveUserAccountDto values)
        {
            var result = await _adminService.ApproveUserAccount(values);

            if (result.IsSuccess)
            {
                return Ok(result.SuccessResponse);
            }

            return Problem(result.ErrorResponse?.StatusMessage ?? "An unexpected error occurred.");
        }

        [HttpPut]
        [Route("DisapproveUserAccount")]
        public async Task<ActionResult> DisapproveUserAccount([FromBody] DisapprovedUserAccountDto values)
        {
            var result = await _adminService.DisapproveUserAccount(values);

            if (result.IsSuccess)
            {
                return Ok(result.SuccessResponse);
            }

            return Problem(result.ErrorResponse?.StatusMessage ?? "An unexpected error occurred.");
        }

        [HttpPut]
        [Route("ActivateUserAccount")]
        public async Task<ActionResult> ActivateUserAccount([FromBody] ActivateUserAccountDto values)
        {
            var result = await _adminService.ActivateUserAccount(values);

            if (result.IsSuccess)
            {
                return Ok(result.SuccessResponse);
            }

            return Problem(result.ErrorResponse?.StatusMessage ?? "An unexpected error occurred.");
        }

        [HttpPut]
        [Route("DeactivateUserAccount")]
        public async Task<ActionResult> DectivateUserAccount([FromBody] DeactivateUserAccountDto values)
        {
            var result = await _adminService.DeactivateUserAccount(values);

            if (result.IsSuccess)
            {
                return Ok(result.SuccessResponse);
            }

            return Problem(result.ErrorResponse?.StatusMessage ?? "An unexpected error occurred.");
        }


        //----------------------DEPARTMENT------------
        /// <summary>
        /// Returns a list of exisitng departments
        /// </summary>
        [HttpGet]
        [Route("GetDepartments")]
        public async Task<ActionResult<IEnumerable<DepartmentReadDto>>> GetDepartments()
        {
            return Ok(await _departmentService.GetDepartmentAsync());
        }

        /// <summary>
        /// Returns a list of exsiting units in a specific department
        /// </summary>
        [HttpGet]
        [Route("GetDepartmentUnits/{departmentId}")]
        public async Task<ActionResult<IEnumerable<UnitReadDto>>> GetDepartmentUnits(int departmentId)
        {
            return Ok(await _departmentUnitService.GetUnitAsync(departmentId));
        }

        [HttpGet]
        [Route("GetDepartment/{value}")]
        private async Task<ActionResult<DepartmentReadDto>> GetDepartment(string value)
        {
            return Ok(await _departmentService.GetDepartmentAsync(value));
        }

        [HttpGet]
        [Route("GetDepartmentById/{departmentId}")]
        private async Task<ActionResult<DepartmentReadDto>> GetDepartmentById(int departmentId)
        {
            return Ok(await _departmentService.GetDepartmentAsync(departmentId));
        }

        [HttpPost]
        [Route("CreateDepartment")]
        public async Task<ActionResult<DepartmentReadDto>> CreateDepartment([FromBody] DepartmentCreateDto values)
        {
            try
            {
                return Ok(await _departmentService.AddDepartmentAsync(values));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.InnerException!.Message);
            }
        }

        [HttpPut]
        [Route("UpdateDepartment")]
        public async Task<ActionResult<DepartmentReadDto>> UpdateDepartment([FromBody] DepartmentUpdateDto values)
        {
            return Ok(await _departmentService.UpdateDepartmentAsync(values));
        }

        [HttpDelete("DeleteDepartment/{departmentId}")]
        public void DeleteDepartment(int departmentId)
        { }

        //----------------------DEPARTMENT UNIT------------
        /// <summary>
        /// Returns a list of exsiting units in department
        /// </summary>
        [HttpGet]
        [Route("GetDepartmentUnits")]
        public async Task<ActionResult<IEnumerable<DepartmentUnitReadDto>>> GetDepartmentUnits()
        {
            return Ok(await _departmentUnitService.GetDepartmentUnitAsync());
        }

        [HttpGet]
        [Route("GetDepartmentUnit/{value}")]
        private async Task<ActionResult<DepartmentReadDto>> GetDepartmentUnit(string value)
        {
            return Ok(await _departmentUnitService.GetDepartmentUnitAsync(value));
        }

        [HttpGet]
        [Route("GetDepartmentUnitsByDepartmentId/{departmentId}")]
        public async Task<ActionResult<IEnumerable<DepartmentUnitReadDto>>> GetDepartmentUnitsByDepartmentId(int departmentId)
        {
            return Ok(await _departmentUnitService.GetDepartmentUnitAsync(departmentId));
        }

        [HttpGet]
        [Route("GetDepartmentUnitById/{departmentUnitId}")]
        private async Task<ActionResult<DepartmentReadDto>> GetDepartmentUnitById(int departmentUnitId)
        {
            return Ok(await _departmentUnitService.GetDepartmentUnitAsync(departmentUnitId));
        }

        [HttpPost]
        [Route("CreateDepartmentUnit")]
        public async Task<ActionResult<DepartmentUnitReadDto>> CreateDepartmentUnit([FromBody] DepartmentUnitCreateDto values)
        {
            try
            {
                return Ok(await _departmentUnitService.AddDepartmentUnitAsync(values));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.InnerException!.Message);
            }
        }

        [HttpPut]
        [Route("UpdateDepartmentUnit")]
        public async Task<ActionResult<DepartmentReadDto>> UpdateDepartmentUnit([FromBody] DepartmentUnitUpdateDto values)
        {
            return Ok(await _departmentUnitService.UpdateDepartmentUnitAsync(values));
        }

        [HttpDelete("DeleteDepartmentUnit/{departmentUnitId}")]
        public void DeleteDepartmentUnit(int departmentUnitId)
        {
        }

        [HttpGet]
        [Route("RegistrationStatus")]
        [AllowAnonymous]
        public IActionResult GetRegistrationStatus()
        {
            var types = Enum.GetValues(typeof(RegistrationStatus))
                                   .Cast<RegistrationStatus>()
                                   .Select(e => new
                                   {
                                       Id = (int)e,
                                       Name = e.ToString(),
                                       DisplayName = e.GetType()
                                                     .GetField(e.ToString())!
                                                     .GetCustomAttribute<DescriptionAttribute>()?
                                                     .Description

                                   });
            return Ok(types);
        }

        //----------------------IDENTIFICATION TYPES------------
        /// <summary>
        /// Returns a list of identification types
        /// </summary>
        [HttpGet]
        [Route("GetIdentificationTypes")]
        public async Task<ActionResult<IEnumerable<IIdentificationTypeService>>> GetIdentificationTypes()
        {
            return Ok(await _identificationTypeService.GetIdentificationTypeAsync());
        }


        [HttpPost]
        [Route("CreateIdentificationType")]
        public async Task<ActionResult<ChannelReadDto>> CreateIdentificationType([FromBody] IdentificationTypeDto values)
        {
            try
            {
                await _identificationTypeService.AddIdentificationTypeAsync(values);
                return Ok( new { response = "200" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.InnerException!.Message);
            }
        }

        [HttpPut]
        [Route("UpdateIdentificationType")]
        public async Task<ActionResult<ChannelReadDto>> UpdateIdentificationType([FromBody] IdentificationTypeDto values)
        {
            await _identificationTypeService.UpdateIdentificationTypeAsync(values);
            return Ok(new { response = "200" });
        }

        [HttpDelete("DeleteIdentificationType/{identificationTypeId}")]
        public async Task<ActionResult> DeleteIdentificationType(int identificationTypeId)
        {
            await _identificationTypeService.DeleteIdentificationTypeAsync(identificationTypeId);
            return Ok(new { response = "200" });
        }



        /// <summary>
        /// Returns a list of system registered staff users
        /// </summary>
        [HttpGet]
        [Route("StaffAccounts")]
        public async Task<ActionResult<IEnumerable<AdministrationStaffDto>>> GetAdministrationStaff()
        {
            return Ok(await _adminService.GetAdministrationStaff());
        }

        /// <summary>
        /// Returns a list of system registered customer users
        /// </summary>
        [HttpGet]
        [Route("CustomerAccounts")]
        public async Task<ActionResult<IEnumerable<AdministrationCustomerDto>>> GetAdministrationCustomers()
        {
            return Ok(await _adminService.GetAdministrationCustomer());
        }

        /// <summary>
        /// Returns a list of system registered 3rd Party users (i.e. Parrtner Banks)
        /// </summary>
        [HttpGet]
        [Route("ThirdPartyAccounts")]
        public async Task<ActionResult<IEnumerable<AdministrationPartnersDto>>> GetAdministrationPartner()
        {
            return Ok(await _adminService.GetAdministrationPartners());
        }


        /// <summary>
        /// Returns a list of system registered staff users for a specific department
        /// </summary>
        [HttpGet]
        [Route("DepartmentStaffAccounts/{departmentId}")]
        public async Task<ActionResult<IEnumerable<AdministrationStaffDto>>> GetAdministrationDepartmentStaff(int departmentId)
        {
            return Ok(await _adminService.GetAdministrationDepartmentStaff(departmentId));
        }

        /// <summary>
        /// Returns a list of system registered staff users for a specific department unit
        /// </summary>
        [HttpGet]
        [Route("DepartmentUnitStaffAccounts/{unitId}")]
        public async Task<ActionResult<IEnumerable<AdministrationStaffDto>>> GetAdministrationDepartmentUnitStaff(int unitId)
        {
            return Ok(await _adminService.GetAdministrationDepartmentUnitStaff(unitId));
        }


    }
}

