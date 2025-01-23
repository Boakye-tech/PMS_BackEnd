using System.Text.RegularExpressions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Modules.Users.Application.Dtos.Entities;
using Modules.Users.Application.Dtos.UserAccounts;
using Modules.Users.Application.Interfaces;
using Modules.Users.Application.Interfaces.UserAccounts;
using Modules.Users.Application.Shared;
using Modules.Users.Application.UseCases.UserAccounts;
using Modules.Users.Domain.Entities;

namespace Modules.Users.Presentation.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CustomerController : ControllerBase
{
    ICustomerAccountService _customerAccountService;

    public CustomerController(ICustomerAccountService customerAccountService)
    {
        _customerAccountService = customerAccountService;
    }

    /// <summary>
    /// Registers a new application user.
    /// </summary>
    /// <remarks>Returns the registration status and user id. The user and password used in a successful registration will be used to access generated a json web token that will be used to access the application</remarks>
    /// <response code="200">Returns the uniquely created user id for a newly registered application user</response>
    [HttpPost]
    [Route("Account/Register")]
    public async Task<ActionResult<RegistrationResponse>> Register([FromBody] CustomerRegistrationRequestDto values)
    {
        if (ModelState.IsValid)
        {
            return Ok(await _customerAccountService.UserRegistration(values));
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
    /// Changes the password of a registered user account
    /// </summary>
    [HttpPost]
    [AllowAnonymous]
    [Route("Account/ChangePassword")]
    public async Task<IActionResult> ChangePassword([FromBody] ChangeCustomerPasswordRequestDto changeUserPasswordRequest)
    {
        try
        {
            if (ModelState.IsValid)
            {
                var changeResult = await _customerAccountService.ChangePassword(changeUserPasswordRequest);
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
    /// reset the password for a forgotten registered user account via their registered email address or registered mobile phone number
    /// </summary>
    [HttpPost]
    [AllowAnonymous]
    [Route("Account/ResetPassword")]
    public async Task<IActionResult> ResetPasswordViaEmailAddress([FromBody] ResetPasswordRequest resetPasswordRequest)
    {
        var emailRegex = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        var phoneRegex = new Regex(@"^\+?\d{10,15}$");

        try
        {
            if (ModelState.IsValid)
            {

                if (emailRegex.IsMatch(resetPasswordRequest.Phone_OR_Email!))
                {
                    var changeResult = await _customerAccountService.ResetPasswordViaEmailAddress(resetPasswordRequest);
                    return Ok(changeResult);

                }

                if (phoneRegex.IsMatch(resetPasswordRequest.Phone_OR_Email!))
                {
                    var changeResult = await _customerAccountService.ResetPasswordViaMobilePhoneNumber(resetPasswordRequest);
                    return Ok(changeResult);

                }

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
    [Route("Account/LoginWithEmailAddress")]
    [ProducesResponseType(200, Type = typeof(CustomerLoginResponseDto))]
    public async Task<IActionResult> UserLogin([FromBody] CustomerEmailLoginRequestDto loginModel)
    {
        try
        {
            if (ModelState.IsValid)
            {
                var result = await _customerAccountService.LoginWithEmailAddress(loginModel);

                switch (result.LoginStatus)
                {
                    case true:
                        return Ok(result.successResponseDto);
                    case false:
                        return Problem(result.errorResponseDto!.StatusMessage);
                }
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
    [Route("Account/LoginWithPhoneNumber")]
    [ProducesResponseType(200, Type = typeof(CustomerLoginResponseDto))]
    public async Task<IActionResult> UserLogin([FromBody] CustomerPhoneLoginRequestDto loginModel)
    {
        try
        {
            if (ModelState.IsValid)
            {
                var result = await _customerAccountService.LoginWithMobilePhoneNumber(loginModel);

                switch (result.LoginStatus)
                {
                    case true:
                        return Ok(result.successResponseDto);
                    case false:
                        return Problem(result.errorResponseDto!.StatusMessage);
                }
            }

            return BadRequest();
        }
        catch (Exception ex)
        {
            return StatusCode(500, ex.Message);
        }
    }


}

