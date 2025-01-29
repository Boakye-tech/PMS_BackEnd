using System.Text.RegularExpressions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;
using Modules.Users.Application.Dtos.Entities;
using Modules.Users.Application.Dtos.UserAccounts;
using Modules.Users.Application.Shared;
using Modules.Users.Domain.Interfaces;

namespace Modules.Users.Presentation.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CustomerController : ControllerBase
{
    ICustomerAccountService _customerAccountService;
    IUnitOfWork _unitOfWork;

    public CustomerController(ICustomerAccountService customerAccountService, IUnitOfWork unitOfWork)
    {
        _customerAccountService = customerAccountService;
        _unitOfWork = unitOfWork;
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
    public async Task<IActionResult> ResetPassword([FromBody] CustomerResetPasswordRequestDto resetPasswordRequest)
    {
        try
        {
            var emailRegex = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$");
            var phoneRegex = new Regex(@"^\+?\d{10,15}$");


            if (ModelState.IsValid)
            {

                if (emailRegex.IsMatch(resetPasswordRequest.Phone_OR_Email!))
                {
                    ResetCustomerPasswordEmailRequestDto passwordRequest = new ResetCustomerPasswordEmailRequestDto
                    {
                        EmailAddress = resetPasswordRequest.Phone_OR_Email,
                        Token = resetPasswordRequest.Token,
                        NewPassword = resetPasswordRequest.NewPassword,
                        ConfirmNewPassword = resetPasswordRequest.ConfirmNewPassword
                    };

                    var changeResult = await _customerAccountService.ResetPasswordViaEmailAddress(passwordRequest);
                    return Ok(changeResult);

                }


                if (phoneRegex.IsMatch(resetPasswordRequest.Phone_OR_Email!))
                {
                    ResetCustomerPasswordPhoneRequestDto passwordRequest = new ResetCustomerPasswordPhoneRequestDto
                    (
                        resetPasswordRequest.Phone_OR_Email,
                        resetPasswordRequest.Token,
                        resetPasswordRequest.NewPassword,
                        resetPasswordRequest.ConfirmNewPassword
                    );

                    var changeResult = await _customerAccountService.ResetPasswordViaMobilePhoneNumber(passwordRequest);
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
    [Route("Account/Login")]
    [ProducesResponseType(200, Type = typeof(CustomerLoginResponseDto))]
    public async Task<IActionResult> UserLogin([FromBody] CustomerLoginRequestDto loginModel)
    {
        try
        {
            var emailRegex = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$");
            var phoneRegex = new Regex(@"^\+?\d{10,15}$");

            if (ModelState.IsValid)
            {
                if (emailRegex.IsMatch(loginModel.Phone_OR_Email!))
                {
                    CustomerEmailLoginRequestDto loginRequest = new CustomerEmailLoginRequestDto
                    {
                        EmailAddress = loginModel.Phone_OR_Email,
                        Password = loginModel.Password
                    };

                    var result = await _customerAccountService.LoginWithEmailAddress(loginRequest);

                    switch (result.LoginStatus)
                    {
                        case true:
                            return Ok(result.successResponseDto);
                        case false:
                            return Problem(result.errorResponseDto!.StatusMessage);
                    }
                }

                if (phoneRegex.IsMatch(loginModel.Phone_OR_Email!))
                {
                    CustomerPhoneLoginRequestDto loginRequest = new CustomerPhoneLoginRequestDto
                    (
                        loginModel.Phone_OR_Email,
                        loginModel.Password
                    );

                    var result = await _customerAccountService.LoginWithMobilePhoneNumber(loginRequest);

                    switch (result.LoginStatus)
                    {
                        case true:
                            return Ok(result.successResponseDto);
                        case false:
                            return Problem(result.errorResponseDto!.StatusMessage);
                    }
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
    /// reset the password for a forgotten registered user account via their registered email address or registered mobile phone number
    /// </summary>
    [HttpPost]
    [AllowAnonymous]
    [Route("Account/Refresh")]
    [ProducesResponseType(200, Type = typeof(RefreshTokenResponseDto))]
    public async Task<IActionResult> RefreshToken([FromBody] RefreshTokenRequestDto request)
    {
        try
        {

            if (ModelState.IsValid)
            {

                var newTokens = await _customerAccountService.RefreshBearerToken(request);
                return Ok(newTokens);
            }

            return BadRequest();
        }
        catch (Exception ex)
        {
            return StatusCode(500, ex.Message);
        }
    }

    /// <summary>
    /// Sends a one time pin to a user's mobile phone number for verification  
    /// </summary>
    [HttpPost]
    [AllowAnonymous]
    [Route("SendSMSToken")]
    //[ProducesResponseType(200, Type = typeof(UserLoginResponse))]
    public IActionResult SendSMSToken([FromBody] TokenRequestParameterDto value)
    {
        try
        {
            if (ModelState.IsValid)
            {
                var result = _unitOfWork.TokenStore.GetToken(value.requestParameter!,5);  //.SendSmsToken(requestParameter);
                return Ok(result);
            }

            return NotFound();
        }
        catch (Exception ex)
        {
            return StatusCode(500, ex.Message);
        }
    }

    /// <summary>
    /// Sends a one time pin to a user's email address for verification  
    /// </summary>
    [HttpPost]
    [AllowAnonymous]
    [Route("SendEmailToken")]
    //[ProducesResponseType(200, Type = typeof(UserLoginResponse))]
    public IActionResult SendEmailToken([FromBody] TokenRequestParameterDto value)
    {
        try
        {
            if (ModelState.IsValid)
            {
                var result = _unitOfWork.TokenStore.GetToken(value.requestParameter!,5);
                return Ok(result);
            }

            return NotFound();
        }
        catch (Exception ex)
        {
            return StatusCode(500, ex.Message);
        }
    }



}

