// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Finance.Presentation
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Finance.Presentation/Controllers/v1/FinanceController.BankAccountNumbers.cs
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
        //---BANK ACCOUNT NUMBERS-------
        /// <summary>
        /// Returns a list of all bank account numbers in the system based on a filter condition
        /// </summary>
        [HttpGet]
        [Route("GetBankAccountNumbers")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<BankAccountNumbersReadDto>))]
        public async Task<ActionResult<List<BankAccountNumbersReadDto>>> GetBankAccountNumbers([FromQuery] string searchTerm, [FromServices] IBankAccountNumbersService _bankAccountNumbers)
        {
            return Ok(await _bankAccountNumbers.GetBankAccountNumbersByCriteriaAsync(searchTerm));
        }

        // POST: api/CreateBankAccountNumbers
        /// <summary>
        /// Creates a new bank account number record in the system
        /// </summary>
        /// <remarks>
        /// Addition of new bank account number for financial management
        ///
        /// **Sample Request:**
        ///
        ///     POST /CreateBankAccountNumbers
        ///
        /// **Sample Request Body:**
        /// 
        ///     {
        ///         "AccountNumber": "12345678901234567890",
        ///         "BankId": 1,
        ///         "BranchId": 5,
        ///         "CurrencyId": 1,
        ///         "Description": "Main USD Corporate Account",
        ///         "CreatedBy": "32ea339b-75f2-4f57-8153-915f127a9612"
        ///     }
        ///
        /// **Sample Response 201:**
        /// 
        ///     {
        ///         "code": 201,
        ///         "message": "Bank account number created successfully.",
        ///     }
        /// 
        /// </remarks>
        [HttpPost]
        [Route("CreateBankAccountNumbers")]
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(SuccessResponseDto))]
        [ProducesResponseType(StatusCodes.Status204NoContent, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
        public async Task<ActionResult> CreateBankAccountNumbers([FromServices] IBankAccountNumbersService _bankAccountNumbers, [FromBody] BankAccountNumbersCreateDto values)
        {
            try
            {
                var response = await _bankAccountNumbers.CreateBankAccountNumbersAsync(values);
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

        // PUT: api/UpdateBankAccountNumbers
        /// <summary>
        /// Updates an existing bank account number record in the system
        /// </summary>
        /// <remarks>
        /// Updates the details of an existing bank account number record
        ///
        /// **Sample Request:**
        ///
        ///     PUT /UpdateBankAccountNumbers
        ///
        /// **Sample Request Body:**
        /// 
        ///     {
        ///         "BankAccountNumbersId": 1,
        ///         "AccountNumber": "12345678901234567890",
        ///         "BankId": 1,
        ///         "BranchId": 5,
        ///         "CurrencyId": 1,
        ///         "Description": "Updated Main USD Corporate Account",
        ///         "ModifiedBy": "32ea339b-75f2-4f57-8153-915f127a9612"
        ///     }
        ///
        /// **Sample Response 200:**
        /// 
        ///     {
        ///         "code": 200,
        ///         "message": "Bank account number updated successfully.",
        ///     }
        /// 
        /// </remarks>
        [HttpPut]
        [Route("UpdateBankAccountNumbers")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SuccessResponseDto))]
        [ProducesResponseType(StatusCodes.Status204NoContent, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
        public async Task<ActionResult> UpdateBankAccountNumbers([FromServices] IBankAccountNumbersService _bankAccountNumbers, [FromBody] BankAccountNumbersUpdateDto values)
        {
            var response = await _bankAccountNumbers.UpdateBankAccountNumbersAsync(values);

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
        /// Deletes an existing bank account number record by its ID
        /// </summary>
        /// <param name="bankAccountNumbersId">The ID of the bank account number to delete</param>
        /// <returns>Success or error response</returns>
        [HttpDelete("DeleteBankAccountNumbers/{bankAccountNumbersId}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SuccessResponseDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
        public async Task<ActionResult> DeleteBankAccountNumbers([FromServices] IBankAccountNumbersService _bankAccountNumbers, int bankAccountNumbersId)
        {
            try
            {
                var response = await _bankAccountNumbers.DeleteBankAccountNumbersAsync(bankAccountNumbersId);

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
