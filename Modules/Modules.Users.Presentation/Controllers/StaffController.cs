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
public class StaffController : ControllerBase
{
    IStaffAccountService _staffAccountService;
    IDepartmentService _departmentService;
    IDepartmentUnitService _departmentUnitService;

    public StaffController(IStaffAccountService staffAccountService, IDepartmentService departmentService, IDepartmentUnitService departmentUnitService)
    {
        _staffAccountService = staffAccountService;
        _departmentService = departmentService;
        _departmentUnitService = departmentUnitService;
    }

    [HttpPost]
    [Route("Account/Register")]
    public async Task<ActionResult<RegistrationResponse>> Register([FromBody] StaffRegistrationRequestDto values)
    {

        try
        {
            if (ModelState.IsValid)
            {
                return Ok(await _staffAccountService.UserRegistration(values));
            }

            return BadRequest();
        }
        catch (Exception ex)
        {
            return StatusCode(500, ex.InnerException!.Message);
        }
    }

    /// <summary>
    /// Changes the password of a registered user account
    /// </summary>
    [HttpPost]
    [AllowAnonymous]
    [Route("Account/ChangePassword")]
    public async Task<IActionResult> ChangePassword([FromBody] ChangeStaffPasswordRequestDto changeUserPasswordRequest)
    {
        try
        {
            if (ModelState.IsValid)
            {
                var changeResult = await _staffAccountService.ChangePassword(changeUserPasswordRequest);
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
    /// reset the password for a forgotten registered user account
    /// </summary>
    [HttpPost]
    [AllowAnonymous]
    [Route("Account/ResetPassword")]
    public async Task<IActionResult> ResetPassword([FromBody] ResetStaffPasswordRequestDto resetPasswordRequest)
    {
        try
        {
            if (ModelState.IsValid)
            {
                var changeResult = await _staffAccountService.ResetPassword(resetPasswordRequest);
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
    [Route("Account/Login")]
    [ProducesResponseType(200, Type = typeof(StaffLoginResponseDto))]
    public async Task<IActionResult> UserLogin([FromBody] StaffLoginRequestDto loginModel)
    {
        try
        {
            if (ModelState.IsValid)
            {
                var result = await _staffAccountService.UserLogin(loginModel);

                switch (result.LoginStatus)
                {
                    case true:
                        return Ok(result.staffLoginSuccessResponseDto);
                    case false:
                        return Problem(result.staffLoginErrorResponseDto!.StatusMessage);
                }
            }

            return BadRequest();
        }
        catch (Exception ex)
        {
            return StatusCode(500, ex.Message);
        }
    }

    //----------------------DEPARTMENT------------
    [HttpGet]
    [Route("Setup/GetDepartments")]
    public async Task<ActionResult<IEnumerable<DepartmentReadDto>>> GetDepartments()
    {
        return Ok(await _departmentService.GetDepartmentAsync());
    }

    [HttpGet]
    [Route("Setup/GetDepartment/{value}")]
    public async Task<ActionResult<DepartmentReadDto>> GetDepartment(string value)
    {
        return Ok(await _departmentService.GetDepartmentAsync(value));
    }

    [HttpGet]
    [Route("Setup/GetDepartmentById/{departmentId}")]
    public async Task<ActionResult<DepartmentReadDto>> GetDepartmentById(int departmentId)
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
    [HttpGet]
    [Route("Setup/GetDepartmentUnits")]
    public async Task<ActionResult<IEnumerable<DepartmentUnitReadDto>>> GetDepartmentUnits()
    {
        return Ok(await _departmentUnitService.GetDepartmentUnitAsync());
    }

    [HttpGet]
    [Route("Setup/GetDepartmentUnit/{value}")]
    public async Task<ActionResult<DepartmentReadDto>> GetDepartmentUnit(string value)
    {
        return Ok(await _departmentUnitService.GetDepartmentUnitAsync(value));
    }

    [HttpGet]
    [Route("Setup/GetDepartmentUnitById/{departmentUnitId}")]
    public async Task<ActionResult<DepartmentReadDto>> GetDepartmentUnitById(int departmentUnitId)
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

    [HttpDelete("DeleteDepartment/{departmentUnitId}")]
    public void DeleteDepartmentUnit(int departmentUnitId)
    { }


}

