// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Presentation
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Presentation/Controllers/v1/PropertyController.OtherSetups.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 12/05/2025 01:09 AM 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Modules.Estates.Presentation.Controllers.v1
{
    public partial class PropertyController
    {
        /// <summary>
        /// Returns a list of all currency exchange rates
        /// </summary>
        [HttpGet]
        [Route("GetCurrencyExchangeRates")]
        public async Task<ActionResult<IEnumerable<CurrencyExchangeRateReadDto>>> GetCurrencyExchangeRates([FromServices] ICurrencyExchangeRateService _currencyService)
        {
            return Ok(await _currencyService.GetCurrencyExchangeRateAsync());
        }

        /// <summary>
        /// Creates a new currency exchange rate
        /// </summary>
        /// <remarks>
        /// Creates a new currency exchange rate in the system
        ///
        /// **Sample Request:**
        ///
        ///     POST /CreateCurrencyExchangeRate
        ///
        /// **Sample Request Body:**
        /// 
        ///     {
        ///         "currencyId": 0,
        ///         "currency": "USD",
        ///         "exchangeRate": 1.0,
        ///         "createdBy": "32ea339b-75f2-4f57-8153-915f127a9612"
        ///     }
        ///
        /// **Sample Response 201:**
        /// 
        ///     {
        ///         "code": 201,
        ///         "message": "Currency exchange rate created successfully.",
        ///         "data": {
        ///             "currencyId": 1,
        ///             "currency": "USD",
        ///             "exchangeRate": 1.0
        ///         }
        ///     }
        /// </remarks>
        [HttpPost]
        [Route("CreateCurrencyExchangeRate")]
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(SuccessResponseDto))]
        [ProducesResponseType(StatusCodes.Status204NoContent, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
        public async Task<ActionResult> CreateCurrencyExchangeRate([FromBody] CurrencyExchangeRateCreateDto values, [FromServices] ICurrencyExchangeRateService _currencyService)
        {
            try
            {
                var userId = _userContextService.GetUserId();

                if (!string.Equals(userId, values.CreatedBy))
                {
                    return Unauthorized();
                }

                var result = await _currencyService.CreateCurrencyExchangeRateAsync(values);

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
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        /// <summary>
        /// Updates the details of an existing currency exchange rate
        /// </summary>
        /// <remarks>
        /// Modifies/updates an existing currency exchange rate based on the currency id 
        ///
        /// **Sample Request:**
        ///
        ///     PUT /UpdateCurrencyExchangeRate
        ///
        /// **Sample Request Body:**
        /// 
        ///     {
        ///         "currencyId": 1,
        ///         "currency": "USD",
        ///         "exchangeRate": 1.1,
        ///         "modifiedBy": "32ea339b-75f2-4f57-8153-915f127a9612"
        ///     }
        ///
        /// **Sample Response 200:**
        /// 
        ///     {
        ///         "code": 200,
        ///         "message": "Currency exchange rate details modified successfully.",
        ///         "data": {
        ///             "currencyId": 1,
        ///             "currency": "USD",
        ///             "exchangeRate": 1.1
        ///         }
        ///     }
        /// </remarks>
        [HttpPut]
        [Route("UpdateCurrencyExchangeRate")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SuccessResponseDto))]
        [ProducesResponseType(StatusCodes.Status204NoContent, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
        public async Task<ActionResult<CurrencyExchangeRateReadDto>> UpdateCurrencyExchangeRate([FromBody] CurrencyExchangeRateUpdateDto values, [FromServices] ICurrencyExchangeRateService _currencyService)
        {
            var userId = _userContextService.GetUserId();

            if (!string.Equals(userId, values.ModifiedBy))
            {
                return Unauthorized();
            }

            var result = await _currencyService.UpdateCurrencyExchangeRateAsync(values);

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
        /// Deletes a currency exchange rate by its ID
        /// </summary>
        /// <param name="currencyId">The ID of the currency exchange rate to delete</param>
        /// <returns>Success or error response</returns>
        [HttpDelete("DeleteCurrencyExchangeRate/{currencyId}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SuccessResponseDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
        public async Task<ActionResult> DeleteCurrencyExchangeRate(int currencyId, [FromServices] ICurrencyExchangeRateService _currencyService)
        {
            try
            {
                var result = await _currencyService.DeleteCurrencyExchangeRateAsync(currencyId);

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
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }



        //------scheme types

        /// <summary>
        /// Returns a list of all scheme types
        /// </summary>
        [HttpGet]
        [Route("GetSchemeTypes")]
        public async Task<ActionResult<IEnumerable<SchemeTypeReadDto>>> GetSchemeTypes([FromServices] ISchemeTypeService _schemeTypeService)
        {
            return Ok(await _schemeTypeService.GetSchemeTypeAsync());
        }

        /// <summary>
        /// Creates a new scheme type
        /// </summary>
        /// <remarks>
        /// Creates a new scheme type in the system
        ///
        /// **Sample Request:**
        ///
        ///     POST /CreateSchemeType
        ///
        /// **Sample Request Body:**
        /// 
        ///     {
        ///         "schemeType": "TDC HOUSE OWNERHISP SCHEME",
        ///         "createdBy": "32ea339b-75f2-4f57-8153-915f127a9612"
        ///     }
        ///
        /// **Sample Response 201:**
        /// 
        ///     {
        ///         "code": 201,
        ///         "message": "Scheme Type created successfully.",
        ///     }
        /// </remarks>
        [HttpPost]
        [Route("CreateSchemeType")]
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(SuccessResponseDto))]
        [ProducesResponseType(StatusCodes.Status204NoContent, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
        public async Task<ActionResult> CreateSchemeType([FromBody] SchemeTypeCreateDto values, [FromServices] ISchemeTypeService _schemeTypeService)
        {
            try
            {
                var userId = _userContextService.GetUserId();

                if (!string.Equals(userId, values.CreatedBy))
                {
                    return Unauthorized();
                }

                var result = await _schemeTypeService.CreateSchemeTypeAsync(values);

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
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        /// <summary>
        /// Updates the details of an existing scheme type
        /// </summary>
        /// <remarks>
        /// Modifies/updates an existing scheme type based on the scheme type id 
        ///
        /// **Sample Request:**
        ///
        ///     PUT /UpdateSchemeType
        ///
        /// **Sample Request Body:**
        /// 
        ///     {
        ///         "schemeTypeId": 1,
        ///         "schemeType": "TDC HOUSE OWNERHISP SCHEME (H.O.S)",
        ///         "modifiedBy": "32ea339b-75f2-4f57-8153-915f127a9612"
        ///     }
        ///
        /// **Sample Response 200:**
        /// 
        ///     {
        ///         "code": 200,
        ///         "message": "Site details modified successfully.",
        ///     }
        /// </remarks>
        [HttpPut]
        [Route("UpdateSchemeType")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SuccessResponseDto))]
        [ProducesResponseType(StatusCodes.Status204NoContent, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
        public async Task<ActionResult<LocalityReadDto>> UpdateSchemeType([FromBody] SchemeTypeUpdateDto values, [FromServices] ISchemeTypeService _schemeTypeService)
        {
            var userId = _userContextService.GetUserId();

            if (!string.Equals(userId, values.ModifiedBy))
            {
                return Unauthorized();
            }

            var result = await _schemeTypeService.UpdateSchemeTypeAsync(values);

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
        /// Deletes a scheme type by its ID
        /// </summary>
        /// <param name="schemeTypeId">The ID of the scheme type to delete</param>
        /// <returns>Success or error response</returns>
        [HttpDelete("DeleteSchemeType/{schemeTypeId}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SuccessResponseDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
        public async Task<ActionResult> DeleteSchemeType(int schemeTypeId, [FromServices] ISchemeTypeService _schemeTypeService)
        {
            try
            {
                var result = await _schemeTypeService.DeleteSchemeType(schemeTypeId);

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
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }



    }
}

