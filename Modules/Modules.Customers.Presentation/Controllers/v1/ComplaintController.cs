// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using Asp.Versioning;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace Modules.Customers.Presntation.Controllers.v1;

[ApiController]
[ApiVersion("1.0")]
[Route("api/v{version:apiVersion}/[controller]")]
[Produces("application/json")]
[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]

/// <summary>
/// Controller responsible for handling complaints-related actions and requests.
/// </summary>
public class ComplaintController : ControllerBase
{
    private readonly ILogger<ComplaintController> _logger;
    private readonly IComplaintTypeService _complaintTypeService;
    private readonly INatureOfComplaintService _natureOfComplaintService;
    private readonly IComplaintService _complaintService;
    private readonly IUserContextService _userContextService;


    /// <summary>
    /// Initializes a new instance of the <see cref="ComplaintController"/> class.
    /// </summary>
    /// <param name="logger">The logger for logging complaints-related information.</param>
    /// <param name="complaintTypeService">The service for handling complaint types.</param>
    /// <param name="natureOfComplaintService">The service for handling nature of complaints.</param>
    /// <param name="complaintService">The service for managing complaints.</param>
    /// <param name="userContextService">The service for managing user context information.</param>
    public ComplaintController(ILogger<ComplaintController> logger,IComplaintTypeService complaintTypeService, INatureOfComplaintService natureOfComplaintService, IComplaintService complaintService, IUserContextService userContextService)
    {
        _logger = logger;
        _complaintTypeService = complaintTypeService;
        _natureOfComplaintService = natureOfComplaintService;
        _complaintService = complaintService;
        _userContextService = userContextService;
    }



