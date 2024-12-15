﻿using Microsoft.AspNetCore.Mvc;
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
    IStaffAccouuntService _staffAccountService;

    public StaffController(IStaffAccouuntService staffAccountService)
    {
        _staffAccountService = staffAccountService;
    }

    [HttpPost]
    [Route("Account/Register")]
    public async Task<ActionResult<RegistrationResponse>> Register([FromBody] StaffRegistrationRequestDto values)
    {
        if (!ModelState.IsValid)
        {
            return Ok(await _staffAccountService.UserRegistration(values));
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



}

