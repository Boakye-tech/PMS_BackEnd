using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;
using Modules.Legal.Application.Dtos;
using Modules.Legal.Application.Dtos.Setups;
using Modules.Legal.Application.Interfaces.Setups;

namespace Modules.Legal.Presentation.Controllers;


public partial class LegalController : ControllerBase
{
    /// <summary>
    /// Returns a list of all case types
    /// </summary>
    [HttpGet]
    [Route("CaseTypes")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(CaseTypeReadDto))]
    public async Task<ActionResult<IEnumerable<CaseTypeReadDto>>> GetCaseTypes([FromServices] ICaseTypeService _caseTypeService)
    {
        return Ok(await _caseTypeService.GetCaseTypeAsync());
    }

    /// <summary>
    /// Creates a new case type
    /// </summary>
    /// <remarks>
    /// The various case types that legal handles
    ///
    /// **Sample Request:**
    ///
    ///     POST /CaseType
    ///
    /// **Sample Request Body:**
    /// 
    ///     {
    ///         "CaseTypeId": 0,
    ///         "CaseType": "DEBT RECOVERY",
    ///         "createdBy": "32ea339b-75f2-4f57-8153-915f127a9612"
    ///     }
    ///
    /// **Sample Response 201:**
    /// 
    ///     {
    ///         "code": 201,
    ///         "message": "Case type created successfully."
    ///     }
    /// </remarks>
    [HttpPost]
    [Route("CreateCaseType")]
    [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(SuccessResponseDto))]
    [ProducesResponseType(StatusCodes.Status204NoContent, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
    public async Task<ActionResult> CreateCaseType([FromBody] CaseTypeCreateDto values, [FromServices] ICaseTypeService _caseTypeService)
    {
        try
        {
            var result = await _caseTypeService.CreateCaseTypeAsync(values);

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
    /// Updates the details of an case type
    /// </summary>
    /// <remarks>
    /// Modifies/updates an existing case type based on the case type id 
    ///
    /// **Sample Request:**
    ///
    ///     PUT /UpdateCaseTypes
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
    ///         "message": "Case type details modified successfully."
    ///     }
    /// </remarks>
    [HttpPut]
    [Route("UpdateCaseType")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SuccessResponseDto))]
    [ProducesResponseType(StatusCodes.Status204NoContent, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
    public async Task<ActionResult> UpdateCaseType([FromBody] CaseTypeUpdateDto values, [FromServices] ICaseTypeService _caseTypeService)
    {
        var result = await _caseTypeService.UpdateCaseTypeAsync(values);

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
    /// Deletes an existing case type by its ID
    /// </summary>
    /// <param name="caseTypeId">The ID of the case type to delete</param>
    /// <param name="_caseTypeService">The case type service</param>
    /// <returns>Success or error response</returns>
    [HttpDelete("DeleteCaseType/{caseTypeId}")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SuccessResponseDto))]
    [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
    public async Task<ActionResult> DeletecaseType(int caseTypeId, [FromServices] ICaseTypeService _caseTypeService)
    {
        try
        {
            var result = await _caseTypeService.DeleteCaseType(caseTypeId);

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

    #region ConsentType Endpoints

    /// <summary>
    /// Returns a list of all consent types
    /// </summary>
    [HttpGet]
    [Route("ConsentTypes")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ConsentTypeRedDto))]
    public async Task<ActionResult<IEnumerable<ConsentTypeRedDto>>> GetConsentTypes([FromServices] IConsentTypeService _consentTypeService)
    {
        return Ok(await _consentTypeService.GetConsentTypeAsync());
    }

    /// <summary>
    /// Creates a new consent type
    /// </summary>
    [HttpPost]
    [Route("CreateConsentType")]
    [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(SuccessResponseDto))]
    [ProducesResponseType(StatusCodes.Status204NoContent, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
    public async Task<ActionResult> CreateConsentType([FromBody] ConsentTypeCreateDto values, [FromServices] IConsentTypeService _consentTypeService)
    {
        try
        {
            var result = await _consentTypeService.CreateConsentTypeAsync(values);

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
    /// Updates the details of a consent type
    /// </summary>
    [HttpPut]
    [Route("UpdateConsentType")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SuccessResponseDto))]
    [ProducesResponseType(StatusCodes.Status204NoContent, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
    public async Task<ActionResult> UpdateConsentType([FromBody] ConsentTypeUpdateDto values, [FromServices] IConsentTypeService _consentTypeService)
    {
        var result = await _consentTypeService.UpdateConsentTypeAsync(values);

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
    /// Deletes an existing consent type by its ID
    /// </summary>
    /// <param name="consentTypeId">The ID of the consent type to delete</param>
    /// <param name="_consentTypeService">The consent type service</param>
    /// <returns>Success or error response</returns>
    [HttpDelete("DeleteConsentType/{consentTypeId}")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SuccessResponseDto))]
    [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
    public async Task<ActionResult> DeleteConsentType(int consentTypeId, [FromServices] IConsentTypeService _consentTypeService)
    {
        try
        {
            var result = await _consentTypeService.DeleteConsentType(consentTypeId);

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

    #endregion

    #region Court Endpoints

    /// <summary>
    /// Returns a list of all courts
    /// </summary>
    [HttpGet]
    [Route("Courts")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(CourtRedDto))]
    public async Task<ActionResult<IEnumerable<CourtRedDto>>> GetCourts([FromServices] ICourtService _courtService)
    {
        return Ok(await _courtService.GetCourtAsync());
    }

    /// <summary>
    /// Creates a new court
    /// </summary>
    [HttpPost]
    [Route("CreateCourt")]
    [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(SuccessResponseDto))]
    [ProducesResponseType(StatusCodes.Status204NoContent, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
    public async Task<ActionResult> CreateCourt([FromBody] CourtCreateDto values, [FromServices] ICourtService _courtService)
    {
        try
        {
            var result = await _courtService.CreateCourtAsync(values);

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
    /// Updates the details of a court
    /// </summary>
    [HttpPut]
    [Route("UpdateCourt")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SuccessResponseDto))]
    [ProducesResponseType(StatusCodes.Status204NoContent, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
    public async Task<ActionResult> UpdateCourt([FromBody] CourtUpdateDto values, [FromServices] ICourtService _courtService)
    {
        var result = await _courtService.UpdateCourtAsync(values);

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
    /// Deletes an existing court by its ID
    /// </summary>
    /// <param name="courtId">The ID of the court to delete</param>
    /// <param name="_courtService">The court service</param>
    /// <returns>Success or error response</returns>
    [HttpDelete("DeleteCourt/{courtId}")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SuccessResponseDto))]
    [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
    public async Task<ActionResult> DeleteCourt(int courtId, [FromServices] ICourtService _courtService)
    {
        try
        {
            var result = await _courtService.DeleteCourt(courtId);

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

    #endregion

    #region CourtDivision Endpoints

    /// <summary>
    /// Returns a list of all court divisions
    /// </summary>
    [HttpGet]
    [Route("CourtDivisions")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(CourtDivisionRedDto))]
    public async Task<ActionResult<IEnumerable<CourtDivisionRedDto>>> GetCourtDivisions([FromServices] ICourtDivisionService _courtDivisionService)
    {
        return Ok(await _courtDivisionService.GetCourtDivisionAsync());
    }

    /// <summary>
    /// Creates a new court division
    /// </summary>
    [HttpPost]
    [Route("CreateCourtDivision")]
    [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(SuccessResponseDto))]
    [ProducesResponseType(StatusCodes.Status204NoContent, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
    public async Task<ActionResult> CreateCourtDivision([FromBody] CourtDivisionCreateDto values, [FromServices] ICourtDivisionService _courtDivisionService)
    {
        try
        {
            var result = await _courtDivisionService.CreateCourtDivisionAsync(values);

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
    /// Updates the details of a court division
    /// </summary>
    [HttpPut]
    [Route("UpdateCourtDivision")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SuccessResponseDto))]
    [ProducesResponseType(StatusCodes.Status204NoContent, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
    public async Task<ActionResult> UpdateCourtDivision([FromBody] CourtDivisionUpdateDto values, [FromServices] ICourtDivisionService _courtDivisionService)
    {
        var result = await _courtDivisionService.UpdateCourtDivisionAsync(values);

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
    /// Deletes an existing court division by its ID
    /// </summary>
    /// <param name="courtDivisionId">The ID of the court division to delete</param>
    /// <param name="_courtDivisionService">The court division service</param>
    /// <returns>Success or error response</returns>
    [HttpDelete("DeleteCourtDivision/{courtDivisionId}")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SuccessResponseDto))]
    [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
    public async Task<ActionResult> DeleteCourtDivision(int courtDivisionId, [FromServices] ICourtDivisionService _courtDivisionService)
    {
        try
        {
            var result = await _courtDivisionService.DeleteCourtDivision(courtDivisionId);

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

    #endregion

    #region StatusType Endpoints

    /// <summary>
    /// Returns a list of all status types
    /// </summary>
    [HttpGet]
    [Route("StatusTypes")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(StatusTypeRedDto))]
    public async Task<ActionResult<IEnumerable<StatusTypeRedDto>>> GetStatusTypes([FromServices] IStatusTypeService _statusTypeService)
    {
        return Ok(await _statusTypeService.GetStatusTypeAsync());
    }

    /// <summary>
    /// Creates a new status type
    /// </summary>
    [HttpPost]
    [Route("CreateStatusType")]
    [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(SuccessResponseDto))]
    [ProducesResponseType(StatusCodes.Status204NoContent, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
    public async Task<ActionResult> CreateStatusType([FromBody] StatusTypeCreateDto values, [FromServices] IStatusTypeService _statusTypeService)
    {
        try
        {
            var result = await _statusTypeService.CreateStatusTypeAsync(values);

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
    /// Updates the details of a status type
    /// </summary>
    [HttpPut]
    [Route("UpdateStatusType")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SuccessResponseDto))]
    [ProducesResponseType(StatusCodes.Status204NoContent, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
    public async Task<ActionResult> UpdateStatusType([FromBody] StatusTypeUpdateDto values, [FromServices] IStatusTypeService _statusTypeService)
    {
        var result = await _statusTypeService.UpdateStatusTypeAsync(values);

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
    /// Deletes an existing status type by its ID
    /// </summary>
    /// <param name="statusTypeId">The ID of the status type to delete</param>
    /// <param name="_statusTypeService">The status type service</param>
    /// <returns>Success or error response</returns>
    [HttpDelete("DeleteStatusType/{statusTypeId}")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SuccessResponseDto))]
    [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
    public async Task<ActionResult> DeleteStatusType(int statusTypeId, [FromServices] IStatusTypeService _statusTypeService)
    {
        try
        {
            var result = await _statusTypeService.DeleteStatusType(statusTypeId);

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

    #endregion

    #region TransferType Endpoints

    /// <summary>
    /// Returns a list of all transfer types
    /// </summary>
    [HttpGet]
    [Route("TransferTypes")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(TransferTypeRedDto))]
    public async Task<ActionResult<IEnumerable<TransferTypeRedDto>>> GetTransferTypes([FromServices] ITransferTypeService _transferTypeService)
    {
        return Ok(await _transferTypeService.GetTransferTypeAsync());
    }

    /// <summary>
    /// Creates a new transfer type
    /// </summary>
    [HttpPost]
    [Route("CreateTransferType")]
    [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(SuccessResponseDto))]
    [ProducesResponseType(StatusCodes.Status204NoContent, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
    public async Task<ActionResult> CreateTransferType([FromBody] TransferTypeCreateDto values, [FromServices] ITransferTypeService _transferTypeService)
    {
        try
        {
            var result = await _transferTypeService.CreateTransferTypeAsync(values);

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
    /// Updates the details of a transfer type
    /// </summary>
    [HttpPut]
    [Route("UpdateTransferType")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SuccessResponseDto))]
    [ProducesResponseType(StatusCodes.Status204NoContent, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
    public async Task<ActionResult> UpdateTransferType([FromBody] TransferTypeUpdateDto values, [FromServices] ITransferTypeService _transferTypeService)
    {
        var result = await _transferTypeService.UpdateTransferTypeAsync(values);

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
    /// Deletes an existing transfer type by its ID
    /// </summary>
    /// <param name="transferTypeId">The ID of the transfer type to delete</param>
    /// <param name="_transferTypeService">The transfer type service</param>
    /// <returns>Success or error response</returns>
    [HttpDelete("DeleteTransferType/{transferTypeId}")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SuccessResponseDto))]
    [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
    public async Task<ActionResult> DeleteTransferType(int transferTypeId, [FromServices] ITransferTypeService _transferTypeService)
    {
        try
        {
            var result = await _transferTypeService.DeleteTransferType(transferTypeId);

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

    #endregion
}

