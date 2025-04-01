using System.ComponentModel;
using System.Reflection;
using Asp.Versioning;
using Azure;
using Modules.Users.Domain.Entities;


namespace Modules.Users.Presentation.Controllers.v1
{
    /// <summary>
    /// Controller for administering user account processes and activities.
    /// </summary>
    /// <remarks>
    /// This controller contains endpoints for handling all account administration related routes and processes.
    /// </remarks>
    /// 
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [Produces("application/json")]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    [Authorize(Policy = "Permission:Users.READ")]


    public class AdministrationController : ControllerBase
    {
        readonly IAdministrationService _adminService;
        readonly IMenuService _menuService;
        readonly IDepartmentService _departmentService;
        readonly IDepartmentUnitService _departmentUnitService;
        readonly IChannelService _channelService;
        readonly IIdentificationTypeService _identificationTypeService;
        private readonly IUserContextService _userContextService;

        /// <summary>
        /// Dependency injection via administration controller contstructor.
        /// </summary>
        public AdministrationController(IAdministrationService adminService, IDepartmentService departmentService, IDepartmentUnitService departmentUnitService, IMenuService menuService, IChannelService channelService, IIdentificationTypeService identificationTypeService, IUserContextService userContextService)
        {
            _adminService = adminService;
            _menuService = menuService;
            _departmentService = departmentService;
            _departmentUnitService = departmentUnitService;
            _channelService = channelService;
            _identificationTypeService = identificationTypeService;
            _userContextService = userContextService;
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

        /// <summary>
        /// Creates a new valid channels
        /// </summary>
        [HttpPost]
        [Route("CreateChannel")]
        [Authorize(Policy = "Permission:Users.CREATE")]
        public async Task<ActionResult<ChannelReadDto>> CreateChannel([FromBody] ChannelCreateDto values)
        {
            try
            {
                var userId = _userContextService.GetUserId();
                if (!string.Equals(userId, values.CreatedBy))
                {
                    return Unauthorized();
                }

                var result = await _channelService.AddChannelAsync(values);
                if (result is null)
                {
                    return BadRequest(result);
                }

                return StatusCode(StatusCodes.Status201Created, result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.InnerException!.Message);
            }
        }

        /// <summary>
        /// Modifies details of an exisitng channel
        /// </summary>
        [HttpPut]
        [Route("UpdateChannel")]
        [Authorize(Policy = "Permission:Users.UPDATE")]
        public async Task<ActionResult<ChannelReadDto>> UpdateChannel([FromBody] ChannelUpdateDto values)
        {
            var userId = _userContextService.GetUserId();
            if (!string.Equals(userId, values.ModifiedBy))
            {
                return Unauthorized();
            }

            var result = await _channelService.UpdateChannelAsync(values);
            if (result is null)
            {
                return BadRequest();
            }

            return Ok(result);
        }

        /// <summary>
        /// removes an exisitng channel
        /// </summary>
        [HttpDelete("DeleteChannel/{channelId}")]
        public async Task<ActionResult> DeleteChannel(int channelId)
        {
            var response = await _channelService.DeleteChannelAsync(channelId);

            if (response == "success")
            {
                return Ok(await _channelService.DeleteChannelAsync(channelId));
            }

            return BadRequest();
        }


        /// <summary>
        /// Returns a list of access menus
        /// </summary>
        [HttpGet]
        [Route("GetAccessMenus")]
        public async Task<AccessModulesDto> GetAccessMenus()
        {
            return await _menuService.GetAccessMenus();
        }

        /// <summary>
        /// Returns a list of user menu actions
        /// </summary>
        [HttpGet]
        [Route("GetUserActions")]
        public IEnumerable<MenuActionsDto> GetUserActions()
        {
            return _menuService.GetActions();
        }

        /// <summary>
        /// Returns a list of menus
        /// </summary>
        [HttpGet]
        [Route("GetMenus")]
        public async Task<IEnumerable<MenusDto>> GetMenus()
        {
            return await _menuService.GetMenus();
        }

        /// <summary>
        /// Add a new menu
        /// </summary>
        [HttpPost]
        [Route("CreateMenus")]
        [Authorize(Policy = "Permission:Users.CREATE")]
        public async Task<ActionResult> CreateMenus([FromBody] MenusDto values)
        {
            var result = await _menuService.CreateMenu(values);
            return Ok(result);
        }

        /// <summary>
        /// Returns a list of sub menus
        /// </summary>
        [HttpGet]
        [Route("GetSubMenus")]
        public async Task<IEnumerable<SubMenusDto>> GetSubMenus()
        {
            return await _menuService.GetSubMenus();
        }

        /// <summary>
        /// Add a new sub menu
        /// </summary>
        [HttpPost]
        [Route("CreateSubMenus")]
        [Authorize(Policy = "Permission:Users.CREATE")]
        public async Task<ActionResult> CreateSubMenus([FromBody] SubMenusCreateDto values)
        {
            var result = await _menuService.CreateSubMenu(values);
            return Ok(result);
        }

        /// <summary>
        /// Returns a list of sub menus items
        /// </summary>
        [HttpGet]
        [Route("GetSubMenuItems")]
        public async Task<IEnumerable<SubMenuItemsDto>> GetSubMenuItems()
        {
            return await _menuService.GetSubMenuItems();
        }

        /// <summary>
        /// Returns a list of application modules
        /// </summary>
        [HttpGet]
        [Route("GetApplicationModules")]
        [AllowAnonymous]
        public async Task<IEnumerable<ApplicationModulesDto>> GetApplicationModules()
        {
            return await _menuService.GetModules();
        }

        /// <summary>
        /// Create a new application module
        /// </summary>
        [HttpPost]
        [Route("AddApplicationModules")]
        [AllowAnonymous]
        public async Task<ActionResult> AddApplicationModules([FromBody] ApplicationModulesCreateDto values)
        {
            return Ok(await _menuService.AddModules(values));
        }

        /// <summary>
        /// Modify existing application module details
        /// </summary>
        [HttpPut]
        [Route("UpdateApplicationModules")]
        [AllowAnonymous]
        public async Task<ActionResult> UpdateApplicationModules([FromBody] ApplicationModulesDto values)
        {
            return Ok(await _menuService.UpdateModules(values));
        }

        /// <summary>
        /// Assign list of permissions to a specific application module
        /// </summary>
        [HttpPost]
        [Route("AssignModulePermission")]
        [AllowAnonymous]
        public async Task<ActionResult> AssignModulePermission([FromBody] ApplicationModulesPermissionsDto values)
        {
            return Ok(await _menuService.AssignModulePermission(values));
        }

        /// <summary>
        /// Returns a list of assigned permissions to various modules for a specific user role
        /// </summary>
        [HttpGet]
        [Route("GetAssignedModulesPermissions/{roleId}")]
        [AllowAnonymous]
        public async Task<IEnumerable<RoleModulesPermissionsDto>> GetApplicationModulesPermissions(string roleId)
        {
            return await _menuService.GetModulesPermissions(roleId);
        }

        /// <summary>
        /// Add new sub menu items
        /// </summary>
        [HttpPost]
        [Route("CreateSubMenuItems")]
        [Authorize(Policy = "Permission:Users.CREATE")]
        public async Task<ActionResult> CreateSubMenuItems([FromBody] SubMenuItemsCreateDto values)
        {
            return Ok(await _menuService.CreateSubMenuItems(values));
        }


        /// <summary>
        /// Returns all approved system user roles
        /// </summary>
        [HttpPost]
        [Route("ApproveRole")]
        [Authorize(Policy = "Permission:Users.APPROVE", Roles = "MISAdministrator")]
        public async Task<ActionResult> ApproveRole([FromBody] RolesApprovalDto values)
        {
            var userId = _userContextService.GetUserId();
            if (!string.Equals(userId, values.ApprovedBy))
            {
                return Unauthorized();
            }
            return Ok(await _adminService.ApproveUserRole(values));
        }

        /// <summary>
        /// Returns all approved system user roles
        /// </summary>
        [HttpPost]
        [Route("DisapproveRole")]
        [Authorize(Policy = "Permission:Users.DISAPPROVE", Roles = "MISAdministrator")]
        public async Task<ActionResult> DisapproveRole([FromBody] RolesApprovalDto values)
        {
            var userId = _userContextService.GetUserId();
            if (!string.Equals(userId, values.ApprovedBy))
            {
                return Unauthorized();
            }
            return Ok(await _adminService.ApproveUserRole(values));
            
        }

        /// <summary>
        /// Returns all approved system user roles
        /// </summary>
        // GET: api/values
        [HttpGet]
        [Route("GetApprovedUserRoles")]
        public async Task<List<RolesDto>> GetApprovedUserRoles([FromQuery] int departmentId, [FromQuery] int unitId)
        {
            if ((bool)_userContextService.GetUserRole("MISAdministrator")!)
            {
                return await _adminService.GetApprovedUserRoles();
            }

            if(unitId != 0)
            {
                return await _adminService.GetDepartmentUnitUserRoles(unitId);
            }

            return await _adminService.GetDepartmentUserRoles(departmentId);

        }

        /// <summary>
        /// Returns all approved system user roles based on a specific department
        /// </summary>
        // GET: api/values
        [HttpGet]
        [Route("GetDepartmentUserRoles/{departmentId}")]
        [Obsolete("GetDepartmentUserRoles is obsolete and will be removed in a future release.")]
        public async Task<List<RolesDto>> GetDepartmentUserRoles(int departmentId)
        {
            return await _adminService.GetDepartmentUserRoles(departmentId);
        }

        /// <summary>
        /// Returns all approved system user roles based on a specific department unit
        /// </summary>
        // GET: api/values
        [HttpGet]
        [Route("GetDepartmentUnitUserRoles/{unitId}")]
        [Obsolete("GetDepartmentUnitUserRoles is obsolete and will be removed in a future release.")]
        public async Task<List<RolesDto>> GetDepartmentUnitUserRoles(int unitId)
        {
            return await _adminService.GetDepartmentUnitUserRoles(unitId);
        }

        /// <summary>
        /// Returns all the rejected system user roles
        /// </summary>
        // GET: api/values
        [HttpGet]
        [Route("GetRejectedUserRoles")]
        [Obsolete("GetRejectedUserRoles is obsolete and will be removed in a future release. Use GetUserRoles with 'Rejected' status instead.")]
        public async Task<List<RolesDto>> GetRejectedUserRoles()
        {
            return await _adminService.GetRejectedUserRoles();
        }

        /// <summary>
        /// Returns all system user roles
        /// </summary>
        // GET: api/values
        [HttpGet]
        [Route("GetUserRoles")]
        public async Task<List<RolesDto>> GetUserRoles([FromQuery] int departmentId, [FromQuery] int unitId)
        {
            if ((bool)_userContextService.GetUserRole("MISAdministrator")!)
            {
                return await _adminService.GetUserRoles();
            }

            if (unitId != 0)
            {
                return await _adminService.GetUnitUserRoles(unitId);
            }

            return await _adminService.GetUserRoles(departmentId);

        }

        /// <summary>
        /// Add a new system user roles
        /// </summary>
        [HttpPost]
        [Route("CreateUserRole")]
        [Authorize(Policy = "Permission:Users.CREATEROLE")]
        public async Task<ActionResult> CreateUserRole([FromBody] RolesCreateDto values)
        {
            var userId = _userContextService.GetUserId();
            if (!string.Equals(userId, values.CreatedBy))
            {
                return Unauthorized();
            }

            var result = await _adminService.CreateUserRole(values);
            
            if (result.Succeeded)
            {
                return Ok( new { message = result.ToString() });
            }

            if (!result.Succeeded)
            {
                return BadRequest(result.Errors);
            }

            return BadRequest(result);
        }

        /// <summary>
        /// Modify an existing system user role
        /// </summary>
        [HttpPut]
        [Route("UpdateUserRole")]
        [Authorize(Policy = "Permission:Users.UPDATE")]
        public async Task<ActionResult> UpdateUserRole([FromBody] RolesUpdateDto values)
        {
            var userId = _userContextService.GetUserId();
            if (!string.Equals(userId, values.ModifiedBy))
            {
                return Unauthorized();
            }

            var result = await _adminService.UpdateUserRole(values);

            if (result.Succeeded)
            {
                return Ok(new { message = result.ToString() });
            }

            if (!result.Succeeded)
            {
                return BadRequest(result.Errors);
            }

            return BadRequest(result);
        }

        /// <summary>
        /// Removes an existing system user role
        /// </summary>
        [HttpDelete]
        [Route("DeleteUserRole/{roleId}")]
        [Authorize(Policy = "Permission:Users.DELETE", Roles = "MISAdministrator")]
        public async Task<ActionResult> DeleteUserRole(string roleId)
        {
            var userId = _userContextService.GetUserId();
            //if (!string.Equals(userId, values.DeletedBy))
            //{
            //    return Unauthorized();
            //}

            RolesDeleteDto values = new RolesDeleteDto(roleId, userId!);

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


        /// <summary>
        /// Assigns an existing role to an existing user
        /// </summary>
        [HttpPost]
        [Route("AssignRoleToUser")]
        [Authorize(Policy = "Permission:Users.ASSIGNUSER")]
        public async Task<ActionResult> AssignRoleToUser([FromBody] AssignUserRoleDto values)
        {
            //var userId = _userContextService.GetUserId();
            //if (!string.Equals(userId, values.))
            //{
            //    return Unauthorized();
            //}

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

        /// <summary>
        /// Assign a list of permission to a specific user role
        /// </summary>
        [HttpPost]
        [Route("AssignPermissionsToRole")]
        [Authorize(Policy = "Permission:Users.ASSIGNPERM")]
        public async Task<ActionResult> AssignPermissionsToRole([FromBody] PermissionsAccessModulesDto values)
        {
            return Ok(await _menuService.AssignPermissionToRole(values));
        }

        /// <summary>
        /// Returns a list of permissions assigned to the role of a specific 
        /// </summary>
        [HttpGet]
        [Route("GetUserPermissions/{userId}")]
        public Task<IEnumerable<PermissionsAccessModulesReadDto>> GetUserPermissions(string userId)
        {
            return null!;
            //return await _menuService.GetUserRolePermissions(userId);
        }

        /// <summary>
        /// Returns a list of permissions assigned to a specific role 
        /// </summary>
        [HttpGet]
        [Route("GetRolePermissions/{roleId}")]
        public async Task<PermissionsAccessModulesReadDto> GetRolePermissions(string roleId)
        {
            return await _menuService.GetRolesPermissions(roleId);
        }

        /// <summary>
        /// Modify existing list of permission assigned to a specific user role
        /// </summary>
        [HttpPut]
        [Route("UpdatePermissionsAssignedToRole")]
        private async Task<ActionResult> UpdatePermissionsAssignedToRole([FromBody] PermissionsAccessModulesReadDto values)
        {
            return Ok(await _menuService.UpdatePermissionsAssignedToRole(values));
        }


        /// <summary>
        /// Verify registered user account
        /// </summary>
        [HttpPut]
        [Route("VerifyUserAccount")]
        [Authorize(Policy = "Permission:Users.VERIFY")]
        public async Task<ActionResult> VerifyUserAccount([FromBody] VerifyUserAccountDto values)
        {
            var userId = _userContextService.GetUserId();
            if (!string.Equals(userId, values.verifiedBy))
            {
                return Unauthorized();
            }

            var result = await _adminService.VerifyCustomerAccount(values);

            if(result.IsSuccess)
            {
                return Ok(result.SuccessResponse);
            }

            var status = result.ErrorResponse!.StatusCode;

            return status switch
            {
                204 => NoContent(),
                400 => BadRequest(result.ErrorResponse),
                404 => NotFound(result.ErrorResponse),
                409 => Conflict(result.ErrorResponse),
                _ => StatusCode(500, result),
            };
        }


        /// <summary>
        /// Rejected registered user account
        /// </summary>
        [HttpPut]
        [Route("RejectUserAccount")]
        [Authorize(Policy = "Permission:Users.REJECT")]
        [Obsolete]
        public async Task<ActionResult> RejectUserAccount([FromBody] RejectUserAccountDto values)
        {
            var userId = _userContextService.GetUserId();
            if (!string.Equals(userId, values.RejectedBy))
            {
                return Unauthorized();
            }

            var result = await _adminService.RejectCustomerAccount(values);

            if (result.IsSuccess)
            {
                return Ok(result.SuccessResponse);
            }

            var status = result.ErrorResponse!.StatusCode;

            return status switch
            {
                204 => NoContent(),
                400 => BadRequest(result.ErrorResponse),
                404 => NotFound(result.ErrorResponse),
                409 => Conflict(result.ErrorResponse),
                _ => StatusCode(500, result),
            };
        }


        /// <summary>
        /// Approve registered user account
        /// </summary>
        [HttpPut]
        [Route("ApproveUserAccount")]
        [Authorize(Policy = "Permission:Users.APPROVE")]
        public async Task<ActionResult> ApproveUserAccount([FromBody] ApproveUserAccountDto values)
        {
            var userId = _userContextService.GetUserId();
            if (!string.Equals(userId, values.ApprovedBy))
            {
                return Unauthorized();
            }

            var result = await _adminService.ApproveUserAccount(values);

            if (result.IsSuccess)
            {
                return Ok(result.SuccessResponse);
            }

            var status = result.ErrorResponse!.StatusCode;

            return status switch
            {
                204 => NoContent(),
                400 => BadRequest(result.ErrorResponse),
                404 => NotFound(result.ErrorResponse),
                409 => Conflict(result.ErrorResponse),
                _ => StatusCode(500, result),
            };
            
        }


        /// <summary>
        /// Disapprove registered user account
        /// </summary>
        [HttpPut]
        [Route("DisapproveUserAccount")]
        [Authorize(Policy = "Permission:Users.DISAPPROVE")]
        public async Task<ActionResult> DisapproveUserAccount([FromBody] DisapprovedUserAccountDto values)
        {
            var userId = _userContextService.GetUserId();
            if (!string.Equals(userId, values.DisapprovedBy))
            {
                return Unauthorized();
            }

            var result = await _adminService.DisapproveUserAccount(values);

            if (result.IsSuccess)
            {
                return Ok(result.SuccessResponse);
            }

            var status = result.ErrorResponse!.StatusCode;

            return status switch
            {
                204 => NoContent(),
                400 => BadRequest(result.ErrorResponse),
                404 => NotFound(result.ErrorResponse),
                409 => Conflict(result.ErrorResponse),
                _ => StatusCode(500, result),
            };
        }

        /// <summary>
        /// Activate registered user account
        /// </summary>
        [HttpPut]
        [Route("ActivateUserAccount")]
        [Authorize(Policy = "Permission:Users.ACTIVATE")] //, Roles = "MIS Officer"
        public async Task<ActionResult> ActivateUserAccount([FromBody] ActivateUserAccountDto values)
        {
            var userId = _userContextService.GetUserId();
            if (!string.Equals(userId, values.activatedBy))
            {
                return Unauthorized();
            }

            var result = await _adminService.ActivateUserAccount(values);

            if (result.IsSuccess)
            {
                return Ok(result.SuccessResponse);
            }

            var status = result.ErrorResponse!.StatusCode;

            return status switch
            {
                204 => NoContent(),
                400 => BadRequest(result.ErrorResponse),
                404 => NotFound(result.ErrorResponse),
                409 => Conflict(result.ErrorResponse),
                _ => StatusCode(500, result),
            };
        }

        /// <summary>
        /// Deactivate registered user account
        /// </summary>
        [HttpPut]
        [Route("DeactivateUserAccount")]
        [Authorize(Policy = "Permission:Users.DEACTIVATE")]
        public async Task<ActionResult> DectivateUserAccount([FromBody] DeactivateUserAccountDto values)
        {
            var userId = _userContextService.GetUserId();
            if (!string.Equals(userId, values.DeactivatedBy))
            {
                return Unauthorized();
            }

            var result = await _adminService.DeactivateUserAccount(values);

            if (result.IsSuccess)
            {
                return Ok(result.SuccessResponse);
            }

            var status = result.ErrorResponse!.StatusCode;

            return status switch
            {
                204 => NoContent(),
                400 => BadRequest(result.ErrorResponse),
                404 => NotFound(result.ErrorResponse),
                409 => Conflict(result.ErrorResponse),
                _ => StatusCode(500, result),
            };
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

        /// <summary>
        /// Returns details of an exisitng department based on the department id
        /// </summary>
        [HttpGet]
        [Route("GetDepartmentById/{departmentId}")]
        public async Task<ActionResult<DepartmentReadDto>> GetDepartmentById(int departmentId)
        {
            return Ok(await _departmentService.GetDepartmentAsync(departmentId));
        }

        /// <summary>
        /// Add a new department
        /// </summary>
        [HttpPost]
        [Route("CreateDepartment")]
        [Authorize(Policy = "Permission:Users.CREATE")]
        public async Task<ActionResult<DepartmentReadDto>> CreateDepartment([FromBody] DepartmentCreateDto values)
        {
            try
            {
                var userId = _userContextService.GetUserId();
                if (!string.Equals(userId, values.CreatedBy))
                {
                    return Unauthorized();
                }

                var result = await _departmentService.AddDepartmentAsync(values);
                if(result is null)
                {
                    return BadRequest(result);
                }

                return StatusCode(StatusCodes.Status201Created, result);
                
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.InnerException!.Message);
            }
        }

        /// <summary>
        /// Modify details of an existing department
        /// </summary>
        [HttpPut]
        [Route("UpdateDepartment")]
        [Authorize(Policy = "Permission:Users.UPDATE")]
        public async Task<ActionResult<DepartmentReadDto>> UpdateDepartment([FromBody] DepartmentUpdateDto values)
        {
            var userId = _userContextService.GetUserId();
            if (!string.Equals(userId, values.ModifiedBy))
            {
                return Unauthorized();
            }

            var result = _departmentService.GetDepartmentAsync(values.DepartmentId);
            if(result is null)
            {
                return BadRequest();
            }

            return Ok(await _departmentService.UpdateDepartmentAsync(values));
        }

        /// <summary>
        /// Delete a department based on the departmentid
        /// </summary>
        [HttpDelete("DeleteDepartment/{departmentId}")]
        public async Task<ActionResult> DeleteDepartment(int departmentId)
        {
            var result = await _departmentService.DeleteDepartment(departmentId);
            if(result.response == "success")
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        //----------------------DEPARTMENT UNIT------------
        /// <summary>
        /// Returns a list of existing units in a department
        /// </summary>
        [HttpGet]
        [Route("GetDepartmentUnits")]
        public async Task<ActionResult<IEnumerable<DepartmentUnitReadDto>>> GetDepartmentUnits()
        {
            return Ok(await _departmentUnitService.GetDepartmentUnitAsync());
        }

        /// <summary>
        /// Returns a list of existing units in department based on the department id
        /// </summary>
        [HttpGet]
        [Route("GetDepartmentUnitsByDepartmentId/{departmentId}")]
        public async Task<ActionResult<IEnumerable<DepartmentUnitReadDto>>> GetDepartmentUnitsByDepartmentId(int departmentId)
        {
            return Ok(await _departmentUnitService.GetDepartmentUnitAsync(departmentId));
        }

        /// <summary>
        /// Add a new department unit
        /// </summary>
        [HttpPost]
        [Route("CreateDepartmentUnit")]
        [Authorize(Policy = "Permission:Users.CREATE")]
        public async Task<ActionResult<DepartmentUnitReadDto>> CreateDepartmentUnit([FromBody] DepartmentUnitCreateDto values)
        {
            try
            {
                var userId = _userContextService.GetUserId();
                if (!string.Equals(userId, values.CreatedBy))
                {
                    return Unauthorized();
                }

                var result = await _departmentUnitService.AddDepartmentUnitAsync(values);
                if (result is null)
                {
                    return BadRequest(result);
                }

                return StatusCode(StatusCodes.Status201Created, result);

            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.InnerException!.Message);
            }
        }

        /// <summary>
        /// Modify details of an exsiting department unit 
        /// </summary>
        [HttpPut]
        [Route("UpdateDepartmentUnit")]
        public async Task<ActionResult<DepartmentReadDto>> UpdateDepartmentUnit([FromBody] DepartmentUnitUpdateDto values)
        {
            var userId = _userContextService.GetUserId();
            if (!string.Equals(userId, values.ModifiedBy))
            {
                return Unauthorized();
            }

            var result = _departmentUnitService.GetDepartmentUnitAsync(values.UnitId);
            if (result is null)
            {
                return BadRequest();
            }

            return Ok(await _departmentUnitService.UpdateDepartmentUnitAsync(values));
        }

        /// <summary>
        /// Removes an existing department unit
        /// </summary>
        [HttpDelete("DeleteDepartmentUnit/{unitId}")]
        public async Task<ActionResult> DeleteDepartmentUnit(int unitId)
        {
            var result = await _departmentUnitService.DeleteDepartmentUnit(unitId);
            if (result.response == "success")
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        /// <summary>
        /// Returns a list of registration status
        /// </summary>
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

        /// <summary>
        /// Add a new identification type
        /// </summary>
        [HttpPost]
        [Route("CreateIdentificationType")]
        [Authorize(Policy = "Permission:Users.CREATE")]
        public async Task<ActionResult<ChannelReadDto>> CreateIdentificationType([FromBody] IdentificationTypeDto values)
        {
            try
            {
                
                var result = await _identificationTypeService.AddIdentificationTypeAsync(values);
                if (result is null)
                {
                    return BadRequest(result);
                }

                return StatusCode(StatusCodes.Status201Created, new { response = result });
                
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.InnerException!.Message);
            }
        }

        /// <summary>
        /// Update an exisiting identification type
        /// </summary>
        [HttpPut]
        [Route("UpdateIdentificationType")]
        public async Task<ActionResult<ChannelReadDto>> UpdateIdentificationType([FromBody] IdentificationTypeDto values)
        {

            var result = await _identificationTypeService.UpdateIdentificationTypeAsync(values);

            if(result is null)
            {
                return BadRequest();
            }

            return Ok(new { response = result });
        }

        /// <summary>
        /// Removes an exisiting identification type based on the identification type id
        /// </summary>
        [HttpDelete("DeleteIdentificationType/{identificationTypeId}")]
        public async Task<ActionResult> DeleteIdentificationType(int identificationTypeId)
        {
            var result = await _identificationTypeService.DeleteIdentificationTypeAsync(identificationTypeId);

            if (result != "success")
                return BadRequest();

            return Ok(new { response = result });
        }



        /// <summary>
        /// Returns a list of system registered staff users
        /// </summary>
        [HttpGet]
        [Route("StaffAccounts")]
        [Authorize(Roles = "MIS Officer, MISAdministrator")]
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
        [Authorize(Roles = "MIS Officer, MISAdministrator")] 
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

