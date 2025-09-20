// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Finance.Presentation
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Finance.Presentation/Controllers/v1/FinanceController.PaymentTerms.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 20/09/2025 5:00 PM
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
        //---PAYMENT TERMS-------
        /// <summary>
        /// Returns a list of all payment terms in the system
        /// </summary>
        [HttpGet]
        [Route("GetPaymentTerms")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<PaymentTermsReadDto>))]
        public async Task<ActionResult<List<PaymentTermsReadDto>>> GetPaymentTerms([FromServices] IPaymentTermsService _paymentTerms)
        {
            return Ok(await _paymentTerms.GetPaymentTermsAsync());
        }

        // POST: api/CreatePaymentTerms
        /// <summary>
        /// Creates a new payment term record in the system
        /// </summary>
        /// <remarks>
        /// Addition of new payment term for financial management
        ///
        /// **Sample Request:**
        ///
        ///     POST /CreatePaymentTerms
        ///
        /// **Sample Request Body:**
        /// 
        ///     {
        ///         "PaymentTerm": 30,
        ///         "CreatedBy": "32ea339b-75f2-4f57-8153-915f127a9612"
        ///     }
        ///
        /// **Sample Response 201:**
        /// 
        ///     {
        ///         "code": 201,
        ///         "message": "Payment term created successfully.",
        ///     }
        /// 
        /// </remarks>
        [HttpPost]
        [Route("CreatePaymentTerms")]
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(SuccessResponseDto))]
        [ProducesResponseType(StatusCodes.Status204NoContent, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
        public async Task<ActionResult> CreatePaymentTerms([FromServices] IPaymentTermsService _paymentTerms, [FromBody] PaymentTermsCreateDto values)
        {
            try
            {
                var response = await _paymentTerms.CreatePaymentTermsAsync(values);
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

        // PUT: api/UpdatePaymentTerms
        /// <summary>
        /// Updates an existing payment term record in the system
        /// </summary>
        /// <remarks>
        /// Updates the details of an existing payment term record
        ///
        /// **Sample Request:**
        ///
        ///     PUT /UpdatePaymentTerms
        ///
        /// **Sample Request Body:**
        /// 
        ///     {
        ///         "PaymentTermsId": 1,
        ///         "PaymentTerm": 45,
        ///         "ModifiedBy": "32ea339b-75f2-4f57-8153-915f127a9612"
        ///     }
        ///
        /// **Sample Response 200:**
        /// 
        ///     {
        ///         "code": 200,
        ///         "message": "Payment term updated successfully.",
        ///     }
        /// 
        /// </remarks>
        [HttpPut]
        [Route("UpdatePaymentTerms")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SuccessResponseDto))]
        [ProducesResponseType(StatusCodes.Status204NoContent, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
        public async Task<ActionResult> UpdatePaymentTerms([FromServices] IPaymentTermsService _paymentTerms, [FromBody] PaymentTermsUpdateDto values)
        {
            var response = await _paymentTerms.UpdatePaymentTermsAsync(values);

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
        /// Deletes an existing payment term record by its ID
        /// </summary>
        /// <param name="paymentTermsId">The ID of the payment term to delete</param>
        /// <returns>Success or error response</returns>
        [HttpDelete("DeletePaymentTerms/{paymentTermsId}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SuccessResponseDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
        public async Task<ActionResult> DeletePaymentTerms([FromServices] IPaymentTermsService _paymentTerms, int paymentTermsId)
        {
            try
            {
                var response = await _paymentTerms.DeletePaymentTermsAsync(paymentTermsId);

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
    }
}
