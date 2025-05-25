using Microsoft.AspNetCore.Mvc;
using Asp.Versioning;
using Modules.Estates.Application.DTO.Setup;
using Modules.Estates.Application.Services;

namespace Modules.Estates.Presentation.Controllers.v1;

public partial class PropertyController
{
    /// <summary>
    /// Returns a list of floor areas
    /// </summary>
    [HttpGet]
    [Route("GetFloorArea")]
    public async Task<ActionResult<IEnumerable<FloorAreaReadDto>>> GetFloorArea()
    {
        return Ok(await _blockServices.GetFloorAreaAsync());
    }

    /// <summary>
    /// Creates a new floor area
    /// </summary>
    /// <remarks>
    /// Creates a new floor area in the system
    ///
    /// **Sample Request:**
    ///
    ///     POST /CreateFloorArea
    ///
    /// **Sample Request Body:**
    /// 
    ///     {
    ///         "floorAreaId": 0,
    ///         "floorArea": "100",
    ///         "floorAreaDescription": "100 square meters",
    ///         "createdBy": "32ea339b-75f2-4f57-8153-915f127a9612"
    ///     }
    ///
    /// **Sample Response 201:**
    /// 
    ///     {
    ///         "code": 201,
    ///         "message": "Floor area created successfully.",
    ///         "data": {
    ///             "floorAreaId": 1,
    ///             "floorArea": "100",
    ///             "floorAreaDescription": "100 square meters"
    ///         }
    ///     }
    /// </remarks>
    [HttpPost]
    [Route("CreateFloorArea")]
    [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(SuccessResponseDto))]
    [ProducesResponseType(StatusCodes.Status204NoContent, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
    public async Task<ActionResult> CreateFloorArea([FromBody] FloorAreaCreateDto values)
    {
        try
        {
            var result = await _blockServices.CreateFloorAreaAsync(values);

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
    /// Updates the details of an existing floor area
    /// </summary>
    /// <remarks>
    /// Modifies/updates an existing floor area based on the floor area id 
    ///
    /// **Sample Request:**
    ///
    ///     PUT /UpdateFloorArea
    ///
    /// **Sample Request Body:**
    /// 
    ///     {
    ///         "floorAreaId": 1,
    ///         "floorArea": "100",
    ///         "floorAreaDescription": "Updated 100 square meters",
    ///         "modifiedBy": "32ea339b-75f2-4f57-8153-915f127a9612"
    ///     }
    ///
    /// **Sample Response 200:**
    /// 
    ///     {
    ///         "code": 200,
    ///         "message": "Floor area details modified successfully.",
    ///         "data": {
    ///             "floorAreaId": 1,
    ///             "floorArea": "100",
    ///             "floorAreaDescription": "Updated 100 square meters"
    ///         }
    ///     }
    /// </remarks>
    [HttpPut]
    [Route("UpdateFloorArea")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SuccessResponseDto))]
    [ProducesResponseType(StatusCodes.Status204NoContent, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
    public async Task<ActionResult<FloorAreaReadDto>> UpdateFloorArea([FromBody] FloorAreaUpdateDto values)
    {
        var result = await _blockServices.UpdateFloorAreaAsync(values);

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
    /// Deletes a floor area by its ID
    /// </summary>
    /// <param name="floorAreaId">The ID of the floor area to delete</param>
    /// <returns>Success or error response</returns>
    [HttpDelete("DeleteFloorArea/{floorAreaId}")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SuccessResponseDto))]
    [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
    public async Task<ActionResult> DeleteFloorArea(int floorAreaId)
    {
        try
        {
            var result = await _blockServices.DeleteFloorArea(floorAreaId);

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
    /// Returns a list of floor numbering
    /// </summary>
    [HttpGet]
    [Route("GetFloorNumbering")]
    public async Task<ActionResult<IEnumerable<FloorNumberingReadDto>>> GetFloorNumbering()
    {
        return Ok(await _blockServices.GetFloorNumberingAsync());
    }

    /// <summary>
    /// Creates a new floor number
    /// </summary>
    /// <remarks>
    /// Creates a new floor number in the system
    ///
    /// **Sample Request:**
    ///
    ///     POST /CreateFloorNumber
    ///
    /// **Sample Request Body:**
    /// 
    ///     {
    ///         "floorNumberId": 0,
    ///         "floorNumber": "1",
    ///         "floorNumberDescription": "First Floor",
    ///         "createdBy": "32ea339b-75f2-4f57-8153-915f127a9612"
    ///     }
    ///
    /// **Sample Response 201:**
    /// 
    ///     {
    ///         "code": 201,
    ///         "message": "Floor number created successfully.",
    ///         "data": {
    ///             "floorNumberId": 1,
    ///             "floorNumber": "1",
    ///             "floorNumberDescription": "First Floor"
    ///         }
    ///     }
    /// </remarks>
    [HttpPost]
    [Route("CreateFloorNumber")]
    [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(SuccessResponseDto))]
    [ProducesResponseType(StatusCodes.Status204NoContent, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
    public async Task<ActionResult> CreateFloorNumber([FromBody] FloorNumberingCreateDto values)
    {
        try
        {
            var result = await _blockServices.CreateFloorNumberAsync(values);

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
    /// Updates the details of an existing floor number
    /// </summary>
    /// <remarks>
    /// Modifies/updates an existing floor number based on the floor number id 
    ///
    /// **Sample Request:**
    ///
    ///     PUT /UpdateFloorNumber
    ///
    /// **Sample Request Body:**
    /// 
    ///     {
    ///         "floorNumberId": 1,
    ///         "floorNumber": "1",
    ///         "floorNumberDescription": "Updated First Floor",
    ///         "modifiedBy": "32ea339b-75f2-4f57-8153-915f127a9612"
    ///     }
    ///
    /// **Sample Response 200:**
    /// 
    ///     {
    ///         "code": 200,
    ///         "message": "Floor number details modified successfully.",
    ///         "data": {
    ///             "floorNumberId": 1,
    ///             "floorNumber": "1",
    ///             "floorNumberDescription": "Updated First Floor"
    ///         }
    ///     }
    /// </remarks>
    [HttpPut]
    [Route("UpdateFloorNumber")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SuccessResponseDto))]
    [ProducesResponseType(StatusCodes.Status204NoContent, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
    public async Task<ActionResult<FloorNumberingReadDto>> UpdateFloorNumber([FromBody] FloorNumberingUpdateDto values)
    {
        var result = await _blockServices.UpdateFloorNumberAsync(values);

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
    /// Deletes a floor number by its ID
    /// </summary>
    /// <param name="floorNumberId">The ID of the floor number to delete</param>
    /// <returns>Success or error response</returns>
    [HttpDelete("DeleteFloorNumber/{floorNumberId}")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SuccessResponseDto))]
    [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
    public async Task<ActionResult> DeleteFloorNumber(int floorNumberId)
    {
        try
        {
            var result = await _blockServices.DeleteFloorNumbering(floorNumberId);

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