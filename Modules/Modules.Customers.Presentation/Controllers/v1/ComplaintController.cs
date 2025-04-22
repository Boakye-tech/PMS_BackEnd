using System.ComponentModel;
using System.Reflection;
using System.Web;
using Asp.Versioning;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Modules.Common.Infrastructure.Authentication;
using Modules.Customers.Application.Dtos.Complaints;
using Modules.Customers.Domain.Enums;

namespace Modules.Customers.Presntation.Controllers.v1;

[ApiController]
[ApiVersion("1.0")]
[Route("api/v{version:apiVersion}/[controller]")]
[Produces("application/json")]
[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]

public class ComplaintController : ControllerBase
{
    private readonly ILogger<ComplaintController> _logger;
    private readonly IComplaintTypeService _complaintTypeService;
    private readonly INatureOfComplaintService _natureOfComplaintService;
    private readonly IComplaintService _complaintService;
    private readonly IUserContextService _userContextService;


    public ComplaintController(ILogger<ComplaintController> logger,IComplaintTypeService complaintTypeService, INatureOfComplaintService natureOfComplaintService, IComplaintService complaintService, IUserContextService userContextService)
    {
        _logger = logger;
        _complaintTypeService = complaintTypeService;
        _natureOfComplaintService = natureOfComplaintService;
        _complaintService = complaintService;
        _userContextService = userContextService;
    }



    // POST api/values
    [HttpPost]
    [Route("CreateComplaintType")]
    [Authorize(Policy = "Permission:Complaints.CREATE")]
    public async Task<ActionResult> CreateComplaintType(ComplaintTypeDto values)
    {
        try
        {
            return Ok(await _complaintTypeService.AddNewComplaintType(values));
        }
        catch (Exception ex)
        {
            return BadRequest(new { error = ex.ToString() });
        }
    }

    // POST api/values
    [HttpPost]
    [Route("CreateNatureOfComplaint")]
    [Authorize(Policy = "Permission:Complaints.CREATE")]
    public async Task<IActionResult> CreateNatureOfComplaint(NatureOfComplaintDto values)
    {
        try
        {
            return Ok(await _natureOfComplaintService.AddNewNatureOfComplaint(values));
        }
        catch (Exception ex)
        {
            return BadRequest(new { error = ex.ToString() });
        }
    }

    [HttpGet("ComplaintType")]
    [Authorize(Policy = "Permission:Complaints.READ")]
    public async Task<IEnumerable<ComplaintTypeDto>> ComplaintType()
    {
        return await _complaintTypeService.GetComplaintTypes();
    }

    [HttpGet("NatureOfComplaint")]
    [Authorize(Policy = "Permission:Complaints.READ")]
    public async Task<IEnumerable<NatureOfComplaintDto>> NatureOfComplaint([FromQuery] int complaintId)
    {
        if (complaintId == 0)
        {
            return await _natureOfComplaintService.GetNatureOfComplaints();
        }

        return await _natureOfComplaintService.GetNatureOfComplaints(complaintId);
    }


    // PUT api/values
    [HttpPut]
    [Route("UpdateComplaintType")]
    [Authorize(Policy = "Permission:Complaints.UPDATE")]
    public async Task<ActionResult> UpdateComplaintType(ComplaintTypeDto values)
    {
        try
        {
            return Ok(await _complaintTypeService.UpdateComplaintType(values));
        }
        catch (Exception ex)
        {
            return BadRequest(new { error = ex.ToString() });
        }
    }

    // PUT api/values
    [HttpPut]
    [Route("UpdateNatureOfComplaint")]
    [Authorize(Policy = "Permission:Complaints.UPDATE")]
    public async Task<IActionResult> UpdateNatureOfComplaint(NatureOfComplaintDto values)
    {
        try
        {
            return Ok(await _natureOfComplaintService.UpdateNatureOfComplaint(values));
        }
        catch (Exception ex)
        {
            return BadRequest(new { error = ex.ToString() });
        }
    }

