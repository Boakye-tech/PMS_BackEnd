// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Finance.Presentation
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Finance.Presentation/Controllers/v1/FinanceController.Invoice.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 08/07/2025 
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

        //----INVOICE TYPES-----
        /// <summary>
        /// Returns a list of all invoice types in the system
        /// </summary>
        [HttpGet]
        [Route("GetInvoiceTypes")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<InvoiceTypesReadDto>))]
        public async Task<ActionResult<List<InvoiceTypesReadDto>>> GetInvoiceTypes([FromServices] IInvoiceTypesService _invoiceTypesService)
        {
            return Ok(await _invoiceTypesService.GetInvoiceTypesAsync());
        }

        // POST: api/CreateInvoiceTypes
        /// <summary>
        /// Creates a new invoice type record in the system
        /// </summary>
        /// <remarks>
        /// Addition of new invoice type records for financial transactions
        ///
        /// **Sample Request:**
        ///
        ///     POST /CreateInvoiceTypes
        ///
        /// **Sample Request Body:**
        /// 
        ///     {
        ///         "invoiceTypeName": "Rent Invoice",
        ///         "invoiceTypeCode": "RENT",
        ///         "createdBy": "32ea339b-75f2-4f57-8153-915f127a9612"
        ///     }
        ///
        /// **Sample Response 201:**
        /// 
        ///     {
        ///         "code": 201,
        ///         "message": "Invoice type created successfully.",
        ///         "data": {
        ///             "invoiceTypeId": 1,
        ///             "invoiceTypeName": "Rent Invoice",
        ///             "invoiceTypeCode": "RENT",
        ///             "createdBy": "32ea339b-75f2-4f57-8153-915f127a9612"
        ///         }
        ///     }
        /// 
        /// </remarks>
        [HttpPost]
        [Route("CreateInvoiceTypes")]
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(SuccessResponseDto))]
        [ProducesResponseType(StatusCodes.Status204NoContent, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
        public async Task<ActionResult> CreateInvoiceTypes([FromBody] InvoiceTypesCreateDto values, [FromServices] IInvoiceTypesService _invoiceTypesService)
        {
            try
            {
                var response = await _invoiceTypesService.CreateInvoiceTypesAsync(values);
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

        // PUT: api/UpdateInvoiceTypes
        /// <summary>
        /// Updates an existing invoice type record in the system
        /// </summary>
        /// <remarks>
        /// Updates the details of an existing invoice type record
        ///
        /// **Sample Request:**
        ///
        ///     PUT /UpdateInvoiceTypes
        ///
        /// **Sample Request Body:**
        /// 
        ///     {
        ///         "invoiceTypeId": 1,
        ///         "invoiceTypeName": "Updated Invoice Type",
        ///         "invoiceTypeCode": "UPD",
        ///         "modifiedBy": "32ea339b-75f2-4f57-8153-915f127a9612"
        ///     }
        ///
        /// **Sample Response 200:**
        /// 
        ///     {
        ///         "code": 200,
        ///         "message": "Invoice type updated successfully.",
        ///         "data": {
        ///             "invoiceTypeId": 1,
        ///             "invoiceTypeName": "Updated Invoice Type",
        ///             "invoiceTypeCode": "UPD",
        ///             "modifiedBy": "32ea339b-75f2-4f57-8153-915f127a9612"
        ///         }
        ///     }
        /// 
        /// </remarks>
        [HttpPut]
        [Route("UpdateInvoiceTypes")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SuccessResponseDto))]
        [ProducesResponseType(StatusCodes.Status204NoContent, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
        public async Task<ActionResult> UpdateInvoiceTypes([FromBody] InvoiceTypesUpdateDto values, [FromServices] IInvoiceTypesService _invoiceTypesService)
        {
            var response = await _invoiceTypesService.UpdateInvoiceTypesAsync(values);

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
        /// Deletes an existing invoice type record by its ID
        /// </summary>
        /// <param name="invoiceTypeId">The ID of the invoice type to delete</param>
        /// <returns>Success or error response</returns>
        [HttpDelete("DeleteInvoiceType/{invoiceTypeId}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SuccessResponseDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
        public async Task<ActionResult> DeleteInvoiceType(int invoiceTypeId, [FromServices] IInvoiceTypesService _invoiceTypesService)
        {
            try
            {
                var response = await _invoiceTypesService.DeleteInvoiceTypesAsync(invoiceTypeId);

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
