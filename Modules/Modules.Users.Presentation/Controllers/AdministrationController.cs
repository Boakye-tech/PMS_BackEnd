// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860


using Modules.Users.Application.Dtos.Entities.Menu;

namespace Modules.Users.Presentation.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AdministrationController : ControllerBase
    {
        readonly IAdministrationService _adminService;
        readonly IMenuService _menuService;

        public AdministrationController(IAdministrationService adminService, IMenuService menuService)
        {
            _adminService = adminService;
            _menuService = menuService;
        }

        //-----MENUS----
        [HttpGet]
        [Route("GetMenuActions")]
        public async Task<IEnumerable<MenusWithActionsDto>> GetMenuActions()
        {
            return await _menuService.GetMenuActions();
        }


        [HttpGet]
        [Route("GetUserActions")]
        public async Task<IEnumerable<MenuActionsDto>> GetUserActions()
        {
            return await _menuService.GetActions();
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
        //----





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

        /// <summary>
        /// assigns an existing role to an existing user
        /// </summary>
        [HttpPost]
        [Route("AssignRoleToUser")]
        public async Task<ActionResult> AssignRoleToUser([FromBody] AssignUserRoleDto values)
        {
            //var result = await _adminService.CreateUserRole(values);

            //if (result.Succeeded)
            //{
            //    return Ok(result.ToString());
            //}

            //if (!result.Succeeded)
            //{
            //    return BadRequest(result.Errors);
            //}

            //return BadRequest(result);

            return Ok();
        }

        [HttpPost]
        [Route("AssignPermissionsToRole")]
        public async Task<ActionResult> AssignPermissionsToRole([FromBody] RolesPermissionsDto values)
        {
            //var result = await _adminService.CreateUserRole(values);

            //if (result.Succeeded)
            //{
            //    return Ok(result.ToString());
            //}

            //if (!result.Succeeded)
            //{
            //    return BadRequest(result.Errors);
            //}

            //return BadRequest(result);

            return Ok();
        }

        [HttpPost]
        [Route("VerifyUserAccount")]
        public async Task<ActionResult> VerifyUserAccount([FromBody] VerifyUserAccountDto values)
        {
            //var result = await _adminService.CreateUserRole(values);

            //if (result.Succeeded)
            //{
            //    return Ok(result.ToString());
            //}

            //if (!result.Succeeded)
            //{
            //    return BadRequest(result.Errors);
            //}

            //return BadRequest(result);
            return Ok();
        }

        [HttpPost]
        [Route("ApproveUserAccount")]
        public async Task<ActionResult> ApproveUserAccount([FromBody] ApproveUserAccountDto values)
        {
            //var result = await _adminService.CreateUserRole(values);

            //if (result.Succeeded)
            //{
            //    return Ok(result.ToString());
            //}

            //if (!result.Succeeded)
            //{
            //    return BadRequest(result.Errors);
            //}

            //return BadRequest(result);
            return Ok();
        }

        [HttpPost]
        [Route("ActivateUserAccount")]
        public async Task<ActionResult> ActivateUserAccount([FromBody] ActivateUserAccountDto values)
        {
            //var result = await _adminService.CreateUserRole(values);

            //if (result.Succeeded)
            //{
            //    return Ok(result.ToString());
            //}

            //if (!result.Succeeded)
            //{
            //    return BadRequest(result.Errors);
            //}

            //return BadRequest(result);
            return Ok();
        }


    }
}

