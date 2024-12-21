using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Modules.Users.Application.Dtos.Administration;
using Modules.Users.Application.Dtos.UserAccounts;
using Modules.Users.Application.Interfaces.UserAccounts;
using Modules.Users.Application.Shared;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Modules.Users.Presentation.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AdministrationController : ControllerBase
    {
        IAdministrationService _adminService;

        public AdministrationController(IAdministrationService adminService)
        {
            _adminService = adminService;
        }

        /// <summary>
        /// Returns all system user roles
        /// </summary>
        // GET: api/values
        [HttpGet]
        [Route("GetUserRoles")]
        public IEnumerable<IdentityRole> GetUserRoles()
        {
            return _adminService.GetUserRoles();
        }

        [HttpPost]
        [Route("CreateUserRole")]
        public async Task<ActionResult> CreateUserRole([FromBody] RolesDto values)
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

