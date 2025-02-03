using System.Text.RegularExpressions;
using Asp.Versioning;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;
using Modules.Users.Application.Dtos.Entities;
using Modules.Users.Application.Dtos.UserAccounts;
using Modules.Users.Application.Shared;
using Modules.Users.Domain.Interfaces;

namespace Modules.Users.Presentation.Controllers.v2;

[ApiController]
[ApiVersion("2.0")]
[Route("api/v{version:apiVersion}/[controller]")]
[Produces("application/json")]
public class AccountController : ControllerBase
{
    IUserAccountsService _userAccountsService;
    IUnitOfWork _unitOfWork;

    public AccountController(IUserAccountsService userAccountsService, IUnitOfWork unitOfWork)
    {
        _userAccountsService = userAccountsService;
        _unitOfWork = unitOfWork;
    }

    /// <summary>
    /// Registers a new application user.
    /// </summary>
    /// <remarks>Returns the registration status and user id. The user and password used in a successful registration will be used to access generated a json web token that will be used to access the application</remarks>
    /// <response code="200">Returns the uniquely created user id for a newly registered application user</response>
    [HttpPost]
    [Route("Register/Customer")]
    public async Task<ActionResult<RegistrationResponse>> Register([FromBody] CustomerRegistrationRequestDto values)
    {
        if (ModelState.IsValid)
        {
            return Ok(await _userAccountsService.CustomerUserRegistration(values));
        }

        return BadRequest();
      
    }

    /// <summary>
    /// Changes the password of a registered user account
    /// </summary>
    [HttpPost]
    [AllowAnonymous]
    [Route("ChangePassword")]
    public async Task<IActionResult> ChangePassword([FromBody] ChangePasswordRequestDto changeUserPasswordRequest)
    {
        try
        {
            if (ModelState.IsValid)
            {
                var changeResult = await _userAccountsService.ChangePassword(changeUserPasswordRequest);
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
    [Route("ResetPassword")]
    public async Task<IActionResult> ResetPassword([FromBody] ResetPasswordRequestDto resetPasswordRequest)
    {
        try
        {
            var emailRegex = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$");
            var phoneRegex = new Regex(@"^\+?\d{10,15}$");


            if (ModelState.IsValid)
            {

                if (emailRegex.IsMatch(resetPasswordRequest.Phone_OR_Email!))
                {
                    ResetPasswordRequestDto passwordRequest = new ResetPasswordRequestDto
                    {
                        Phone_OR_Email = resetPasswordRequest.Phone_OR_Email,
                        Token = resetPasswordRequest.Token,
                        NewPassword = resetPasswordRequest.NewPassword,
                        ConfirmNewPassword = resetPasswordRequest.ConfirmNewPassword
                    };

                    var changeResult = await _userAccountsService.ResetPasswordViaEmailAddress(passwordRequest);
                    return Ok(changeResult);

                }


                if (phoneRegex.IsMatch(resetPasswordRequest.Phone_OR_Email!))
                {
                    ResetPasswordRequestDto passwordRequest = new ResetPasswordRequestDto
                    {
                        Phone_OR_Email = resetPasswordRequest.Phone_OR_Email,
                        Token = resetPasswordRequest.Token,
                        NewPassword = resetPasswordRequest.NewPassword,
                        ConfirmNewPassword = resetPasswordRequest.ConfirmNewPassword
                    };

                    var changeResult = await _userAccountsService.ResetPasswordViaMobilePhoneNumber(passwordRequest);
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
    [Route("Login")]
    [ProducesResponseType(200, Type = typeof(LoginResponseDto))]
    public async Task<IActionResult> UserLogin([FromBody] LoginRequestDto loginModel)
    {
        try
        {
            var emailRegex = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$");
            var phoneRegex = new Regex(@"^\+?\d{10,15}$");

            if (ModelState.IsValid)
            {
                if (emailRegex.IsMatch(loginModel.Phone_OR_Email!))
                {
                    LoginRequestDto loginRequest = new LoginRequestDto
                    {
                        Phone_OR_Email = loginModel.Phone_OR_Email,
                        Password = loginModel.Password
                    };

                    var result = await _userAccountsService.LoginWithEmailAddress(loginRequest);

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
                    LoginRequestDto loginRequest = new LoginRequestDto
                    {
                        Phone_OR_Email = loginModel.Phone_OR_Email,
                        Password = loginModel.Password

                    };

                    var result = await _userAccountsService.LoginWithMobilePhoneNumber(loginRequest);

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
    [Route("Refresh")]
    [ProducesResponseType(200, Type = typeof(RefreshTokenResponseDto))]
    public async Task<IActionResult> RefreshToken([FromBody] RefreshTokenRequestDto request)
    {
        try
        {

            if (ModelState.IsValid)
            {

                var newTokens = await _userAccountsService.RefreshBearerToken(request);
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
                var result = _unitOfWork.TokenStore.GetToken(value.phone_OR_email!,5);  //.SendSmsToken(requestParameter);
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
                var result = _unitOfWork.TokenStore.GetToken(value.phone_OR_email!,5);
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

