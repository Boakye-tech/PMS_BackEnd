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

    [HttpPost]
    [Route("Account/Register")]
    public async Task<ActionResult<RegistrationResponse>> Register([FromBody] CustomerRegistrationRequestDto values)
    {
        if (!ModelState.IsValid)
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


}

