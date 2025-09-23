// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Finance.Presentation
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Finance.Presentation/Controllers/v1/FinanceController.Penalty.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 22/09/2025 12:37PM 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;
using Modules.Finance.Application.Dtos.Setup;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Modules.Finance.Presentation.Controllers
{

    public partial class FinanceController : ControllerBase
    {
        //---PENALTY TYPES-------
        /// <summary>
        /// Returns a list of all penalty types in the system
        /// </summary>
        [HttpGet]
        [Route("GetPenaltyTypes")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<PenaltyTypeReadDto>))]
        public async Task<ActionResult<List<PenaltyTypeReadDto>>> GetPenaltyTypes([FromServices] IPenaltyTypeService _penaltyType)
        {
            return Ok(await _penaltyType.GetPenaltyTypesAsync());
        }

        /// <summary>
        /// Returns a list of active penalty types in the system
        /// </summary>
        [HttpGet]
        [Route("GetActivePenaltyTypes")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<PenaltyTypeReadDto>))]
        public async Task<ActionResult<List<PenaltyTypeReadDto>>> GetActivePenaltyTypes([FromServices] IPenaltyTypeService _penaltyType)
        {
            return Ok(await _penaltyType.GetActivePenaltyTypesAsync());
        }

        /// <summary>
        /// Returns a specific penalty type by its ID
        /// </summary>
        /// <param name="penaltyTypeId">The ID of the penalty type to retrieve</param>
        [HttpGet]
        [Route("GetPenaltyType/{penaltyTypeId}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(PenaltyTypeReadDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
        public async Task<ActionResult<PenaltyTypeReadDto>> GetPenaltyType([FromServices] IPenaltyTypeService _penaltyType, int penaltyTypeId)
        {
            var result = await _penaltyType.GetPenaltyTypeAsync(penaltyTypeId);
            if (result == null)
            {
                return NotFound(new ErrorResponseDto { Code = StatusCodes.Status404NotFound, Message = "Penalty type not found." });
            }
            return Ok(result);
        }

        // POST: api/CreatePenaltyType
        /// <summary>
        /// Creates a new penalty type record in the system
        /// </summary>
        /// <remarks>
        /// Addition of new penalty type for financial management
        ///
        /// **Sample Request:**
        ///
        ///     POST /CreatePenaltyType
        ///
        /// **Sample Request Body:**
        /// 
        ///     {
        ///         "Name": "Late Payment Fee",
        ///         "Code": "LATE_PAY",
        ///         "Description": "Penalty for late payments",
        ///         "IsActive": true,
        ///         "CreatedBy": "32ea339b-75f2-4f57-8153-915f127a9612"
        ///     }
        ///
        /// **Sample Response 201:**
        /// 
        ///     {
        ///         "code": 201,
        ///         "message": "Penalty type created successfully.",
        ///     }
        /// 
        /// </remarks>
        [HttpPost]
        [Route("CreatePenaltyType")]
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(SuccessResponseDto))]
        [ProducesResponseType(StatusCodes.Status204NoContent, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
        public async Task<ActionResult> CreatePenaltyType([FromServices] IPenaltyTypeService _penaltyType, [FromBody] PenaltyTypeCreateDto values)
        {
            try
            {
                var response = await _penaltyType.CreatePenaltyTypeAsync(values);
                if (response.IsSuccess)
                {
                    return StatusCode(StatusCodes.Status201Created, response.SuccessResponse);
                }
                var status = response.ErrorResponse!.Code;
                return status switch
                {
                    204 => StatusCode(StatusCodes.Status204NoContent, response.ErrorResponse),
                    400 => BadRequest(response.ErrorResponse),
                    404 => NotFound(response.ErrorResponse),
                    _ => StatusCode(StatusCodes.Status500InternalServerError, response.ErrorResponse),
                };
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        // PUT: api/UpdatePenaltyType
        /// <summary>
        /// Updates an existing penalty type record in the system
        /// </summary>
        /// <remarks>
        /// Updates the details of an existing penalty type record
        ///
        /// **Sample Request:**
        ///
        ///     PUT /UpdatePenaltyType
        ///
        /// **Sample Request Body:**
        /// 
        ///     {
        ///         "PenaltyTypeId": 1,
        ///         "Name": "Late Payment Fee Updated",
        ///         "Code": "LATE_PAY_UPD",
        ///         "Description": "Updated penalty for late payments",
        ///         "IsActive": true,
        ///         "ModifiedBy": "32ea339b-75f2-4f57-8153-915f127a9612"
        ///     }
        ///
        /// **Sample Response 200:**
        /// 
        ///     {
        ///         "code": 200,
        ///         "message": "Penalty type updated successfully.",
        ///     }
        /// 
        /// </remarks>
        [HttpPut]
        [Route("UpdatePenaltyType")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SuccessResponseDto))]
        [ProducesResponseType(StatusCodes.Status204NoContent, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
        public async Task<ActionResult> UpdatePenaltyType([FromServices] IPenaltyTypeService _penaltyType, [FromBody] PenaltyTypeUpdateDto values)
        {
            var response = await _penaltyType.UpdatePenaltyTypeAsync(values);

            if (response.IsSuccess)
            {
                return Ok(response.SuccessResponse);
            }

            var status = response.ErrorResponse!.Code;
            return status switch
            {
                204 => StatusCode(StatusCodes.Status204NoContent, response.ErrorResponse),
                400 => BadRequest(response.ErrorResponse),
                404 => NotFound(response.ErrorResponse),
                _ => StatusCode(StatusCodes.Status500InternalServerError, response.ErrorResponse),
            };
        }

        /// <summary>
        /// Toggles the active status of a penalty type
        /// </summary>
        /// <param name="penaltyTypeId">The ID of the penalty type to toggle</param>
        /// <param name="modifiedBy">The user ID modifying the record</param>
        /// <returns>Success or error response</returns>
        [HttpPut("TogglePenaltyTypeStatus/{penaltyTypeId}/{modifiedBy}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SuccessResponseDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
        public async Task<ActionResult> TogglePenaltyTypeStatus([FromServices] IPenaltyTypeService _penaltyType, int penaltyTypeId, string modifiedBy)
        {
            try
            {
                var response = await _penaltyType.TogglePenaltyTypeStatusAsync(penaltyTypeId, modifiedBy);

                if (response.IsSuccess)
                {
                    return Ok(response.SuccessResponse);
                }

                var status = response.ErrorResponse!.Code;
                return status switch
                {
                    404 => NotFound(response.ErrorResponse),
                    _ => StatusCode(StatusCodes.Status500InternalServerError, response.ErrorResponse),
                };
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.InnerException!.Message);
            }
        }

        /// <summary>
        /// Deletes an existing penalty type record by its ID
        /// </summary>
        /// <param name="penaltyTypeId">The ID of the penalty type to delete</param>
        /// <returns>Success or error response</returns>
        [HttpDelete("DeletePenaltyType/{penaltyTypeId}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SuccessResponseDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
        public async Task<ActionResult> DeletePenaltyType([FromServices] IPenaltyTypeService _penaltyType, int penaltyTypeId)
        {
            try
            {
                var response = await _penaltyType.DeletePenaltyTypeAsync(penaltyTypeId);

                if (response.IsSuccess)
                {
                    return Ok(response.SuccessResponse);
                }

                var status = response.ErrorResponse!.Code;
                return status switch
                {
                    404 => NotFound(response.ErrorResponse),
                    _ => StatusCode(StatusCodes.Status500InternalServerError, response.ErrorResponse),
                };
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.InnerException!.Message);
            }
        }

        //---PENALTY RULES-------
        /// <summary>
        /// Returns a list of all penalty rules in the system
        /// </summary>
        [HttpGet]
        [Route("GetPenaltyRules")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<PenaltyRuleReadDto>))]
        public async Task<ActionResult<List<PenaltyRuleReadDto>>> GetPenaltyRules([FromServices] IPenaltyRuleService _penaltyRule)
        {
            return Ok(await _penaltyRule.GetPenaltyRulesAsync());
        }

        /// <summary>
        /// Returns a list of active penalty rules in the system
        /// </summary>
        [HttpGet]
        [Route("GetActivePenaltyRules")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<PenaltyRuleReadDto>))]
        public async Task<ActionResult<List<PenaltyRuleReadDto>>> GetActivePenaltyRules([FromServices] IPenaltyRuleService _penaltyRule)
        {
            return Ok(await _penaltyRule.GetActivePenaltyRulesAsync());
        }

        /// <summary>
        /// Returns penalty rules for a specific penalty type
        /// </summary>
        /// <param name="penaltyTypeId">The ID of the penalty type</param>
        [HttpGet]
        [Route("GetPenaltyRulesByType/{penaltyTypeId}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<PenaltyRuleReadDto>))]
        public async Task<ActionResult<List<PenaltyRuleReadDto>>> GetPenaltyRulesByType([FromServices] IPenaltyRuleService _penaltyRule, int penaltyTypeId)
        {
            return Ok(await _penaltyRule.GetPenaltyRulesByTypeAsync(penaltyTypeId));
        }

        /// <summary>
        /// Returns the current active penalty rule for a specific penalty type
        /// </summary>
        /// <param name="penaltyTypeId">The ID of the penalty type</param>
        [HttpGet]
        [Route("GetCurrentPenaltyRule/{penaltyTypeId}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(PenaltyRuleReadDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
        public async Task<ActionResult<PenaltyRuleReadDto>> GetCurrentPenaltyRule([FromServices] IPenaltyRuleService _penaltyRule, int penaltyTypeId)
        {
            var result = await _penaltyRule.GetCurrentPenaltyRuleAsync(penaltyTypeId);
            if (result == null)
            {
                return NotFound(new ErrorResponseDto { Code = StatusCodes.Status404NotFound, Message = "No active penalty rule found for the specified type." });
            }
            return Ok(result);
        }

        /// <summary>
        /// Returns a specific penalty rule by its ID
        /// </summary>
        /// <param name="penaltyRuleId">The ID of the penalty rule to retrieve</param>
        [HttpGet]
        [Route("GetPenaltyRule/{penaltyRuleId}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(PenaltyRuleReadDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
        public async Task<ActionResult<PenaltyRuleReadDto>> GetPenaltyRule([FromServices] IPenaltyRuleService _penaltyRule, int penaltyRuleId)
        {
            var result = await _penaltyRule.GetPenaltyRuleAsync(penaltyRuleId);
            if (result == null)
            {
                return NotFound(new ErrorResponseDto { Code = StatusCodes.Status404NotFound, Message = "Penalty rule not found." });
            }
            return Ok(result);
        }

        // POST: api/CreatePenaltyRule
        /// <summary>
        /// Creates a new penalty rule record in the system
        /// </summary>
        /// <remarks>
        /// Addition of new penalty rule for financial management
        ///
        /// **Sample Request:**
        ///
        ///     POST /CreatePenaltyRule
        ///
        /// **Sample Request Body:**
        /// 
        ///     {
        ///         "PenaltyTypeId": 1,
        ///         "CalculationMethod": 3,
        ///         "Rate": 10.00,
        ///         "GracePeriodDays": 5,
        ///         "CapAmount": 500.00,
        ///         "EffectiveDate": "2024-01-01",
        ///         "ExpiryDate": "2024-12-31",
        ///         "CreatedBy": "32ea339b-75f2-4f57-8153-915f127a9612"
        ///     }
        ///
        /// **Sample Response 201:**
        /// 
        ///     {
        ///         "code": 201,
        ///         "message": "Penalty rule created successfully.",
        ///     }
        /// 
        /// </remarks>
        [HttpPost]
        [Route("CreatePenaltyRule")]
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(SuccessResponseDto))]
        [ProducesResponseType(StatusCodes.Status204NoContent, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
        public async Task<ActionResult> CreatePenaltyRule([FromServices] IPenaltyRuleService _penaltyRule, [FromBody] PenaltyRuleCreateDto values)
        {
            try
            {
                var response = await _penaltyRule.CreatePenaltyRuleAsync(values);
                if (response.IsSuccess)
                {
                    return StatusCode(StatusCodes.Status201Created, response.SuccessResponse);
                }
                var status = response.ErrorResponse!.Code;
                return status switch
                {
                    204 => StatusCode(StatusCodes.Status204NoContent, response.ErrorResponse),
                    400 => BadRequest(response.ErrorResponse),
                    404 => NotFound(response.ErrorResponse),
                    _ => StatusCode(StatusCodes.Status500InternalServerError, response.ErrorResponse),
                };
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        // PUT: api/UpdatePenaltyRule
        /// <summary>
        /// Updates an existing penalty rule record in the system
        /// </summary>
        /// <remarks>
        /// Updates the details of an existing penalty rule record
        ///
        /// **Sample Request:**
        ///
        ///     PUT /UpdatePenaltyRule
        ///
        /// **Sample Request Body:**
        /// 
        ///     {
        ///         "PenaltyRuleId": 1,
        ///         "CalculationMethod": 3,
        ///         "Rate": 15.00,
        ///         "GracePeriodDays": 7,
        ///         "CapAmount": 750.00,
        ///         "EffectiveDate": "2024-01-01",
        ///         "ExpiryDate": "2024-12-31",
        ///         "ModifiedBy": "32ea339b-75f2-4f57-8153-915f127a9612"
        ///     }
        ///
        /// **Sample Response 200:**
        /// 
        ///     {
        ///         "code": 200,
        ///         "message": "Penalty rule updated successfully.",
        ///     }
        /// 
        /// </remarks>
        [HttpPut]
        [Route("UpdatePenaltyRule")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SuccessResponseDto))]
        [ProducesResponseType(StatusCodes.Status204NoContent, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
        public async Task<ActionResult> UpdatePenaltyRule([FromServices] IPenaltyRuleService _penaltyRule, [FromBody] PenaltyRuleUpdateDto values)
        {
            var response = await _penaltyRule.UpdatePenaltyRuleAsync(values);

            if (response.IsSuccess)
            {
                return Ok(response.SuccessResponse);
            }

            var status = response.ErrorResponse!.Code;
            return status switch
            {
                204 => StatusCode(StatusCodes.Status204NoContent, response.ErrorResponse),
                400 => BadRequest(response.ErrorResponse),
                404 => NotFound(response.ErrorResponse),
                _ => StatusCode(StatusCodes.Status500InternalServerError, response.ErrorResponse),
            };
        }

        /// <summary>
        /// Calculates penalty for a given penalty rule, principal amount, and days late
        /// </summary>
        /// <param name="penaltyRuleId">The ID of the penalty rule</param>
        /// <param name="principalAmount">The principal amount</param>
        /// <param name="daysLate">The number of days late</param>
        [HttpGet("CalculatePenalty/{penaltyRuleId}/{principalAmount}/{daysLate}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(decimal))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
        public async Task<ActionResult<decimal>> CalculatePenalty([FromServices] IPenaltyRuleService _penaltyRule, int penaltyRuleId, decimal principalAmount, int daysLate)
        {
            try
            {
                var penalty = await _penaltyRule.CalculatePenaltyAsync(penaltyRuleId, principalAmount, daysLate);
                return Ok(penalty);
            }
            catch (ArgumentException ex)
            {
                return BadRequest(new ErrorResponseDto { Code = StatusCodes.Status400BadRequest, Message = ex.Message });
            }
            catch (InvalidOperationException ex)
            {
                return BadRequest(new ErrorResponseDto { Code = StatusCodes.Status400BadRequest, Message = ex.Message });
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new ErrorResponseDto { Code = StatusCodes.Status500InternalServerError, Message = ex.Message });
            }
        }

        /// <summary>
        /// Deletes an existing penalty rule record by its ID
        /// </summary>
        /// <param name="penaltyRuleId">The ID of the penalty rule to delete</param>
        /// <returns>Success or error response</returns>
        [HttpDelete("DeletePenaltyRule/{penaltyRuleId}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SuccessResponseDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
        public async Task<ActionResult> DeletePenaltyRule([FromServices] IPenaltyRuleService _penaltyRule, int penaltyRuleId)
        {
            try
            {
                var response = await _penaltyRule.DeletePenaltyRuleAsync(penaltyRuleId);

                if (response.IsSuccess)
                {
                    return Ok(response.SuccessResponse);
                }

                var status = response.ErrorResponse!.Code;
                return status switch
                {
                    404 => NotFound(response.ErrorResponse),
                    _ => StatusCode(StatusCodes.Status500InternalServerError, response.ErrorResponse),
                };
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.InnerException!.Message);
            }
        }


        //---PENALTY TYPES WITH RULES-------

        /// <summary>
        /// Returns a list of all penalty types with their corresponding penalty rules
        /// </summary>
        [HttpGet]
        [Route("GetPenaltyTypesWithRules")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<PenaltyTypeWithRulesReadDto>))]
        public async Task<ActionResult<List<PenaltyTypeWithRulesReadDto>>> GetPenaltyTypesWithRules([FromServices] IPenaltyTypeService _penaltyType)
        {
            return Ok(await _penaltyType.GetPenaltyTypesWithRulesAsync());
        }

        /// <summary>
        /// Returns a specific penalty type with its corresponding penalty rules
        /// </summary>
        /// <param name="penaltyTypeId">The ID of the penalty type to retrieve</param>
        [HttpGet]
        [Route("GetPenaltyTypeWithRules/{penaltyTypeId}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(PenaltyTypeWithRulesReadDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
        public async Task<ActionResult<PenaltyTypeWithRulesReadDto>> GetPenaltyTypeWithRules([FromServices] IPenaltyTypeService _penaltyType, int penaltyTypeId)
        {
            var result = await _penaltyType.GetPenaltyTypeWithRulesAsync(penaltyTypeId);
            if (result == null)
            {
                return NotFound(new ErrorResponseDto { Code = StatusCodes.Status404NotFound, Message = "Penalty type not found." });
            }
            return Ok(result);
        }


    }
}
