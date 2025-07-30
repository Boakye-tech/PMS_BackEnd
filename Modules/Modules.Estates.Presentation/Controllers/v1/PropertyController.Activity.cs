// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Presentation
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Presentation/Controllers/v1/PropertyController.Activity.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 12/05/2025 01:09 AM 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

using Microsoft.AspNetCore.Mvc;


namespace Modules.Estates.Presentation.Controllers.v1;

public partial class PropertyController
{
    /// <summary>
    /// Returns a list of activities and their types
    /// </summary>
    [HttpGet]
    [Route("GetActivityAndActivityTypes")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<ActivityAndActivityTypeReadDto>))]
    public async Task<ActionResult<List<ActivityAndActivityTypeReadDto>>> GetActivityAndActivityTypes([FromServices] IActivityService _activityService)
    {
        return Ok(await _activityService.GeActivityAndActivityTypeAsync());
    }

    /// <summary>
    /// Returns a list of activities
    /// </summary>
    [HttpGet]
    [Route("GetActivities")]
    public async Task<ActionResult<IEnumerable<ActivityReadDto>>> GetActivities([FromServices] IActivityService _activityService)
    {
        return Ok(await _activityService.GetActivitiesAsync());
    }

    /// <summary>
    /// Creates a new activity
    /// </summary>
    /// <remarks>
    /// The various activities undertaken during the aquisition process
    ///
    /// **Sample Request:**
    ///
    ///     POST /CreateActivity
    ///
    /// **Sample Request Body:**
    /// 
    ///     {
    ///         "activityId": 0,
    ///         "activityName": "LETTERS",
    ///         "activityDescription": "VARIOUS LETTERS REQUIRED IN THE ACQUISITION PROCESS",
    ///         "createdBy": "32ea339b-75f2-4f57-8153-915f127a9612"
    ///     }
    ///
    /// **Sample Response 201:**
    /// 
    ///     {
    ///         "code": 201,
    ///         "message": "Activity created successfully.",
    ///         "data": {
    ///             "activityId": 1,
    ///             "activityName": "LETTERS",
    ///             "activityDescription": "VARIOUS LETTERS REQUIRED IN THE ACQUISITION PROCESS"
    ///         }
    ///     }
    /// </remarks>
    [HttpPost]
    [Route("CreateActivity")]
    [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(SuccessResponseDto))]
    [ProducesResponseType(StatusCodes.Status204NoContent, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
    public async Task<ActionResult> CreateActivity([FromBody] ActivityCreateDto values, [FromServices] IActivityService _activityService)
    {
        try
        {
            var result = await _activityService.CreateActivityAsync(values);

            if (result.IsSuccess)
            {
                return StatusCode(StatusCodes.Status201Created, result.SuccessResponse);
            }

            var status = result.ErrorResponse!.Code;
            return status switch
            {
                204 => StatusCode(StatusCodes.Status204NoContent, result.ErrorResponse),
                400 => BadRequest(result.ErrorResponse),
                404 => NotFound(result.ErrorResponse),
                _ => StatusCode(StatusCodes.Status500InternalServerError, result.ErrorResponse),
            };
        }
        catch (Exception ex)
        {
            return StatusCode(StatusCodes.Status500InternalServerError, ex.InnerException!.Message);
        }
    }

    /// <summary>
    /// Updates the details of an existing activity
    /// </summary>
    /// <remarks>
    /// Modifies/updates an existing activity based on the activity id 
    ///
    /// **Sample Request:**
    ///
    ///     PUT /UpdateActivity
    ///
    /// **Sample Request Body:**
    /// 
    ///     {
    ///         "activityId": 1,
    ///         "activityName": "LETTERS",
    ///         "activityDescription": "VARIOUS LETTERS REQUIRED IN THE ACQUISITION PROCESS",
    ///         "modifiedBy": "32ea339b-75f2-4f57-8153-915f127a9612"
    ///     }
    ///
    /// **Sample Response 200:**
    /// 
    ///     {
    ///         "code": 200,
    ///         "message": "Activity details modified successfully.",
    ///         "data": {
    ///             "activityId": 1,
    ///             "activityName": "LETTERS",
    ///             "activityDescription": "VARIOUS LETTERS REQUIRED IN THE ACQUISITION PROCESS"
    ///         }
    ///     }
    /// </remarks>
    [HttpPut]
    [Route("UpdateActivity")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SuccessResponseDto))]
    [ProducesResponseType(StatusCodes.Status204NoContent, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
    public async Task<ActionResult<ActivityReadDto>> UpdateActivity([FromBody] ActivityUpdateDto values, [FromServices] IActivityService _activityService)
    {
        var result = await _activityService.UpdateActivityAsync(values);

        if (result.IsSuccess)
        {
            return Ok(result.SuccessResponse);
        }

        var status = result.ErrorResponse!.Code;
        return status switch
        {
            204 => StatusCode(StatusCodes.Status204NoContent, result.ErrorResponse),
            400 => BadRequest(result.ErrorResponse),
            404 => NotFound(result.ErrorResponse),
            _ => StatusCode(StatusCodes.Status500InternalServerError, result.ErrorResponse),
        };
    }

    /// <summary>
    /// Deletes an activity by its ID
    /// </summary>
    /// <param name="activityId">The ID of the activity to delete</param>
    /// <returns>Success or error response</returns>
    [HttpDelete("DeleteActivity/{activityId}")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SuccessResponseDto))]
    [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
    public async Task<ActionResult> DeleteActivity(int activityId, [FromServices] IActivityService _activityService)
    {
        try
        {
            var result = await _activityService.DeleteActivity(activityId);

            if (result.IsSuccess)
            {
                return Ok(result.SuccessResponse);
            }

            var status = result.ErrorResponse!.Code;
            return status switch
            {
                404 => NotFound(result.ErrorResponse),
                _ => StatusCode(StatusCodes.Status500InternalServerError, result.ErrorResponse),
            };
        }
        catch (Exception ex)
        {
            return StatusCode(StatusCodes.Status500InternalServerError, ex.InnerException!.Message);
        }
    }

    /// <summary>
    /// Returns a list of activity types
    /// </summary>
    [HttpGet]
    [Route("GetActivityTypes")]
    public async Task<ActionResult<IEnumerable<ActivityTypeReadDto>>> GetActivityTypes([FromServices] IActivityTypeService _activityTypeService)
    {
        return Ok(await _activityTypeService.GetActivityTypeAsync());
    }

    /// <summary>
    /// Creates a new activity type
    /// </summary>
    /// <remarks>
    /// The various activities types undertaken during the aquisition process
    ///
    /// **Sample Request:**
    ///
    ///     POST /CreateActivityType
    ///
    /// **Sample Request Body:**
    /// 
    ///     {
    ///         "activityId": 1,
    ///         "activityTypeId": 0,
    ///         "activityTypeName": "OFFER LETTER",
    ///         "activityTypeDescription": "A LETTER REQUIRED IN THE ACQUISITION PROCESS, SHOWING THE OFFER MADE TO THE APPLICANT",
    ///         "createdBy": "32ea339b-75f2-4f57-8153-915f127a9612"
    ///     }
    ///
    /// **Sample Response 201:**
    /// 
    ///     {
    ///         "code": 201,
    ///         "message": "Activity Type created successfully.",
    ///         "data": {
    ///             "activityTypeId": 1,
    ///             "activityTypeName": "OFFER LETTER",
    ///             "activityTypeDescription": "A LETTER REQUIRED IN THE ACQUISITION PROCESS"
    ///         }
    ///     }
    /// </remarks>
    [HttpPost]
    [Route("CreateActivityType")]
    [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(SuccessResponseDto))]
    [ProducesResponseType(StatusCodes.Status204NoContent, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
    public async Task<ActionResult> CreateActivityType([FromBody] ActivityTypeCreateDto values, [FromServices] IActivityTypeService _activityTypeService)
    {
        try
        {
            var result = await _activityTypeService.CreateActivityTypeAsync(values);

            if (result.IsSuccess)
            {
                return StatusCode(StatusCodes.Status201Created, result.SuccessResponse);
            }

            var status = result.ErrorResponse!.Code;
            return status switch
            {
                204 => StatusCode(StatusCodes.Status204NoContent, result.ErrorResponse),
                400 => BadRequest(result.ErrorResponse),
                404 => NotFound(result.ErrorResponse),
                _ => StatusCode(StatusCodes.Status500InternalServerError, result.ErrorResponse),
            };
        }
        catch (Exception ex)
        {
            return StatusCode(StatusCodes.Status500InternalServerError, ex.InnerException!.Message);
        }
    }

    /// <summary>
    /// Updates the details of an existing activity type
    /// </summary>
    /// <remarks>
    /// Modifies/updates an existing activity type based on the activity type id 
    ///
    /// **Sample Request:**
    ///
    ///     PUT /UpdateActivityType
    ///
    /// **Sample Request Body:**
    /// 
    ///     {
    ///         "activityTypeId": 1,
    ///         "activityTypeName": "OFFER LETTER",
    ///         "activityTypeDescription": "A LETTER REQUIRED IN THE ACQUISITION PROCESS",
    ///         "modifiedBy": "32ea339b-75f2-4f57-8153-915f127a9612"
    ///     }
    ///
    /// **Sample Response 200:**
    /// 
    ///     {
    ///         "code": 200,
    ///         "message": "Activity Type details modified successfully.",
    ///         "data": {
    ///             "activityTypeId": 1,
    ///             "activityTypeName": "OFFER LETTER",
    ///             "activityTypeDescription": "A LETTER REQUIRED IN THE ACQUISITION PROCESS"
    ///         }
    ///     }
    /// </remarks>
    [HttpPut]
    [Route("UpdateActivityType")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SuccessResponseDto))]
    [ProducesResponseType(StatusCodes.Status204NoContent, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
    public async Task<ActionResult<ActivityTypeReadDto>> UpdateActivityType([FromBody] ActivityTypeUpdateDto values, [FromServices] IActivityTypeService _activityTypeService)
    {
        var result = await _activityTypeService.UpdateActivityTypeAsync(values);

        if (result.IsSuccess)
        {
            return Ok(result.SuccessResponse);
        }

        var status = result.ErrorResponse!.Code;
        return status switch
        {
            204 => StatusCode(StatusCodes.Status204NoContent, result.ErrorResponse),
            400 => BadRequest(result.ErrorResponse),
            404 => NotFound(result.ErrorResponse),
            _ => StatusCode(StatusCodes.Status500InternalServerError, result.ErrorResponse),
        };
    }

    /// <summary>
    /// Deletes an activity type by its ID
    /// </summary>
    /// <param name="activityTypeId">The ID of the activity type to delete</param>
    /// <returns>Success or error response</returns>
    [HttpDelete("DeleteActivityType/{activityTypeId}")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SuccessResponseDto))]
    [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
    public async Task<ActionResult> DeleteActivityType(int activityTypeId, [FromServices] IActivityTypeService _activityTypeService)
    {
        try
        {
            var result = await _activityTypeService.DeleteActivityType(activityTypeId);

            if (result.IsSuccess)
            {
                return Ok(result.SuccessResponse);
            }

            var status = result.ErrorResponse!.Code;
            return status switch
            {
                404 => NotFound(result.ErrorResponse),
                _ => StatusCode(StatusCodes.Status500InternalServerError, result.ErrorResponse),
            };
        }
        catch (Exception ex)
        {
            return StatusCode(StatusCodes.Status500InternalServerError, ex.InnerException!.Message);
        }
    }
}