    // POST api/values
    /// <summary>
    /// Creates a new complaint type.
    /// </summary>
    /// <remarks>
    /// This endpoint allows the creation of new complaint types that users can select when submitting a complaint.
    /// 
    /// **Sample Request:**
    /// 
    ///     POST /CreateComplaintType
    ///     {
    ///         "complaintTypeId": 0,
    ///         "complaintTypes": "HOME OWNERS COMPLAINT",
    ///         "departmentId": 401,
    ///         "departmentUnitId": 211
    ///     }
    /// 
    /// </remarks>
    /// <param name="values">The complaint type details to create.</param>
    /// <returns>
    /// Returns HTTP 200 OK with the created <see cref="ComplaintTypeDto"/> if successful.  
    /// Returns HTTP 500 Internal Server Error if an unexpected error occurs.
    /// </returns>
    [HttpPost]
    [Route("CreateComplaintType")]
    [Authorize(Policy = "Permission:Complaints.CREATE")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ComplaintTypeDto))]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<ActionResult> CreateComplaintType(ComplaintTypeDto values)
    {
        try
        {
            return Ok(await _complaintTypeService.AddNewComplaintType(values));
        }
        catch (Exception ex)
        {
            _logger.LogError(ex.ToString());
            return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
        }
    }

    // POST api/values
    /// <summary>
    /// Creates a new nature of complaint.
    /// </summary>
    /// <remarks>
    /// This endpoint allows the creation of new nature of complaint that users can multi-select after choosing a complaint type when submitting a complaint.
    /// 
    /// **Sample Request:**
    /// 
    ///     POST /CreateNatureOfComplaint
    ///     {
    ///         "complaintTypeId": 1,
    ///         "natureOfComplaintId": 0,
    ///         "natureOfComplaints": "PLUMBING"
    ///     }
    /// 
    /// </remarks>
    /// <param name="values">The nature of complaint details to create.</param>
    /// <returns>
    /// Returns HTTP 200 OK with the created <see cref="NatureOfComplaintDto"/> if successful.  
    /// Returns HTTP 500 Internal Server Error if an unexpected error occurs.
    /// </returns>
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
            _logger.LogError(ex.ToString());
            return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
        }
    }

    /// <summary>
    /// Retrieves all available complaint types.
    /// </summary>
    /// <remarks>
    /// This endpoint returns a list of complaint types that users can select when submitting a complaint.
    /// 
    /// **Sample Request:**
    /// 
    ///     GET /ComplaintType
    /// 
    /// </remarks>
    /// <returns>
    /// Returns HTTP 200 OK with a list of <see cref="ComplaintTypeDto"/>.
    /// </returns>
    [HttpGet("ComplaintType")]
    [Authorize(Policy = "Permission:Complaints.READ")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<ComplaintTypeDto>))]
    public async Task<IEnumerable<ComplaintTypeDto>> ComplaintType()
    {
        return await _complaintTypeService.GetComplaintTypes();
    }

    /// <summary>
    /// Retrieves the nature of complaints.
    /// </summary>
    /// <remarks>
    /// This endpoint returns a list of complaint natures. 
    /// - If a `complaintId` is provided, it returns the natures related to that complaint type.
    /// - If no `complaintId` is provided (or zero is passed), it returns all available complaint natures.
    /// 
    /// **Sample Request:**
    /// 
    ///     GET /NatureOfComplaint?complaintId=0
    /// 
    /// </remarks>
    /// <param name="complaintId">Optional. The ID of the complaint type to filter natures by. If zero, returns all.</param>
    /// <returns>
    /// Returns HTTP 200 OK with a list of <see cref="NatureOfComplaintDto"/>.
    /// </returns>
    [HttpGet("NatureOfComplaint")]
    [Authorize(Policy = "Permission:Complaints.READ")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<NatureOfComplaintDto>))]
    public async Task<IEnumerable<NatureOfComplaintDto>> NatureOfComplaint([FromQuery] int complaintId)
    {
        if (complaintId == 0)
        {
            return await _natureOfComplaintService.GetNatureOfComplaints();
        }

        return await _natureOfComplaintService.GetNatureOfComplaints(complaintId);
    }


    // PUT api/values
    /// <summary>
    /// Updates an existing complaint type.
    /// </summary>
    /// <remarks>
    /// This endpoint updates the details of an existing complaint type.
    /// 
    /// **Sample Request:**
    /// 
    ///     PUT /UpdateComplaintType
    ///     {
    ///         "complaintTypeId": 1,
    ///         "complaintTypes": "Updated Complaint Type",
    ///         "departmentId": 401,
    ///         "departmentUnitId": 211
    ///     }
    /// 
    /// </remarks>
    /// <param name="values">The updated complaint type details.</param>
    /// <returns>
    /// Returns HTTP 200 OK with the updated <see cref="ComplaintTypeDto"/> if successful.  
    /// Returns HTTP 500 Internal Server Error if an unexpected error occurs.
    /// </returns>
    [HttpPut]
    [Route("UpdateComplaintType")]
    [Authorize(Policy = "Permission:Complaints.UPDATE")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ComplaintTypeDto))]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<ActionResult> UpdateComplaintType(ComplaintTypeDto values)
    {
        try
        {
            return Ok(await _complaintTypeService.UpdateComplaintType(values));
        }
        catch (Exception ex)
        {
            _logger.LogError(ex.ToString());
            return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
        }
    }

    // PUT api/values
    /// <summary>
    /// Updates an existing nature of complaint.
    /// </summary>
    /// <remarks>
    /// This endpoint updates the details of an existing nature of complaint.
    /// 
    /// **Sample Request:**
    /// 
    ///     PUT /UpdateNatureOfComplaint
    ///     {
    ///         "complaintTypeId": 2
    ///         "natureOfComplaintId": 1,
    ///         "natureOfComplaint": "Updated Nature Description",
    ///     }
    /// 
    /// </remarks>
    /// <param name="values">The updated nature of complaint details.</param>
    /// <returns>
    /// Returns HTTP 200 OK with the updated <see cref="NatureOfComplaintDto"/> if successful.  
    /// Returns HTTP 500 Internal Server Error if an unexpected error occurs.
    /// </returns>
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
            _logger.LogError(ex.ToString());
            return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
        }
    }

    /// <summary>
    /// Deletes an existing complaint type.
    /// </summary>
    /// <remarks>
    /// This endpoint deletes a complaint type by its unique identifier.
    /// 
    /// **Sample Request:**
    /// 
    ///     DELETE /DeleteComplaintType/1
    /// 
    /// </remarks>
    /// <param name="complaintTypeId">The ID of the complaint type to delete.</param>
    /// <returns>
    /// Returns HTTP 200 OK if the complaint type is successfully deleted.  
    /// Returns HTTP 500 Internal Server Error if an unexpected error occurs.
    /// </returns>
    [HttpDelete]
    [Route("DeleteComplaintType/{complaintTypeId}")]
    [Authorize(Policy = "Permission:Complaints.DELETE")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<IActionResult> DeleteComplaintType(int complaintTypeId)
    {
        try
        {
            return Ok(await _complaintTypeService.DeleteComplaintType(complaintTypeId));
        }
        catch (Exception ex)
        {
            _logger.LogError(ex.ToString());
            return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
        }
    }

    /// <summary>
    /// Deletes an existing nature of complaint.
    /// </summary>
    /// <remarks>
    /// This endpoint deletes a nature of complaint by its unique identifier.
    /// 
    /// **Sample Request:**
    /// 
    ///     DELETE /DeleteNatureOfComplaint/1
    /// 
    /// </remarks>
    /// <param name="natureOfComplaintId">The ID of the nature of complaint to delete.</param>
    /// <returns>
    /// Returns HTTP 200 OK if the nature of complaint is successfully deleted.  
    /// Returns HTTP 500 Internal Server Error if an unexpected error occurs.
    /// </returns>
    [HttpDelete]
    [Route("DeleteNatureOfComplaint/{natureOfComplaintId}")]
    [Authorize(Policy = "Permission:Complaints.DELETE")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<IActionResult> DeleteNatureOfComplaint(int natureOfComplaintId)
    {
        try
        {
            return Ok(await _natureOfComplaintService.DeleteNatureOfComplaint(natureOfComplaintId));
        }
        catch (Exception ex)
        {
            _logger.LogError(ex.ToString());
            return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
        }
    }

    /// <summary>
    /// Returns a list of complaint sources.
    /// </summary>
    /// <remarks>
    /// This endpoint returns all possible sources from which a complaint can originate.
    /// 
    /// **Sample Request:**
    /// 
    ///     GET /ComplaintSources
    /// 
    /// **Sample Response:**
    /// 
    ///     [
    ///         {
    ///             "id": 1,
    ///             "name": "CUSTOMER",
    ///             "displayName": "Online customer self service submission"
    ///         },
    ///         {
    ///             "id": 2,
    ///             "name": "STAFF",
    ///             "displayName": "Offline customer staff assisted submission"
    ///         }
    ///     ]
    /// 
    /// </remarks>
    /// <returns>
    /// Returns HTTP 200 OK with a list of complaint sources.  
    /// Returns HTTP 500 Internal Server Error if an unexpected error occurs.
    /// </returns>
    [HttpGet]
    [Route("ComplaintSources")]
    [Authorize(Policy = "Permission:Complaints.READ")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public IActionResult ComplaintSources()
    {
        var statuses = Enum.GetValues(typeof(ComplaintSource))
                               .Cast<ComplaintSource>()
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
    /// Returns a list of complaint statuses.
    /// </summary>
    /// <remarks>
    /// This endpoint returns all possible statuses that a complaint can have.
    /// 
    /// **Sample Request:**
    /// 
    ///     GET /ComplaintStatus
    /// 
    /// **Sample Response:**
    /// 
    ///     [
    ///         {
    ///             "id": 1,
    ///             "name": "SUBMITTED",
    ///             "displayName": "Submit Complaint"
    ///         },
    ///         {
    ///             "id": 2,
    ///             "name": "RESOLVED",
    ///             "displayName": "Complaint Resolved"
    ///         }
    ///     ]
    /// 
    /// </remarks>
    /// <returns>
    /// Returns HTTP 200 OK with a list of complaint statuses.  
    /// Returns HTTP 500 Internal Server Error if an unexpected error occurs.
    /// </returns>
    [HttpGet]
    [Route("ComplaintStatus")]
    [Authorize(Policy = "Permission:Complaints.READ")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
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
    /// Returns the details of a specific complaint based on the provided complaint number.
    /// </summary>
    /// <remarks>
    /// Retrieves all available information for a complaint using its unique complaint number.
    ///
    /// **Sample Request:**
    /// 
    ///     GET /GetComplaintDetails/complaintNumber?complaintNumber=C85890
    ///
    /// **Sample Response:**
    /// 
    ///     {
    ///         "complaintId": 10,
    ///         "complaintNumber": "C85890",
    ///         "complaintTypeId": 2,
    ///         "complaintType": "ALL COMPLAINT",
    ///         "natureOfComplaint": [
    ///             {
    ///                 "natureOfComplaintId": 5,
    ///                 "natureOfComplaint": "ENCROACHMENT"
    ///             },
    ///             {
    ///                 "natureOfComplaintId": 6,
    ///                 "natureOfComplaint": "OTHERS"
    ///             }
    ///         ],
    ///         "propertyNumber": "CPL/C02/DTA/F/980",
    ///         "propertyLocation": "COMMUNITY 2",
    ///         "customerCode": "2A00136",
    ///         "customerName": "Felix Asamoah Yeboah",
    ///         "phoneNumber": "0541234566",
    ///         "emailAddress": "ichigo.kuasacki@example.com",
    ///         "isTheMatterInCourt": "Yes",
    ///         "detailsOfComplaint": "For the past week, there's been extremely loud drilling and hammering from the neighboring unit starting as early as 6:30 AM. It's disturbing my family’s sleep and making it hard to work from home.
    ///                                I understand maintenance is necessary, but can it be rescheduled to a more reasonable time?",
    ///         "complaintDate": "2025-04-23T16:34:09.993493",
    ///         "submittedBy": "Mr. Erin Jaegaer",
    ///         "submittedBy_PhoneNumber": "0541234566",
    ///         "documentList": [
    ///             "https://images/uploads/photo-1537731121640-bc1c4aba9b80.jpg"
    ///         ],
    ///         "complaintStatus": [
    ///             {
    ///                 "complaintStatus": "DISPATCHED",
    ///                 "complaintDescription": "COMPLAINT FORWARDED TO THE APPROPRIATE DEPARTMENT.",
    ///                 "actionOn": "2025-04-23T17:59:06.7948368"
    ///             },
    ///             {
    ///                 "complaintStatus": "ACKNOWLEDGED",
    ///                 "complaintDescription": "COMPLAINT HAS BEEN ACKNOWLEDGED BY THE ORGANIZATION.",
    ///                 "actionOn": "2025-04-23T17:58:26.7686158"
    ///             },
    ///             {
    ///                 "complaintStatus": "SUBMITTED",
    ///                 "complaintDescription": "COMPLAINT HAS BEEN SUBMITTED BY THE CUSTOMER.",
    ///                 "actionOn": "2025-04-23T17:55:44.2153875"
    ///             }
    ///         ]
    ///     }
    /// </remarks>
    /// <param name="complaintNumber">The unique identifier of the complaint to retrieve.</param>
    /// <returns>
    /// Returns HTTP 200 OK with the complaint details if found.  
    /// Returns HTTP 400 Bad Request if the complaint number is missing or invalid.  
    /// Returns HTTP 404 Not Found if no complaint exists for the provided number.  
    /// Returns HTTP 500 Internal Server Error if an unexpected error occurs.
    /// </returns>
    [HttpGet]
    [Route("GetComplaintDetails/complaintNumber")]
    [Authorize(Policy = "Permission:Complaints.READ")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ComplaintDto))]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
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
            _logger.LogError(ex.ToString());
            return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
        }

    }

    /// <summary>
    /// Retrieves complaint records based on provided query parameters.
    /// </summary>
    /// <remarks>
    ///  - Provide either <c>complaintNumber</c> or <c>customerCode_OR_propertyNumber</c> as query parameters.
    /// - If both are omitted, a 400 Bad Request response is returned.
    ///
    /// **Query Parameters:**
    /// - `complaintNumber` (optional): The unique complaint number to search by.
    /// - `customerCode_OR_propertyNumber` (optional): The customer code or property number to search by.
    ///
    /// **Behavior:**
    /// - If `complaintNumber` is provided, returns a single complaint summary.
    /// - If `customerCode_OR_propertyNumber` is provided, returns a list of complaints related to it.
    /// - If neither parameter is provided, a 400 Bad Request response is returned.
    ///
    /// **Sample Request (by Complaint Number):**
    /// 
    ///     GET /GetComplaints?complaintNumber=C85890
    /// 
    /// **Sample Response (by Complaint Number):**
    /// 
    ///     {
    ///         "complaintNumber": "C85890",
    ///         "natureOfComplaint": [
    ///             "ENCROACHMENT",
    ///             "OTHERS"
    ///         ],
    ///         "propertyNumber": "CPL/C02/DTA/F/980",
    ///         "complaintDate": "2025-04-23T16:34:09.993493",
    ///         "complaintStatus": "REVIEWED"
    ///     }
    ///
    /// **Sample Request (by Customer Code or Property Number):**
    /// 
    ///     GET /GetComplaints?customerCode_OR_propertyNumber=CPL/C02/DTA/F/980
    /// 
    /// **Sample Response (by Customer Code or Property Number):**
    /// 
    ///     [
    ///         {
    ///             "complaintNumber": "C1780",
    ///             "natureOfComplaint": [
    ///                 "PLUMBING"
    ///             ],
    ///             "propertyNumber": "CPL/C02/DTA/F/980",
    ///             "complaintDate": "2025-04-23T16:43:20.530213",
    ///             "complaintStatus": "SUBMITTED"
    ///         },
    ///         {
    ///             "complaintNumber": "C85890",
    ///             "natureOfComplaint": [
    ///                 "ENCROACHMENT",
    ///                 "OTHERS"
    ///             ],
    ///             "propertyNumber": "CPL/C02/DTA/F/980",
    ///             "complaintDate": "2025-04-23T16:34:09.993493",
    ///             "complaintStatus": "REVIEWED"
    ///         },
    ///         {
    ///             "complaintNumber": "C35936",
    ///             "natureOfComplaint": [
    ///                 "ENCROACHMENT"
    ///             ],
    ///             "propertyNumber": "CPL/C02/DTA/F/980",
    ///             "complaintDate": "2025-04-23T15:52:36.814875",
    ///             "complaintStatus": "ASSIGNED"
    ///         }
    ///     ]
    /// </remarks>
    /// <param name="complaintNumber">The complaint number to search for (optional).</param>
    /// <param name="customerCode_OR_propertyNumber">The customer code or property number to search for (optional).</param>
    /// <returns>
    /// - 200 OK: A single complaint if complaint number is provided, or a list of complaints if customer code or property number is provided.
    /// - 400 Bad Request: If no query parameters are provided.
    /// - 500 Internal Server Error: If an unexpected error occurs.
    /// </returns>
    /// <response code="200">Complaint(s) retrieved successfully.</response>
    /// <response code="400">No query parameters provided.</response>
    /// <response code="500">An unexpected error occurred on the server.</response>
    [HttpGet]
    [Route("GetComplaints")]
    [Authorize(Policy = "Permission:Complaints.READ")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ComplaintReadDto))] // Single Complaint response
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<ComplaintReadDto>))] // List of Complaints response
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<ActionResult> GetComplaints([FromQuery] string? complaintNumber, [FromQuery] string? customerCode_OR_propertyNumber)
    {
        try
        {

            if (string.IsNullOrWhiteSpace(complaintNumber) && string.IsNullOrWhiteSpace(customerCode_OR_propertyNumber))
            {
                return BadRequest("You must provide either a complaint number or a customer code/property number.");
            }

            object result;

            if (!string.IsNullOrWhiteSpace(complaintNumber))
            {
                result = await _complaintService.GetComplaintSummary(complaintNumber);
            }
            else
            {
                result = await _complaintService.GetComplaintsList(customerCode_OR_propertyNumber!);
            }

            return Ok(result);

        }
        catch (Exception ex)
        {
            _logger.LogError(ex.ToString());
            return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
        }

    }


    /// <summary>
    /// Creates/Submit a new complaint.
    /// </summary>
    /// <remarks>
    /// This endpoint allows users to submit a new complaint with all the necessary details.
    ///
    /// **Sample Request:**
    /// 
    ///     POST /SubmitComplaint
    /// 
    /// **Sample Request Body:**
    /// 
    ///     {
    ///         "complaintTypeId": 2,
    ///         "natureOfComplaintId": [5, 6],
    ///         "complaintNumber": "C85991",
    ///         "propertyNumber": "CPL/C02/DTA/F/981",
    ///         "propertyLocation": "COMMUNITY 3",
    ///         "customerCode": "2A00137",
    ///         "customerName": "Ama Serwaa",
    ///         "phoneNumber": "0549876543",
    ///         "emailAddress": "ama.serwaa@example.com",
    ///         "isTheMatterInCourt": "No",
    ///         "detailsOfComplaint": "The neighbor's construction is blocking my driveway and causing noise disturbances.",
    ///         "availabilityDate": "2025-04-25T09:00:00",
    ///         "submittedBy": "Ms. Ama Serwaa",
    ///         "submittedBy_PhoneNumber": "0549876543",
    ///         "documentImages": ["https://images/uploads/photo-1537731121640-bc1c4aba9b80.jpg"],
    ///         "source": 1,
    ///         "createdBy": "3fba6d17-3e29-4f61-8d8a-1a1f249cf111"
    ///     }
    /// 
    /// **Sample Response 201:**
    /// 
    ///     {
    ///         "responseCode": 201,
    ///         "response": "Complaint submitted successfully with complaint number C85991."
    ///     }
    /// 
    /// **Sample Response 204:**
    /// 
    ///     {
    ///         "responseCode": 204,
    ///         "response": "Nature of complaint cannot be null or empty."
    ///     }
    /// 
    /// **Sample Response 403:**
    /// 
    ///     {
    ///         "responseCode": 403,
    ///         "response": "Sorry you cannot submit complaints on behalf of another customer."
    ///     }
    /// 
    /// **Sample Response 500:**
    /// 
    ///     {
    ///         "responseCode": 500,
    ///         "response": "An unexpected error occurred while processing the complaint."
    ///     }
    /// </remarks>
    /// <param name="values">The complaint details to be submitted.</param>
    /// <returns>
    /// Returns HTTP 201 Created with the response if the complaint is successfully submitted.
    /// Returns HTTP 204 No Content if nature of complaint is empty.
    /// Returns HTTP 403 Forbidden if trying to submit on behalf of another customer.
    /// Returns HTTP 500 Internal Server Error if an unexpected error occurs.
    /// </returns>
    [HttpPost]
    [Route("SubmitComplaint")]
    [Authorize(Policy = "Permission:Complaints.COMPLAINT")]
    [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(GenericResponseDto))]
    [ProducesResponseType(StatusCodes.Status204NoContent, Type = typeof(GenericResponseDto))]
    [ProducesResponseType(StatusCodes.Status403Forbidden, Type = typeof(GenericResponseDto))]
    [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(GenericResponseDto))]
    public async Task<ActionResult> AddNewComplaint([FromBody] ComplaintCreateDto values)
    {
        try
        {
            //var userId = _userContextService.GetUserId();
            //if (!string.Equals(userId, values.CreatedBy))
            //{
            //    return Unauthorized();
            //}

            if(values.Source == ComplaintSource.CUSTOMER)
            {
                var customer_code = _userContextService.UserCode();
                if (!string.Equals(customer_code, values.CustomerCode))
                {
                    return StatusCode(StatusCodes.Status403Forbidden, "Sorry you cannot submit complaints on behalf of another customer.");
                }
            }

            if (values.NatureOfComplaintId!.Count() == 0)
            {
                return StatusCode(StatusCodes.Status204NoContent, "Nature of complaint cannot be null or empty");
            }

            var result = await _complaintService.AddNewComplaint(values);
            var status = result.responseCode;
            return status switch
            {
                201 => StatusCode(StatusCodes.Status201Created, result),
                204 => NoContent(),
                400 => BadRequest(result),
                404 => NotFound(result),
                _ => StatusCode(StatusCodes.Status500InternalServerError, result),
            }; 

        }
        catch (Exception ex)
        {
            _logger.LogError(ex.ToString());
            return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
        }
    }

    /// <summary>
    /// Updates/Modifies an existing complaint.
    /// </summary>
    /// <remarks>
    /// This endpoint allows users to modify an existing complaint by providing the updated details.
    ///
    /// **Sample Request:**
    /// 
    ///     PUT /ModifyComplaint
    /// 
    /// **Sample Request Body:**
    /// 
    ///     {
    ///         "complaintNumber": "C85991",
    ///         "phoneNumber": "0549876543",
    ///         "emailAddress": "ama.serwaa.updated@example.com",
    ///         "isTheMatterInCourt": "No",
    ///         "detailsOfComplaint": "The construction has now been completed, but it caused significant disruption to my property.",
    ///         "availabilityDate": "2025-04-30T09:00:00",
    ///         "documentImages": ["https://images/uploads/photo-1537731121640-bc1c4aba9b80.jpg"],
    ///         "modifiedBy": "2fba6d17-3e29-4f61-8d8a-1a1f249cf111"
    ///     }
    /// 
    /// **Sample Response 200:**
    /// 
    ///     {
    ///         "responseCode": 200,
    ///         "response": "Complaint C85991 has been successfully updated."
    ///     }
    /// 
    /// **Sample Response 204:**
    /// 
    ///     {
    ///         "responseCode": 204,
    ///         "response": "No content. The complaint was not modified."
    ///     }
    /// 
    /// **Sample Response 403:**
    /// 
    ///     {
    ///         "responseCode": 403,
    ///         "response": "You are not authorized to modify this complaint."
    ///     }
    /// 
    /// **Sample Response 500:**
    /// 
    ///     {
    ///         "responseCode": 500,
    ///         "response": "An unexpected error occurred while updating the complaint."
    ///     }
    /// </remarks>
    /// <param name="values">The complaint details to be updated.</param>
    /// <returns>
    /// Returns HTTP 200 OK with the response if the complaint is successfully updated.
    /// Returns HTTP 204 No Content if no changes were made to the complaint.
    /// Returns HTTP 403 Forbidden if the user is unauthorized to modify the complaint.
    /// Returns HTTP 500 Internal Server Error if an unexpected error occurs.
    /// </returns>
    [HttpPut]
    [Route("ModifyComplaint")]
    [Authorize(Policy = "Permission:Complaints.UPDATE")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(GenericResponseDto))]
    [ProducesResponseType(StatusCodes.Status204NoContent, Type = typeof(GenericResponseDto))]
    [ProducesResponseType(StatusCodes.Status403Forbidden, Type = typeof(GenericResponseDto))]
    [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(GenericResponseDto))]
    public async Task<ActionResult> ModifyComplaint([FromBody] ComplaintUpdateDto values)
    {
        try
        {
            var userId = _userContextService.GetUserId();
            if (!string.Equals(userId, values.ModifiedBy))
            {
                return Unauthorized();
            }

            var result = await _complaintService.UpdateComplaint(values);
            var status = result.responseCode;
            return status switch
            {
                200 => Ok(result),
                204 => NoContent(),
                403 => StatusCode(StatusCodes.Status403Forbidden, result),
                _ => StatusCode(StatusCodes.Status500InternalServerError, result),
            };

        }
        catch (Exception ex)
        {
            _logger.LogError(ex.ToString());
            return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
        }
    }

    /// <summary>
    /// Acknowledges a submitted complaint.
    /// </summary>
    /// <remarks>
    /// This endpoint allows users to acknowledge a submitted complaint. Only authorized users are allowed to acknowledge complaints, and the action is restricted based on user roles.
    ///
    /// **Sample Request:**
    /// 
    ///     PUT /AcknowledgeComplaint
    /// 
    /// **Sample Request Body:**
    /// 
    ///     {
    ///         "complaintNumber": "C85991",
    ///         "acknowledgedBy": "2fba6d17-3e29-4f61-8d8a-1a1f249cf111"
    ///     }
    /// 
    /// **Sample Response 200:**
    /// 
    ///     {
    ///         "responseCode": 200,
    ///         "response": "Complaint C85991 has been successfully acknowledged."
    ///     }
    /// 
    /// **Sample Response 204:**
    /// 
    ///     {
    ///         "responseCode": 204,
    ///         "response": "No content. The complaint was not acknowledged."
    ///     }
    /// 
    /// **Sample Response 403:**
    /// 
    ///     {
    ///         "responseCode": 403,
    ///         "response": "The user role is forbidden from accessing this resource."
    ///     }
    /// 
    /// **Sample Response 500:**
    /// 
    ///     {
    ///         "responseCode": 500,
    ///         "response": "An unexpected error occurred while acknowledging the complaint."
    ///     }
    /// </remarks>
    /// <param name="values">The complaint acknowledgment details.</param>
    /// <returns>
    /// Returns HTTP 200 OK with the response if the complaint is successfully acknowledged.
    /// Returns HTTP 204 No Content if no changes were made to the complaint acknowledgment.
    /// Returns HTTP 403 Forbidden if the user is unauthorized to acknowledge the complaint due to role restrictions.
    /// Returns HTTP 500 Internal Server Error if an unexpected error occurs.
    /// </returns>
    [HttpPut]
    [Route("AcknowledgeComplaint")]
    [Authorize(Policy = "Permission:Complaints.UPDATE")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(GenericResponseDto))]
    [ProducesResponseType(StatusCodes.Status204NoContent, Type = typeof(GenericResponseDto))]
    [ProducesResponseType(StatusCodes.Status403Forbidden, Type = typeof(GenericResponseDto))]
    [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(GenericResponseDto))]
    public async Task<ActionResult> AcknowledgeComplaint([FromBody] ComplaintAcknowledgmentDto values)
    {
        try
        {
            var userId = _userContextService.GetUserId();
            if (!string.Equals(userId, values.AcknowledgedBy))
            {
                return Unauthorized();
            }

            var role = _userContextService.GetUserRole(ComplaintSourceDescription.GetEnumDescription(ComplaintSource.CUSTOMER));
            if ((bool)role!)
            {
                return StatusCode(StatusCodes.Status403Forbidden, new GenericResponseDto { responseCode = StatusCodes.Status403Forbidden, response = "The user role is forbidden from accessing this resource." });
            }

            if (values.ComplaintNumber!.Count == 0)
            {
                return StatusCode(StatusCodes.Status204NoContent, new { message = "The complaint number cannot be empty or null, it must contain at least one valid complaint number." });
            }

            var result = await _complaintService.AcknowledgeComplaint(values); //change
            var status = result.responseCode;
            return status switch
            {
                200 => Ok(result),
                204 => StatusCode(StatusCodes.Status204NoContent, result),
                403 => StatusCode(StatusCodes.Status403Forbidden, result),
                _ => StatusCode(StatusCodes.Status500InternalServerError, result),
            };
        }
        catch (Exception ex)
        {
            _logger.LogError(ex.ToString());
            return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
        }
    }

    /// <summary>
    /// Dispatches a submitted complaint to a specified department or unit.
    /// </summary>
    /// <remarks>
    /// This endpoint allows users to dispatch a complaint to a specific department or unit for further handling. It requires the user to specify the complaint number, the department to which the complaint is being dispatched, and optionally the department unit.
    ///
    /// **Sample Request:**
    /// 
    ///     PUT /DispatchComplaint
    /// 
    /// **Sample Request Body:**
    /// 
    ///     {
    ///         "complaintNumber": "C85991",
    ///         "dispatchedBy": "2fba6d17-3e29-4f61-8d8a-1a1f249cf111",
    ///         "dispatchedTo_DepartmentId": 101,
    ///         "dispatchedTo_DepartmentUnitId": 202
    ///     }
    /// 
    /// **Sample Response 200:**
    /// 
    ///     {
    ///         "responseCode": 200,
    ///         "response": "Complaint C85991 has been successfully dispatched."
    ///     }
    /// 
    /// **Sample Response 204:**
    /// 
    ///     {
    ///         "responseCode": 204,
    ///         "response": "No content. The complaint was not dispatched."
    ///     }
    /// 
    /// **Sample Response 400:**
    /// 
    ///     {
    ///         "responseCode": 400,
    ///         "response": "Bad request due to missing or invalid fields."
    ///     }
    /// 
    /// **Sample Response 500:**
    /// 
    ///     {
    ///         "responseCode": 500,
    ///         "response": "An unexpected error occurred while dispatching the complaint."
    ///     }
    /// </remarks>
    /// <param name="values">The complaint dispatch details.</param>
    /// <returns>
    /// Returns HTTP 200 OK with the response if the complaint is successfully dispatched.
    /// Returns HTTP 204 No Content if no changes were made to the dispatch.
    /// Returns HTTP 400 Bad Request if the request is missing or has invalid fields.
    /// Returns HTTP 500 Internal Server Error if an unexpected error occurs.
    /// </returns>
    [HttpPut]
    [Route("DispatchComplaint")]
    [Authorize(Policy = "Permission:Complaints.UPDATE")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(GenericResponseDto))]
    [ProducesResponseType(StatusCodes.Status204NoContent, Type = typeof(GenericResponseDto))]
    [ProducesResponseType(StatusCodes.Status403Forbidden, Type = typeof(GenericResponseDto))]
    [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(GenericResponseDto))]
    public async Task<ActionResult> DispatchComplaint([FromBody] ComplaintDispatchedDto values)
    {
        try
        {
            var userId = _userContextService.GetUserId();
            if (!string.Equals(userId, values.DispatchedBy))
            {
                return Unauthorized();
            }

            var role = _userContextService.GetUserRole(ComplaintSourceDescription.GetEnumDescription(ComplaintSource.CUSTOMER));
            if ((bool)role!)
            {
                return StatusCode(StatusCodes.Status403Forbidden, new GenericResponseDto{ response = "The user role is forbidden from accessing this resource." });
            }

            var result = await _complaintService.DispatchComplaint(values);
            var status = result.responseCode;
            return status switch
            {
                200 => Ok(result),
                204 => StatusCode(StatusCodes.Status204NoContent, result),
                403 => StatusCode(StatusCodes.Status403Forbidden, result),
                _ => StatusCode(StatusCodes.Status500InternalServerError, result),
            };
        }
        catch (Exception ex)
        {
            _logger.LogError(ex.ToString());
            return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
        }
    }

    /// <summary>
    /// Reviews an existing complaint.
    /// </summary>
    /// <remarks>
    /// This endpoint allows users to review an existing complaint. It requires the user to provide the complaint number and the ID of the user reviewing the complaint.
    ///
    /// **Sample Request:**
    /// 
    ///     PUT /ReviewComplaint
    /// 
    /// **Sample Request Body:**
    /// 
    ///     {
    ///         "complaintNumber": "C85991",
    ///         "reviewedBy": "2fba6d17-3e29-4f61-8d8a-1a1f249cf111"
    ///     }
    /// 
    /// **Sample Response 200:**
    /// 
    ///     {
    ///         "responseCode": 200,
    ///         "response": "Complaint C85991 has been successfully reviewed."
    ///     }
    /// 
    /// **Sample Response 204:**
    /// 
    ///     {
    ///         "responseCode": 204,
    ///         "response": "No content. The complaint was not reviewed."
    ///     }
    /// 
    /// **Sample Response 400:**
    /// 
    ///     {
    ///         "responseCode": 400,
    ///         "response": "Bad request due to missing or invalid fields."
    ///     }
    /// 
    /// **Sample Response 500:**
    /// 
    ///     {
    ///         "responseCode": 500,
    ///         "response": "An unexpected error occurred while reviewing the complaint."
    ///     }
    /// </remarks>
    /// <param name="values">The complaint review details.</param>
    /// <returns>
    /// Returns HTTP 200 OK with the response if the complaint is successfully reviewed.
    /// Returns HTTP 204 No Content if no changes were made to the review.
    /// Returns HTTP 400 Bad Request if the request is missing or has invalid fields.
    /// Returns HTTP 500 Internal Server Error if an unexpected error occurs.
    /// </returns>
    [HttpPut]
    [Route("ReviewComplaint")]
    [Authorize(Policy = "Permission:Complaints.UPDATE")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(GenericResponseDto))]
    [ProducesResponseType(StatusCodes.Status204NoContent, Type = typeof(GenericResponseDto))]
    [ProducesResponseType(StatusCodes.Status403Forbidden, Type = typeof(GenericResponseDto))]
    [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(GenericResponseDto))]
    public async Task<ActionResult> ReviewComplaint([FromBody] ComplaintReviewDto values)
    {
        try
        {
            var userId = _userContextService.GetUserId();
            if (!string.Equals(userId, values.ReviewedBy))
            {
                return Unauthorized();
            }

            var role = _userContextService.GetUserRole(ComplaintSourceDescription.GetEnumDescription(ComplaintSource.CUSTOMER));
            if ((bool)role!)
            {
                return StatusCode(StatusCodes.Status403Forbidden, new GenericResponseDto { response = "The user role is forbidden from accessing this resource." });
            }


            var result = await _complaintService.ReviewComplaint(values);
            var status = result.responseCode;
            return status switch
            {
                200 => Ok(result),
                204 => StatusCode(StatusCodes.Status204NoContent, result),
                403 => StatusCode(StatusCodes.Status403Forbidden, result),
                _ => StatusCode(StatusCodes.Status500InternalServerError, result),
            };

        }
        catch (Exception ex)
        {
            _logger.LogError(ex.ToString());
            return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
        }
    }

    /// <summary>
    /// Assigns an existing complaint to a specific user.
    /// </summary>
    /// <remarks>
    /// This endpoint allows an administrator or authorized user to assign a complaint to another user for further action. 
    /// The request requires the complaint number, the user the complaint is assigned to, and the user assigning it.
    ///
    /// **Sample Request:**
    /// 
    ///     PUT /AssignComplaint
    /// 
    /// **Sample Request Body:**
    /// 
    ///     {
    ///         "complaintNumber": "C85991",
    ///         "assignedTo": "d47f1b9a-75c3-4f6e-8c3e-0740f582e81d",
    ///         "assignedBy": "8a3b1d6f-28ed-4d23-b7bb-3a8a5828ef00"
    ///     }
    /// 
    /// **Sample Response 200:**
    /// 
    ///     {
    ///         "responseCode": 200,
    ///         "response": "Complaint C85991 has been successfully assigned."
    ///     }
    /// 
    /// **Sample Response 204:**
    /// 
    ///     {
    ///         "responseCode": 204,
    ///         "response": "No content. The complaint was not assigned."
    ///     }
    /// 
    /// **Sample Response 400:**
    /// 
    ///     {
    ///         "responseCode": 400,
    ///         "response": "Bad request due to missing or invalid fields."
    ///     }
    /// 
    /// **Sample Response 500:**
    /// 
    ///     {
    ///         "responseCode": 500,
    ///         "response": "An unexpected error occurred while assigning the complaint."
    ///     }
    /// </remarks>
    /// <param name="values">The complaint assignment details.</param>
    /// <returns>
    /// Returns HTTP 200 OK with the response if the complaint is successfully assigned.
    /// Returns HTTP 204 No Content if no changes were made to the assignment.
    /// Returns HTTP 400 Bad Request if the request is missing or has invalid fields.
    /// Returns HTTP 500 Internal Server Error if an unexpected error occurs.
    /// </returns>
    [HttpPut]
    [Route("AssignComplaint")]
    [Authorize(Policy = "Permission:Complaints.UPDATE")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(GenericResponseDto))]
    [ProducesResponseType(StatusCodes.Status204NoContent, Type = typeof(GenericResponseDto))]
    [ProducesResponseType(StatusCodes.Status403Forbidden, Type = typeof(GenericResponseDto))]
    [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(GenericResponseDto))]
    public async Task<ActionResult> AssignComplaint([FromBody] ComplaintAssignDto values)
    {
        try
        {
            var userId = _userContextService.GetUserId();
            if (!string.Equals(userId, values.AssignedBy))
            {
                return Unauthorized();
            }

            var role = _userContextService.GetUserRole(ComplaintSourceDescription.GetEnumDescription(ComplaintSource.CUSTOMER));
            if ((bool)role!)
            {
                return StatusCode(StatusCodes.Status403Forbidden, new GenericResponseDto { response = "The user role is forbidden from accessing this resource." });
            }

            var result = await _complaintService.AssignComplaint(values);

            var status = result.responseCode;
            return status switch
            {
                200 => Ok(result),
                204 => StatusCode(StatusCodes.Status204NoContent, result),
                403 => StatusCode(StatusCodes.Status403Forbidden, result),
                _ => StatusCode(StatusCodes.Status500InternalServerError, result),
            };

        }
        catch (Exception ex)
        {
            _logger.LogError(ex.ToString());
            return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
        }
    }

    /// <summary>
    /// Resolves an existing complaint by marking it as resolved and adding optional notes.
    /// </summary>
    /// <remarks>
    /// This endpoint allows authorized users to resolve a complaint by providing a resolution note and marking it as resolved. 
    /// The request requires the complaint number, the user resolving the complaint, and optional notes for the resolution.
    ///
    /// **Sample Request:**
    /// 
    ///     PUT /ResolveComplaint
    /// 
    /// **Sample Request Body:**
    /// 
    ///     {
    ///         "complaintNumber": "C85991",
    ///         "resolvedBy": "d47f1b9a-75c3-4f6e-8c3e-0740f582e81d",
    ///         "notes": "The issue has been resolved, and the customer was notified."
    ///     }
    /// 
    /// **Sample Response 200:**
    /// 
    ///     {
    ///         "responseCode": 200,
    ///         "response": "Complaint C85991 has been successfully resolved."
    ///     }
    /// 
    /// **Sample Response 204:**
    /// 
    ///     {
    ///         "responseCode": 204,
    ///         "response": "No content. The complaint was not resolved."
    ///     }
    /// 
    /// **Sample Response 400:**
    /// 
    ///     {
    ///         "responseCode": 400,
    ///         "response": "Bad request due to missing or invalid fields."
    ///     }
    /// 
    /// **Sample Response 500:**
    /// 
    ///     {
    ///         "responseCode": 500,
    ///         "response": "An unexpected error occurred while resolving the complaint."
    ///     }
    /// </remarks>
    /// <param name="values">The complaint resolution details.</param>
    /// <returns>
    /// Returns HTTP 200 OK with the response if the complaint is successfully resolved.
    /// Returns HTTP 204 No Content if no changes were made to resolve the complaint.
    /// Returns HTTP 400 Bad Request if the request is missing or has invalid fields.
    /// Returns HTTP 500 Internal Server Error if an unexpected error occurs.
    /// </returns>
    [HttpPut]
    [Route("ResolveComplaint")]
    [Authorize(Policy = "Permission:Complaints.UPDATE")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(GenericResponseDto))]
    [ProducesResponseType(StatusCodes.Status204NoContent, Type = typeof(GenericResponseDto))]
    [ProducesResponseType(StatusCodes.Status403Forbidden, Type = typeof(GenericResponseDto))]
    [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(GenericResponseDto))]
    public async Task<ActionResult> ResolveComplaint([FromBody] ComplaintResolutionDto values)
    {
        try
        {
            var userId = _userContextService.GetUserId();
            if (!string.Equals(userId, values.ResolvedBy))
            {
                return Unauthorized();
            }

            var role = _userContextService.GetUserRole(ComplaintSourceDescription.GetEnumDescription(ComplaintSource.CUSTOMER));
            if ((bool)role!)
            {
                return StatusCode(StatusCodes.Status403Forbidden, new GenericResponseDto { response = "The user role is forbidden from accessing this resource." });
            }

            var result = await _complaintService.ResolveComplaint(values);
            var status = result.responseCode;
            return status switch
            {
                200 => Ok(result.response),
                204 => NoContent(),
                403 => StatusCode(StatusCodes.Status403Forbidden, result.response),
                _ => StatusCode(StatusCodes.Status500InternalServerError, result.response),
            };

        }
        catch (Exception ex)
        {
            _logger.LogError(ex.ToString());
            return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
        }
    }


    /// <summary>
    /// Re-opens a previously resolved complaint to allow for further investigation or action.
    /// </summary>
    /// <remarks>
    /// This endpoint allows authorized users to re-open a complaint that was previously marked as resolved.
    /// The request requires the complaint number and the user who is re-opening the complaint.
    ///
    /// **Sample Request:**
    /// 
    ///     PUT /ReopenComplaint
    /// 
    /// **Sample Request Body:**
    /// 
    ///     {
    ///         "complaintNumber": "C85991",
    ///         "reopenedBy": "a56f33bf-1234-42d2-bd10-777efb832f6a"
    ///     }
    /// 
    /// **Sample Response 200:**
    /// 
    ///     {
    ///         "responseCode": 200,
    ///         "response": "Complaint C85991 has been successfully reopened."
    ///     }
    /// 
    /// **Sample Response 204:**
    /// 
    ///     {
    ///         "responseCode": 204,
    ///         "response": "No content. The complaint was not reopened."
    ///     }
    /// 
    /// **Sample Response 400:**
    /// 
    ///     {
    ///         "responseCode": 400,
    ///         "response": "Bad request due to missing or invalid fields."
    ///     }
    /// 
    /// **Sample Response 500:**
    /// 
    ///     {
    ///         "responseCode": 500,
    ///         "response": "An unexpected error occurred while reopening the complaint."
    ///     }
    /// </remarks>
    /// <param name="values">The complaint re-opening details.</param>
    /// <returns>
    /// Returns HTTP 200 OK with the response if the complaint is successfully reopened.
    /// Returns HTTP 204 No Content if no changes were made to reopen the complaint.
    /// Returns HTTP 400 Bad Request if the request is missing or has invalid fields.
    /// Returns HTTP 500 Internal Server Error if an unexpected error occurs.
    /// </returns>
    [HttpPut]
    [Route("ReopenComplaint")]
    [Authorize(Policy = "Permission:Complaints.UPDATE")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(GenericResponseDto))]
    [ProducesResponseType(StatusCodes.Status204NoContent, Type = typeof(GenericResponseDto))]
    [ProducesResponseType(StatusCodes.Status403Forbidden, Type = typeof(GenericResponseDto))]
    [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(GenericResponseDto))]
    public async Task<ActionResult> ReopenComplaint([FromBody] ComplaintReopenedDto values)
    {
        try
        {
            var userId = _userContextService.GetUserId();
            if (!string.Equals(userId, values.ReopenedBy))
            {
                return Unauthorized();
            }

            var result = await _complaintService.ReopenComplaint(values);
            var status = result.responseCode;
            return status switch
            {
                200 => Ok(result.response),
                204 => NoContent(),
                403 => StatusCode(StatusCodes.Status403Forbidden, result.response),
                _ => StatusCode(StatusCodes.Status500InternalServerError, result.response),
            };

        }
        catch (Exception ex)
        {
            _logger.LogError(ex.ToString());
            return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
        }
    }

    /// <summary>
    /// Closes a re-opened complaint after resolution or review.
    /// </summary>
    /// <remarks>
    /// This endpoint allows authorized users to close a complaint that has been previously re-opened. 
    /// The complaint will be marked as closed once this operation is successful. The request requires the complaint number 
    /// and the user who is closing the complaint.
    ///
    /// **Sample Request:**
    /// 
    ///     PUT /CloseComplaint
    /// 
    /// **Sample Request Body:**
    /// 
    ///     {
    ///         "complaintNumber": "C85991",
    ///         "closedBy": "a56f33bf-1234-42d2-bd10-777efb832f6a"
    ///     }
    /// 
    /// **Sample Response 200:**
    /// 
    ///     {
    ///         "responseCode": 200,
    ///         "response": "Complaint C85991 has been successfully closed."
    ///     }
    /// 
    /// **Sample Response 204:**
    /// 
    ///     {
    ///         "responseCode": 204,
    ///         "response": "No content. The complaint was not closed."
    ///     }
    /// 
    /// **Sample Response 400:**
    /// 
    ///     {
    ///         "responseCode": 400,
    ///         "response": "Bad request due to missing or invalid fields."
    ///     }
    /// 
    /// **Sample Response 500:**
    /// 
    ///     {
    ///         "responseCode": 500,
    ///         "response": "An unexpected error occurred while closing the complaint."
    ///     }
    /// </remarks>
    /// <param name="values">The complaint closing details.</param>
    /// <returns>
    /// Returns HTTP 200 OK with the response if the complaint is successfully closed.
    /// Returns HTTP 204 No Content if no changes were made to close the complaint.
    /// Returns HTTP 400 Bad Request if the request is missing or has invalid fields.
    /// Returns HTTP 500 Internal Server Error if an unexpected error occurs.
    /// </returns>
    [HttpPut]
    [Route("CloseComplaint")]
    [Authorize(Policy = "Permission:Complaints.UPDATE")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(GenericResponseDto))]
    [ProducesResponseType(StatusCodes.Status204NoContent, Type = typeof(GenericResponseDto))]
    [ProducesResponseType(StatusCodes.Status403Forbidden, Type = typeof(GenericResponseDto))]
    [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(GenericResponseDto))]
    public async Task<ActionResult> CloseComplaint([FromBody] ComplaintClosedDto values)
    {
        try
        {
            var userId = _userContextService.GetUserId();
            if (!string.Equals(userId, values.ClosedBy))
            {
                return Unauthorized();
            }

            var result = await _complaintService.CloseComplaint(values);
            var status = result.responseCode;
            return status switch
            {
                200 => Ok(result.response),
                204 => NoContent(),
                403 => StatusCode(StatusCodes.Status403Forbidden, result.response),
                _ => StatusCode(StatusCodes.Status500InternalServerError, result.response),
            };

        }
        catch (Exception ex)
        {
            _logger.LogError(ex.ToString());
            return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
        }
    }

    /// <summary>
    /// Cancels an existing complaint.
    /// </summary>
    /// <remarks>
    /// This endpoint allows authorized users to cancel a complaint that has not been resolved or processed further. 
    /// The complaint will be marked as cancelled upon successful execution of this operation. The request requires 
    /// the complaint number and the user who is cancelling the complaint.
    ///
    /// **Sample Request:**
    /// 
    ///     PUT /CancelComplaint
    /// 
    /// **Sample Request Body:**
    /// 
    ///     {
    ///         "complaintNumber": "C12456",
    ///         "cancelledBy": "b61d23af-2345-43b1-9c2d-d1d842a3d9f7"
    ///     }
    /// 
    /// **Sample Response 200:**
    /// 
    ///     {
    ///         "responseCode": 200,
    ///         "response": "Complaint C12456 has been successfully cancelled."
    ///     }
    /// 
    /// **Sample Response 204:**
    /// 
    ///     {
    ///         "responseCode": 204,
    ///         "response": "No content. The complaint was not cancelled."
    ///     }
    /// 
    /// **Sample Response 400:**
    /// 
    ///     {
    ///         "responseCode": 400,
    ///         "response": "Bad request due to missing or invalid fields."
    ///     }
    /// 
    /// **Sample Response 500:**
    /// 
    ///     {
    ///         "responseCode": 500,
    ///         "response": "An unexpected error occurred while cancelling the complaint."
    ///     }
    /// </remarks>
    /// <param name="values">The complaint cancellation details.</param>
    /// <returns>
    /// Returns HTTP 200 OK with the response if the complaint is successfully cancelled.
    /// Returns HTTP 204 No Content if no changes were made to cancel the complaint.
    /// Returns HTTP 400 Bad Request if the request is missing or has invalid fields.
    /// Returns HTTP 500 Internal Server Error if an unexpected error occurs.
    /// </returns>
    [HttpPut]
    [Route("CancelComplaint")]
    [Authorize(Policy = "Permission:Complaints.UPDATE")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(GenericResponseDto))]
    [ProducesResponseType(StatusCodes.Status204NoContent, Type = typeof(GenericResponseDto))]
    [ProducesResponseType(StatusCodes.Status403Forbidden, Type = typeof(GenericResponseDto))]
    [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(GenericResponseDto))]
    public async Task<ActionResult> CancelComplaint([FromBody] ComplaintCancellationDto values)
    {
        try
        {
            var userId = _userContextService.GetUserId();
            if (!string.Equals(userId, values.CancelledBy))
            {
                return Unauthorized();
            }

            var result = await _complaintService.CancelComplaint(values);
            var status = result.responseCode;
            return status switch
            {
                200 => Ok(result.response),
                204 => NoContent(),
                403 => StatusCode(StatusCodes.Status403Forbidden, result.response),
                _ => StatusCode(StatusCodes.Status500InternalServerError, result.response),
            };

        }
        catch (Exception ex)
        {
            _logger.LogError(ex.ToString());
            return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
        }
    }

    /// <summary>
    /// Change the status of an existing complaint to IN-PROGRESS
    /// </summary>
    /// <remarks>
    /// This endpoint allows authorized users to manually change the status of an existing complaint to the in-progress status, the complaint should have been dispatched, assigned or reviewed. 
    /// The complaint will be marked as in-progress upon successful execution of this operation. The request requires 
    /// the complaint number and the user who is manually changing the complaint's status from the current status to the in-progress status.
    ///
    /// **Sample Request:**
    /// 
    ///     PUT /InProgressComplaint
    /// 
    /// **Sample Request Body:**
    /// 
    ///     {
    ///         "complaintNumber": "C12456",
    ///         "inprogressBy": "b61d23af-2345-43b1-9c2d-d1d842a3d9f7"
    ///     }
    /// 
    /// **Sample Response 200:**
    /// 
    ///     {
    ///         "responseCode": 200,
    ///         "response": "Complaint C12456 has been successfully been moved from the current status to in-progress."
    ///     }
    /// 
    /// **Sample Response 204:**
    /// 
    ///     {
    ///         "responseCode": 204,
    ///         "response": "No content. The status of the complaint was not changed."
    ///     }
    /// 
    /// **Sample Response 403:**
    /// 
    ///     {
    ///         "responseCode": 403,
    ///         "response": "Bad request due to missing or invalid fields."
    ///     }
    /// 
    /// **Sample Response 500:**
    /// 
    ///     {
    ///         "responseCode": 500,
    ///         "response": "An unexpected error occurred while changing the status of the complaint."
    ///     }
    /// </remarks>
    /// <param name="values">The complaint cancellation details.</param>
    /// <returns>
    /// Returns HTTP 200 OK with the response if the complaint is successfully cancelled.
    /// Returns HTTP 204 No Content if no changes were made to cancel the complaint.
    /// Returns HTTP 400 Bad Request if the request is missing or has invalid fields.
    /// Returns HTTP 500 Internal Server Error if an unexpected error occurs.
    /// </returns>
    [HttpPut]
    [Route("InProgressComplaint")]
    [Authorize(Policy = "Permission:Complaints.UPDATE")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(GenericResponseDto))]
    [ProducesResponseType(StatusCodes.Status204NoContent, Type = typeof(GenericResponseDto))]
    [ProducesResponseType(StatusCodes.Status403Forbidden, Type = typeof(GenericResponseDto))]
    [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(GenericResponseDto))]
    public async Task<ActionResult> InProgressComplaint([FromBody] ComplaintInProgressDto values)
    {
        try
        {
            var userId = _userContextService.GetUserId();
            if (!string.Equals(userId, values.InProgressBy))
            {
                return Unauthorized();
            }

            var result = await _complaintService.InProgressComplaint(values);
            var status = result.responseCode;
            return status switch
            {
                200 => Ok(result.response),
                204 => NoContent(),
                403 => StatusCode(StatusCodes.Status403Forbidden, result.response),
                _ => StatusCode(StatusCodes.Status500InternalServerError, result.response),
            };

        }
        catch (Exception ex)
        {
            _logger.LogError(ex.ToString());
            return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
        }
    }
}

