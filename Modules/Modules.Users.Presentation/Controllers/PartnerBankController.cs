using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Modules.Users.Application.Dtos.Entities;
using Modules.Users.Application.Dtos.UserAccounts;
using Modules.Users.Application.Interfaces;
using Modules.Users.Application.Interfaces.UserAccounts;
using Modules.Users.Application.Shared;
using Modules.Users.Application.UseCases;
using Modules.Users.Application.UseCases.UserAccounts;
using Modules.Users.Domain.Entities;

namespace Modules.Users.Presentation.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PartnerBankController : ControllerBase
{
    IPartnerBankAccountService _partnerBankAccountService;

    public PartnerBankController(IPartnerBankAccountService partnerBankAccountService)
    {
        _partnerBankAccountService = partnerBankAccountService;
    }

    [HttpPost]
    [AllowAnonymous]
    [Route("Account/Register")]
    public async Task<ActionResult<RegistrationResponse>> Register([FromBody] PartnerBankRegistrationRequestDto values)
    {
        if (ModelState.IsValid)
        {
            return Ok(await _partnerBankAccountService.UserRegistration(values));
        }

        return BadRequest();
        //try
        //{
        //    return Ok(await _partnerBankAccountService.UserRegistration(values));
        //}
        //catch (Exception ex)
        //{
        //    return StatusCode(500, ex.InnerException!.Message);
        //}
    }

    /// <summary>
    /// reset the password for a forgotten registered partner user account
    /// </summary>
    [HttpPost]
    //[AllowAnonymous]
    [Route("Account/ResetPassword")]
    public async Task<IActionResult> ResetPassword([FromBody] PartnerBankResetPasswordRequestDto resetPasswordRequest)
    {
        try
        {
            if (ModelState.IsValid)
            {
                var changeResult = await _partnerBankAccountService.ResetPassword(resetPasswordRequest);
                return Ok(changeResult);
            }

            return BadRequest();
        }
        catch (Exception ex)
        {
            return StatusCode(500, ex.Message);
        }
    }


    /// <summary>
    /// Returns user details after a successful login
    /// </summary>
    [HttpPost]
    [AllowAnonymous]
    [Route("Account/GetBearerToken")]
    //[ProducesResponseType(200, Type = typeof(PartnerBankLoginRequestDto))]
    public async Task<IActionResult> GetBearerToken([FromBody] PartnerBankLoginRequestDto loginModel)
    {
        try
        {
            if (ModelState.IsValid)
            {
                var result = await _partnerBankAccountService.GetBearerToken(loginModel);
                return Ok(result);
            }

            return BadRequest();
        }
        catch (Exception ex)
        {
            return StatusCode(500, ex.Message);
        }
    }

}