    [HttpDelete]
    [Route("DeleteComplaintType/{complaintTypeId}")]
    [Authorize(Policy = "Permission:Complaints.DELETE")]
    public async Task<IActionResult> DeleteComplaintType(int complaintTypeId)
    {
        try
        {
            return Ok(await _complaintTypeService.DeleteComplaintType(complaintTypeId));
        }
        catch (Exception ex)
        {
            return BadRequest(new { error = ex.ToString() });
        }
    }

    [HttpDelete]
    [Route("DeleteNatureOfComplaint/{natureOfComplaintId}")]
    [Authorize(Policy = "Permission:Complaints.DELETE")]
    public async Task<IActionResult> DeleteNatureOfComplaint(int natureOfComplaintId)
    {
        try
        {
            return Ok(await _natureOfComplaintService.DeleteNatureOfComplaint(natureOfComplaintId));
        }
        catch (Exception ex)
        {
            return BadRequest(new { error = ex.ToString() });
        }
    }

    /// <summary>
    /// Returns a list of complaint status
    /// </summary>
    [HttpGet]
    [Route("ComplaintStatus")]
    [ProducesResponseType(typeof(int), StatusCodes.Status200OK)]
    [Authorize(Policy = "Permission:Complaints.READ")]
    public IActionResult ComplaintStatus()
    {
        var statuses = Enum.GetValues(typeof(ComplaintStatus))
                               .Cast<ComplaintStatus>()
                               .Select(e => new
                               {
                                   Id = (int)e,
                                   Name = e.ToString(),
                                   DisplayName = e.GetType()
                                                 .GetField(e.ToString())!
                                                  .GetCustomAttribute<DescriptionAttribute>()?
                                                  .Description

                               });
        return Ok(statuses);
    }

    /// <summary>
    /// Returns the details of a complaint
    /// </summary>
    [HttpGet]
    [Route("GetComplaintDetails/complaintNumber")]
    [Authorize(Policy = "Permission:Complaints.READ")]
    [ProducesResponseType(200, Type = typeof(ComplaintDto))]
    public async Task<ActionResult> GetComplaints(string complaintNumber)
    {
        try
        {
            if (string.IsNullOrWhiteSpace(complaintNumber))
            {
                return BadRequest("The complaint number cannot be empty or null");
            }

            var result = await _complaintService.GetComplaintDetails(complaintNumber);
            if(result is null)
            {
                return NotFound($"No records found for complaint number {complaintNumber}");
            }

            return Ok(result);
        }
        catch (Exception ex)
        {
            return StatusCode(500, ex.InnerException!.Message);
        }

    }

    /// <summary>
    /// Returns a list of complaints based on a user query/optional parameters
    /// </summary>
    [HttpGet]
    [Route("GetComplaints")]
    [Authorize(Policy = "Permission:Complaints.READ")]
    [ProducesResponseType(200, Type = typeof(IEnumerable<ComplaintReadDto>))]
    public async Task<ActionResult> GetComplaints([FromQuery] string? complaintNumber, [FromQuery] string? customerCode_OR_propertyNumber)
    {
        try
        {
            if(complaintNumber is null && customerCode_OR_propertyNumber is null)
            {
                return Ok(Array.Empty<string>());
            }

            if(complaintNumber is not null)
            {
                var result = await _complaintService.GetComplaintSummary(complaintNumber) ;
                return Ok(result);

            }

            if (customerCode_OR_propertyNumber is not null)
            {
                var result = await _complaintService.GetComplaintsList(customerCode_OR_propertyNumber);
                return Ok(result);
            }

            return Ok(Array.Empty<string>());

        }
        catch (Exception ex)
        {
            return StatusCode(500, ex.InnerException!.Message);
        }

    }


