﻿using System.Text.RegularExpressions;
using Asp.Versioning;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;
using Modules.Users.Application.Dtos.Entities;
using Modules.Users.Application.Dtos.UserAccounts;
using Modules.Users.Application.Shared;
using Modules.Users.Domain.Interfaces;


namespace Modules.Users.Presentation.Controllers.v1;

[ApiController]
[ApiVersion("1.0")]
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
    /// Registers a new customer user.
    /// </summary>
    /// <remarks>Returns the registration status and user id. The email/phone and password used in a successful registration will be required to access and generated a json web token and a refresh token that will be used for authoriation and authentication purposes</remarks>
    /// <response code="200">Returns the uniquely created user id for a newly registered application user</response>
    [HttpPost]
    [Route("Register/Customer")]
    [ProducesResponseType(200, Type = typeof(RegistrationResponse))]
    public async Task<ActionResult<RegistrationResponse>> Register([FromBody] CustomerRegistrationRequestDto values)
    {
        if (ModelState.IsValid)
        {
            return Ok(await _userAccountsService.CustomerUserRegistration(values));
        }

        return BadRequest();

    }

    /// <summary>
    /// Registers a new partner bank user.
    /// </summary>
    /// <remarks>Returns the registration status and user id. The user and password used in a successful registration will be used to access generated a json web token and a refresh token that will be used to access the application</remarks>
    /// <response code="200">Returns the uniquely created user id for a newly registered application user</response>
    [HttpPost]
    [AllowAnonymous]
    [Route("Register/Partners")]
    [ProducesResponseType(200, Type = typeof(RegistrationResponse))]
    public async Task<ActionResult<RegistrationResponse>> Register([FromBody] PartnerBankRegistrationRequestDto values)
    {
        if (ModelState.IsValid)
        {
            return Ok(await _userAccountsService.PartnerUserRegistration(values));
        }

        return BadRequest();
    }

    /// <summary>
    /// Registers a new staff user.
    /// </summary>
    /// <remarks>Returns the registration status and user id. The user and password used in a successful registration will be used to access generated a json web token and a refresh token that will be used to access the application</remarks>
    /// <response code="200">Returns the uniquely created user id for a newly registered application user</response>
    [HttpPost]
    [Route("Register/Staff")]
    [ProducesResponseType(200, Type = typeof(RegistrationResponse))]
    public async Task<ActionResult<RegistrationResponse>> Register([FromBody] StaffRegistrationRequestDto values)
    {
        if (ModelState.IsValid)
        {
            return Ok(await _userAccountsService.StaffUserRegistration(values));
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
            //var phoneRegex = new Regex(@"^\+?\d{10,15}$");
            var phoneRegex = new Regex(@"^0[25][3-9]{8}$");

            if (ModelState.IsValid)
            {

                ResetPasswordRequestDto passwordRequest = new ResetPasswordRequestDto
                {
                    Phone_OR_Email = resetPasswordRequest.Phone_OR_Email,
                    Token = resetPasswordRequest.Token,
                    NewPassword = resetPasswordRequest.NewPassword,
                    ConfirmNewPassword = resetPasswordRequest.ConfirmNewPassword
                };


                if (emailRegex.IsMatch(resetPasswordRequest.Phone_OR_Email!))
                {
                    var changeResult = await _userAccountsService.ResetPasswordViaEmailAddress(passwordRequest);
                    return Ok(changeResult);
                }


                if (phoneRegex.IsMatch(resetPasswordRequest.Phone_OR_Email!))
                {
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
    /// <remarks>Returns a valid json web token and a refresh token that will be used for authoriation and authentication purposes.
    /// The refresh token generated will be need to generate a new valid json web token and refresh token
    /// </remarks>
    [HttpPost]
    [AllowAnonymous]
    [Route("Login")]
    [ProducesResponseType(200, Type = typeof(LoginResponseDto))]
    public async Task<IActionResult> UserLogin([FromBody] LoginRequestDto loginModel)
    {
        try
        {
            var emailRegex = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$");
            var phoneRegex = new Regex(@"^0[25][3-9]{8}$");

            if (ModelState.IsValid)
            {

                LoginRequestDto loginRequest = new LoginRequestDto
                {
                    Phone_OR_Email = loginModel.Phone_OR_Email,
                    Password = loginModel.Password
                };

                if (emailRegex.IsMatch(loginModel.Phone_OR_Email!))
                {
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
    /// Generate a new jwToken and refresh token based on an expired jwtoken and a valid refresh token
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
    /// Returns current users details  
    /// </summary>
    [HttpGet]
    [Route("Users/{userId}")]
    public async Task<UserInformationDto> UserDetails(string userId)
    {
        //return await _menuService.GetMenuActions();
        return await _userAccountsService.UserDetails(userId);
    }

    /// <summary>
    /// Sends a one time pin to a user's email address or mobile phone number for verification  
    /// </summary>
    [HttpPost]
    [AllowAnonymous]
    [Route("SendOTPToken")]
    [ProducesResponseType(200, Type = typeof(TokenResponseDto))]
    public async Task<IActionResult> SendOTPToken([FromBody] TokenRequestParameterDto value)
    {
        try
        {
            if (string.IsNullOrWhiteSpace(value.phone_OR_email))
            {
                return BadRequest();
            }

            if (ModelState.IsValid)
            {
                var result = await _unitOfWork.TokenStore.GetToken(value.phone_OR_email!, 5);
                return Ok(new TokenResponseDto(result));
            }

            return NotFound();
        }
        catch (Exception ex)
        {
            return StatusCode(500, ex.Message);
        }
    }

    /// <summary>
    /// Verifies one time pin sent to user's email address or mobile phone number
    /// </summary>
    [HttpPost]
    [AllowAnonymous]
    [Route("VerifyOTPToken")]
    //[ProducesResponseType(200, Type = typeof(UserLoginResponse))]
    public async Task<IActionResult> VerifyOTPToken([FromBody] VerifyTokenRequestDto verifyTokenRequest)
    {
        try
        {
            if(string.IsNullOrWhiteSpace(verifyTokenRequest.phone_OR_email) || string.IsNullOrWhiteSpace(verifyTokenRequest.token))
            {
                return BadRequest();
            }

            if (ModelState.IsValid)
            {
                var result = await _unitOfWork.TokenStore.VerifyToken(verifyTokenRequest.phone_OR_email, verifyTokenRequest.token);
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