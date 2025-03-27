using System.Text.Json;
using System.Text.RegularExpressions;
using Asp.Versioning;
using Azure;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.RateLimiting;
using Modules.Users.Application.Dtos.Entities;
using Modules.Users.Application.Dtos.UserAccounts;
using Modules.Users.Application.Shared;
using Modules.Users.Domain.Interfaces;


namespace Modules.Users.Presentation.Controllers.v1;

[ApiController]
[ApiVersion("1.0")]
[Route("api/v{version:apiVersion}/[controller]")]
[Produces("application/json")]

[EnableRateLimiting("UsersModulePolicy")]
[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
[AllowAnonymous]

public class AccountController : ControllerBase
{
    IUserAccountsService _userAccountsService;
    IUnitOfWork _unitOfWork;

    Regex emailRegex = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$");
    Regex phoneRegex = new Regex(@"^(023|024|025|053|054|055|059|027|057|026|056|028|020|050)\d{7}$");


    public AccountController(IUserAccountsService userAccountsService, IUnitOfWork unitOfWork)
    {
        _userAccountsService = userAccountsService;
        _unitOfWork = unitOfWork;
    }

    /// <summary>
    /// Returns a list of available identification types
    /// </summary>
    [HttpGet]
    [Route("GetIdentificationTypes")]
    public async Task<ActionResult<IEnumerable<IdentificationType>>> GetIdentificationTypes()
    {
        return Ok(await _unitOfWork.IdentificationType.GetAll());
    }

    /// <summary>
    /// Returns a list of available channels
    /// </summary>
    [HttpGet]
    [Route("GetChannels")]
    public async Task<ActionResult<IEnumerable<ChannelReadDto>>> GetChannels()
    {
        return Ok((await _unitOfWork.Channels.GetAll()).Select(c => new ChannelReadDto(c.ChannelId, c.ChannelName!)));

    }

    /// <summary>
    /// Registers a new customer user.
    /// </summary>
    /// <remarks>Returns the registration status and user id. The email/phone and password used in a successful registration will be required to access and generated a json web token and a refresh token that will be used for authoriation and authentication purposes</remarks>
    /// <response code="201">Returns the uniquely created user id for a newly registered application user</response>
    [HttpPost]
    [Route("Register/Customer")]
    [ProducesResponseType(201, Type = typeof(RegistrationSuccessResponse))]
    [ProducesResponseType(400, Type = typeof(RegistrationErrorResponse))]
    [ProducesResponseType(404, Type = typeof(RegistrationErrorResponse))]
    [ProducesResponseType(409, Type = typeof(RegistrationErrorResponse))]
    public async Task<ActionResult> Register([FromBody] CustomerRegistrationRequestDto values)
    {
        if (ModelState.IsValid)
        {
            var response = await _userAccountsService.CustomerUserRegistration(values);

            if (response.IsSuccess == true)
            {
                return StatusCode(StatusCodes.Status201Created, response.SuccessResponse);
            }

            var status = response.ErrorResponse!.StatusCode;

            switch (status)
            {
                case 204:
                    return NoContent();
                case 400:
                    return BadRequest(response.ErrorResponse);
                case 404:
                    return NotFound(response.ErrorResponse);
                case 409:
                    return Conflict(response.ErrorResponse);
                default:
                    break;
            };

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
            var response = await _userAccountsService.PartnerUserRegistration(values);

            if (response.IsSuccess == true)
            {
                return StatusCode(StatusCodes.Status201Created, response.SuccessResponse);
            }

            var status = response.ErrorResponse!.StatusCode;

            switch (status)
            {
                case 204:
                    return NoContent();
                case 400:
                    return BadRequest(response.ErrorResponse);
                case 404:
                    return NotFound(response.ErrorResponse);
                case 409:
                    return Conflict(response.ErrorResponse);
                default:
                    break;
            };
        }

        return BadRequest();
    }

    /// <summary>
    /// Registers a new staff user.
    /// </summary>
    /// <remarks>Returns the registration status and user id. The user and password used in a successful registration will be used to access generated a json web token and a refresh token that will be used to access the application</remarks>
    /// <response code="201">Returns the uniquely created user id for a newly registered application user</response>
    [HttpPost]
    [Route("Register/Staff")]
    [Authorize(Policy = "Permission:Users.CREATE")]
    [ProducesResponseType(201, Type = typeof(RegistrationSuccessResponse))]
    [ProducesResponseType(400, Type = typeof(RegistrationErrorResponse))]
    [ProducesResponseType(404, Type = typeof(RegistrationErrorResponse))]
    [ProducesResponseType(409, Type = typeof(RegistrationErrorResponse))]
    public async Task<ActionResult<RegistrationResponse>> Register([FromBody] StaffRegistrationRequestDto values)
    {
        if (ModelState.IsValid)
        {
            var response = await _userAccountsService.StaffUserRegistration(values);

            if(response.IsSuccess == true)
            {
                return StatusCode(StatusCodes.Status201Created, response.SuccessResponse);
            }

            var status = response.ErrorResponse!.StatusCode;

            switch (status)
            {
                case 204:
                    return NoContent();
                case 400:
                    return BadRequest(response.ErrorResponse);
                case 404:
                    return NotFound(response.ErrorResponse);
                case 409:
                    return Conflict(response.ErrorResponse); 
                default:
                    break;
            };

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
                if (changeResult.IsSuccess)
                {
                    return Ok(changeResult);
                }

                var status = changeResult.ErrorResponse!.StatusCode;

                switch (status)
                {
                    case 204:
                        return NoContent();
                    case 400:
                        return BadRequest(changeResult.ErrorResponse);
                    case 404:
                        return NotFound(changeResult.ErrorResponse);
                    case 409:
                        return Conflict(changeResult.ErrorResponse);
                    default:
                        return StatusCode(500, changeResult);
                };

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
            ResetPasswordResponse changeResult = null! ;

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
                    changeResult = await _userAccountsService.ResetPasswordViaEmailAddress(passwordRequest);
                }


                if (phoneRegex.IsMatch(resetPasswordRequest.Phone_OR_Email!))
                {
                    changeResult = await _userAccountsService.ResetPasswordViaMobilePhoneNumber(passwordRequest);
                }

                if (changeResult.IsSuccess)
                {
                    return Ok(changeResult.SuccessResponse);
                }

                var status = changeResult.ErrorResponse!.StatusCode;

                switch (status)
                {
                    case 204:
                        return NoContent();
                    case 400:
                        return BadRequest(changeResult.ErrorResponse);
                    case 404:
                        return NotFound(changeResult.ErrorResponse);
                    case 409:
                        return Conflict(changeResult.ErrorResponse);
                    default:
                        return StatusCode(500, changeResult);
                };

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
                            return Ok(result);
                        case false:
                            var status = result.errorResponse!.StatusCode;

                            return status switch
                            {
                                204 => NoContent(),
                                400 => BadRequest(result.errorResponse),
                                404 => NotFound(result.errorResponse),
                                409 => Conflict(result.errorResponse),
                                500 => StatusCode(500, result.errorResponse),
                                _ => StatusCode(500, result),
                            };
                    }
                }

                if (phoneRegex.IsMatch(loginModel.Phone_OR_Email!))
                {
                    var result = await _userAccountsService.LoginWithMobilePhoneNumber(loginRequest);

                    switch (result.LoginStatus)
                    {
                        case true:
                            return Ok(result);
                        case false:
                            var status = result.errorResponse!.StatusCode;

                            return status switch
                            {
                                204 => NoContent(),
                                400 => BadRequest(result.errorResponse),
                                404 => NotFound(result.errorResponse),
                                409 => Conflict(result.errorResponse),
                                500 => StatusCode(500, result.errorResponse),
                                _ => StatusCode(500, result),
                            };
                    }
                }


            }

            return BadRequest(new {statusCode = 400, message = "Invalid phone number, email address or password." });
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
                var result  = await _userAccountsService.RefreshBearerToken(request);
                if (result.IsSuccess)
                {
                    return Ok(result.SuccessResponse);
                }

                var status = result.ErrorResponse!.StatusCode;
                return status switch
                {
                    400 => BadRequest(result.ErrorResponse),
                    404 => NotFound(result.ErrorResponse),
                    500 => StatusCode(500, result.ErrorResponse),
                    _ => StatusCode(500, result),
                };
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
    //[Authorize(Policy = "Permission:Users.CREATE")]
    public async Task<ActionResult> UserDetails(string userId)
    {
        var user = await _unitOfWork.Users.Get(u => u.Id == userId);
        if (user is null)
            return NotFound(new { message = "User id not found" });

        return Ok(await _userAccountsService.UserDetails(userId));
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
                if (emailRegex.IsMatch(value.phone_OR_email!))
                {
                    var result = await _unitOfWork.TokenStore.GetToken(value.phone_OR_email!, 5);
                    if(result.Length != 6)
                    {
                        return NotFound(new { message = result });
                    }
                    return Ok(new TokenResponseDto(result));
                }


                if (phoneRegex.IsMatch(value.phone_OR_email!))
                {
                    var result = await _unitOfWork.TokenStore.GetToken(value.phone_OR_email!, 5);
                    if (result.Length != 6)
                    {
                        return NotFound(new { message = result });
                    }
                    return Ok(new TokenResponseDto(result));
                }
            }

            return NotFound(new {message = "Invalid mobile phone number or email address provided" });
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
    [ProducesResponseType(200, Type = typeof(TokenResponseDto))]
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

                if (emailRegex.IsMatch(verifyTokenRequest.phone_OR_email!))
                {
                    var result = await _unitOfWork.TokenStore.VerifyToken(verifyTokenRequest.phone_OR_email, verifyTokenRequest.token);
                    if(result != "Verified")
                    {
                        return BadRequest(new { message = result });
                    }
                    return Ok(new { message = result });
                }


                if (phoneRegex.IsMatch(verifyTokenRequest.phone_OR_email!))
                {
                    var result = await _unitOfWork.TokenStore.VerifyToken(verifyTokenRequest.phone_OR_email, verifyTokenRequest.token);
                    if (result != "Verified")
                    {
                        return BadRequest(new { message = result });
                    }
                    return Ok(new { message = result });
                }

            }

            return NotFound();
        }
        catch (Exception ex)
        {
            return StatusCode(500, ex.Message);
        }

    }

    /// <summary>
    /// Update specific account details only
    /// </summary>
    [HttpPut]
    [AllowAnonymous]
    [Route("UpdateUserAccount")]
    [ProducesResponseType(200, Type = typeof(UserInformationDto))]
    public async Task<IActionResult> UpdateUserAccount([FromBody] UpdateUserDto UserUpdateRequest)
    {
        try
        {
            if (ModelState.IsValid)
            {
                var result = await _userAccountsService.UpdateAccountDetails(UserUpdateRequest);

                if (result.success is not null)
                {
                    return Ok(result.success);
                }
                else
                {
                    return BadRequest(result.error);
                }
            }

            return NotFound();
        }
        catch (Exception ex)
        {
            return StatusCode(500, ex.Message);
        }

    }

}