    /// <summary>
    /// Creates/Submit a new complaint
    /// </summary>
    [HttpPost]
    [Route("SubmitComplaint")]
    [Authorize(Policy = "Permission:Complaints.COMPLAINT")]
    public async Task<ActionResult> AddNewComplaint([FromBody] ComplaintCreateDto values)
    {
        try
        {
            var userId = _userContextService.GetUserId();
            if (!string.Equals(userId, values.CreatedBy))
            {
                return Unauthorized();
            }

            if (values.NatureOfComplaintId!.Count() == 0)
            {
                return StatusCode(204, "Nature of complaint cannot be null or empty");
            }

            var result = await _complaintService.AddNewComplaint(values);
            return Ok(result);
            //if (result.IsSuccess)
            //{
            //    return Ok(result.SuccessResponse);
            //}

            //var status = result.ErrorResponse!.StatusCode;
            //return status switch
            //{
            //    204 => NoContent(),
            //    400 => BadRequest(result.ErrorResponse),
            //    404 => NotFound(result.ErrorResponse),
            //    _ => StatusCode(500, result.ErrorResponse),
            //};

        }
        catch (Exception ex)
        {
            return StatusCode(500, ex.InnerException!.Message);
        }
    }

    /// <summary>
    /// Reviews an existing complaint
    /// </summary>
    [HttpPut]
    [Route("ReviewComplaint")]
    [Authorize(Policy = "Permission:Complaints.UPDATE")]
    public async Task<ActionResult> ReviewComplaint([FromBody] ComplaintReviewDto values)
    {
        try
        {
            //var userId = _userContextService.GetUserId();
            //if (!string.Equals(userId, values.CreatedBy))
            //{
            //    return Unauthorized();
            //}

            var result = await _complaintService.ReviewComplaint(values);
            return Ok(result);
            //if (result.IsSuccess)
            //{
            //    return Ok(result.SuccessResponse);
            //}

            //var status = result.ErrorResponse!.StatusCode;
            //return status switch
            //{
            //    204 => NoContent(),
            //    400 => BadRequest(result.ErrorResponse),
            //    404 => NotFound(result.ErrorResponse),
            //    _ => StatusCode(500, result.ErrorResponse),
            //};

        }
        catch (Exception ex)
        {
            return StatusCode(500, ex.InnerException!.Message);
        }
    }

    /// <summary>
    /// Assigns an existing complaint
    /// </summary>
    [HttpPut]
    [Route("AssignComplaint")]
    [Authorize(Policy = "Permission:Complaints.UPDATE")]
    public async Task<ActionResult> AssignComplaint([FromBody] ComplaintAssignDto values)
    {
        try
        {
            //var userId = _userContextService.GetUserId();
            //if (!string.Equals(userId, values.CreatedBy))
            //{
            //    return Unauthorized();
            //}

            var result = await _complaintService.AssignComplaint(values);
            return Ok(result);
            //if (result.IsSuccess)
            //{
            //    return Ok(result.SuccessResponse);
            //}

            //var status = result.ErrorResponse!.StatusCode;
            //return status switch
            //{
            //    204 => NoContent(),
            //    400 => BadRequest(result.ErrorResponse),
            //    404 => NotFound(result.ErrorResponse),
            //    _ => StatusCode(500, result.ErrorResponse),
            //};

        }
        catch (Exception ex)
        {
            return StatusCode(500, ex.InnerException!.Message);
        }
    }

    /// <summary>
    /// Resolve an existing complaint
    /// </summary>
    [HttpPut]
    [Route("ResolveComplaint")]
    [Authorize(Policy = "Permission:Complaints.UPDATE")]
    public async Task<ActionResult> ResolveComplaint([FromBody] ComplaintResolutionDto values)
    {
        try
        {
            //var userId = _userContextService.GetUserId();
            //if (!string.Equals(userId, values.CreatedBy))
            //{
            //    return Unauthorized();
            //}

            var result = await _complaintService.ResolveComplaint(values);
            return Ok(result);
            //if (result.IsSuccess)
            //{
            //    return Ok(result.SuccessResponse);
            //}

            //var status = result.ErrorResponse!.StatusCode;
            //return status switch
            //{
            //    204 => NoContent(),
            //    400 => BadRequest(result.ErrorResponse),
            //    404 => NotFound(result.ErrorResponse),
            //    _ => StatusCode(500, result.ErrorResponse),
            //};

        }
        catch (Exception ex)
        {
            return StatusCode(500, ex.InnerException!.Message);
        }
    }

}

