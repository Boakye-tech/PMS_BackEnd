using System.Web;
using Asp.Versioning;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Modules.Customers.Application.Dtos.Complaints;

namespace Modules.Customers.Presntation.Controllers.v1;

[ApiController]
[ApiVersion("1.0")]
[Route("api/v{version:apiVersion}/[controller]")]
[Produces("application/json")]
public class ComplaintController : ControllerBase
{
    private readonly ILogger<ComplaintController> _logger;
    private readonly IComplaintTypeService _complaintTypeService;
    private readonly INatureOfComplaintService _natureOfComplaintService;
    private readonly IComplaintService _complaintService;


    public ComplaintController(ILogger<ComplaintController> logger,IComplaintTypeService complaintTypeService, INatureOfComplaintService natureOfComplaintService, IComplaintService complaintService)
    {
        _logger = logger;
        _complaintTypeService = complaintTypeService;
        _natureOfComplaintService = natureOfComplaintService;
        _complaintService = complaintService;
    }



    // POST api/values
    [HttpPost]
    [Route("CreateComplaintType")]
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
    public async Task<IEnumerable<ComplaintTypeDto>> ComplaintType()
    {
        return await _complaintTypeService.GetComplaintTypes();
    }

    [HttpGet("NatureOfComplaint")]
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
    /// Returns a list of complaints
    /// </summary>
    [HttpGet]
    [Route("GetComplaints")]
    [AllowAnonymous]
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
                var result = await _complaintService.GetComplaintDetails(complaintNumber) ;
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
    public async Task<ActionResult> AddNewComplaint([FromBody] ComplaintCreateDto values)
    {
        try
        {
            //var userId = _userContextService.GetUserId();
            //if (!string.Equals(userId, values.CreatedBy))
            //{
            //    return Unauthorized();
            //}

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

