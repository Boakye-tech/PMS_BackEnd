// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Finance.Presentation
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Finance.Presentation/Controllers/v1/FinanceController.Bank.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/03/2025 
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

        //public readonly IBankBranchService _bankBranchService;
        //public readonly IBankService _bankService;
        //public readonly IBankSortCodesService _bankSortCodesService;


        //---------BANKS-----------
        /// <summary>
        /// Returns a list of all banks in the system
        /// </summary>
        [HttpGet]
        [Route("GetBanks")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<BankReadDto>))]
        public async Task<ActionResult<IEnumerable<BankReadDto>>> GetBanks([FromServices] IBankService _bankService)
        {
            return Ok(await _bankService.GetBankAsync());
        }

        /// <summary>
        /// Returns a bank record by its name
        /// </summary>
        [HttpGet]
        [Route("GetBanks/{Banks}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(BankReadDto))]
        public async Task<ActionResult<BankReadDto>> GetBanks(string Banks, [FromServices] IBankService _bankService)
        {
            return Ok(await _bankService.GetBankAsync(Banks));
        }

        /// <summary>
        /// Returns a bank record by its ID
        /// </summary>
        [HttpGet]
        [Route("GetBankById/{bankId}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(BankReadDto))]
        public async Task<ActionResult<BankReadDto>> GetBanksById(string bankId, [FromServices] IBankService _bankService)
        {
            return Ok(await _bankService.GetBankAsync(bankId));
        }

        // POST: api/AddBank
        /// <summary>
        /// Creates a new bank record in the system
        /// </summary>
        /// <remarks>
        /// Addition of new bank records for financial transactions
        ///
        /// **Sample Request:**
        ///
        ///     POST /AddBank
        ///
        /// **Sample Request Body:**
        /// 
        ///     {
        ///         "bankName": "Example Bank",
        ///         "bankCode": "EXB",
        ///         "createdBy": "32ea339b-75f2-4f57-8153-915f127a9612"
        ///     }
        ///
        /// **Sample Response 201:**
        /// 
        ///     {
        ///         "code": 201,
        ///         "message": "Bank created successfully.",
        ///         "data": {
        ///             "bankId": 1,
        ///             "bankName": "Example Bank",
        ///             "bankCode": "EXB",
        ///             "createdBy": "32ea339b-75f2-4f57-8153-915f127a9612"
        ///         }
        ///     }
        /// 
        /// </remarks>
        [HttpPost]
        [Route("AddBank")]
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(SuccessResponseDto))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
        public async Task<ActionResult<BankReadDto>> AddBank([FromBody] BankCreateDto values, [FromServices] IBankService _bankService)
        {
            try
            {
                return Ok(await _bankService.CreateBankAsync(values));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.InnerException!.Message);
            }
        }

        // PUT: api/UpdateBank
        /// <summary>
        /// Updates an existing bank record in the system
        /// </summary>
        /// <remarks>
        /// Updates the details of an existing bank record
        ///
        /// **Sample Request:**
        ///
        ///     PUT /UpdateBank
        ///
        /// **Sample Request Body:**
        /// 
        ///     {
        ///         "bankId": 1,
        ///         "bankName": "Updated Bank Name",
        ///         "bankCode": "UBN",
        ///         "modifiedBy": "32ea339b-75f2-4f57-8153-915f127a9612"
        ///     }
        ///
        /// **Sample Response 200:**
        /// 
        ///     {
        ///         "code": 200,
        ///         "message": "Bank updated successfully.",
        ///         "data": {
        ///             "bankId": 1,
        ///             "bankName": "Updated Bank Name",
        ///             "bankCode": "UBN",
        ///             "modifiedBy": "32ea339b-75f2-4f57-8153-915f127a9612"
        ///         }
        ///     }
        /// 
        /// </remarks>
        [HttpPut]
        [Route("UpdateBank")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SuccessResponseDto))]
        [ProducesResponseType(StatusCodes.Status204NoContent, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
        public async Task<ActionResult<BankReadDto>> UpdateBanks([FromBody] BankUpdateDto values, [FromServices] IBankService _bankService)
        {
            return Ok(await _bankService.UpdateBankAsync(values));
        }

        /// <summary>
        /// Deletes an existing bank record by its ID
        /// </summary>
        /// <param name="bankId">The ID of the bank to delete</param>
        /// <returns>Success or error response</returns>
        [HttpDelete("DeleteBank/{bankId}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SuccessResponseDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
        public async Task<ActionResult> DeleteBank(string bankId, [FromServices] IBankService _bankService)
        {
            try
            {
                var response = await _bankService.DeleteBankAsync(bankId);

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

        //-----BANK BRANCHES------
        /// <summary>
        /// Returns a list of all bank branches in the system
        /// </summary>
        [HttpGet]
        [Route("Setup/GetBankBranches")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<BankBranchReadDto>))]
        public async Task<ActionResult<IEnumerable<BankBranchReadDto>>> GetBankBranches([FromServices] IBankBranchService _bankBranchService)
        {
            return Ok(await _bankBranchService.GetBankBranchAsync());
        }

        // POST: api/AddBankBranch
        /// <summary>
        /// Creates a new bank branch record in the system
        /// </summary>
        /// <remarks>
        /// Addition of new bank branch records for financial transactions
        ///
        /// **Sample Request:**
        ///
        ///     POST /AddBankBranch
        ///
        /// **Sample Request Body:**
        /// 
        ///     {
        ///         "bankId": 1,
        ///         "branchName": "Main Branch",
        ///         "branchCode": "MB001",
        ///         "createdBy": "32ea339b-75f2-4f57-8153-915f127a9612"
        ///     }
        ///
        /// **Sample Response 201:**
        /// 
        ///     {
        ///         "code": 201,
        ///         "message": "Bank branch created successfully.",
        ///         "data": {
        ///             "branchId": 1,
        ///             "bankId": 1,
        ///             "branchName": "Main Branch",
        ///             "branchCode": "MB001",
        ///             "createdBy": "32ea339b-75f2-4f57-8153-915f127a9612"
        ///         }
        ///     }
        /// 
        /// </remarks>
        [HttpPost]
        [Route("AddBankBranch")]
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(SuccessResponseDto))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
        public async Task<ActionResult<BankBranchReadDto>> AddBankBranch([FromBody] BankBranchCreateDto values, [FromServices] IBankBranchService _bankBranchService)
        {
            try
            {
                return Ok(await _bankBranchService.CreateBankBranchAsync(values));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.InnerException!.Message);
            }
        }

        // PUT: api/UpdateBankBranch
        /// <summary>
        /// Updates an existing bank branch record in the system
        /// </summary>
        /// <remarks>
        /// Updates the details of an existing bank branch record
        ///
        /// **Sample Request:**
        ///
        ///     PUT /UpdateBankBranch
        ///
        /// **Sample Request Body:**
        /// 
        ///     {
        ///         "branchId": 1,
        ///         "bankId": 1,
        ///         "branchName": "Updated Branch Name",
        ///         "branchCode": "UBN001",
        ///         "modifiedBy": "32ea339b-75f2-4f57-8153-915f127a9612"
        ///     }
        ///
        /// **Sample Response 200:**
        /// 
        ///     {
        ///         "code": 200,
        ///         "message": "Bank branch updated successfully.",
        ///         "data": {
        ///             "branchId": 1,
        ///             "bankId": 1,
        ///             "branchName": "Updated Branch Name",
        ///             "branchCode": "UBN001",
        ///             "modifiedBy": "32ea339b-75f2-4f57-8153-915f127a9612"
        ///         }
        ///     }
        /// 
        /// </remarks>
        [HttpPut]
        [Route("UpdateBankBranch")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SuccessResponseDto))]
        [ProducesResponseType(StatusCodes.Status204NoContent, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
        public async Task<ActionResult> UpdateBankBranch([FromBody] BankBranchUpdateDto values, [FromServices] IBankBranchService _bankBranchService)
        {
            var response = await _bankBranchService.UpdateBankBranchAsync(values);
            return Ok(response);
            // if (response.IsSuccess)
            // {
            //     return Ok(response.SuccessResponse);
            // }

            // var status = response.ErrorResponse!.Code;
            // return status switch
            // {
            //     204 => StatusCode(StatusCodes.Status204NoContent, response.ErrorResponse),
            //     400 => BadRequest(response.ErrorResponse),
            //     404 => NotFound(response.ErrorResponse),
            //     _ => StatusCode(StatusCodes.Status500InternalServerError, response.ErrorResponse),
            // };
        }

        /// <summary>
        /// Deletes an existing bank branch record by its ID
        /// </summary>
        /// <param name="branchId">The ID of the bank branch to delete</param>
        /// <returns>Success or error response</returns>
        [HttpDelete("DeleteBankBranch/{branchId}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SuccessResponseDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
        public ActionResult DeleteBankBranch(int branchId, [FromServices] IBankBranchService _bankBranchService)
        {
            return Ok();
            //try
            //{
            //    var response = await _bankBranchService.DeleteBankBranchAsync(branchId);

            //    if (response.IsSuccess)
            //    {
            //        return Ok(response.SuccessResponse);
            //    }

            //    var status = response.ErrorResponse!.Code;
            //    return status switch
            //    {
            //        404 => NotFound(response.ErrorResponse),
            //        _ => StatusCode(StatusCodes.Status500InternalServerError, response.ErrorResponse),
            //    };
            //}
            //catch (Exception ex)
            //{
            //    return StatusCode(StatusCodes.Status500InternalServerError, ex.InnerException!.Message);
            //}
        }

        //----BANK SORT CODE-----
        /// <summary>
        /// Returns a list of all bank sort codes in the system
        /// </summary>
        [HttpGet]
        [Route("Setup/GetBankSortCodes")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<BankSortCodesReadDto>))]
        public async Task<ActionResult<IEnumerable<BankSortCodesReadDto>>> GetBankSortCodes([FromServices] IBankSortCodesService _bankSortCodesService)
        {
            return Ok(await _bankSortCodesService.GetBankSortCodesAsync());
        }

        // POST: api/CreateBankSortCodes
        /// <summary>
        /// Creates a new bank sort code record in the system
        /// </summary>
        /// <remarks>
        /// Addition of new bank sort code records for financial transactions
        ///
        /// **Sample Request:**
        ///
        ///     POST /CreateBankSortCodes
        ///
        /// **Sample Request Body:**
        /// 
        ///     {
        ///         "bankId": 1,
        ///         "sortCode": "123456",
        ///         "createdBy": "32ea339b-75f2-4f57-8153-915f127a9612"
        ///     }
        ///
        /// **Sample Response 201:**
        /// 
        ///     {
        ///         "code": 201,
        ///         "message": "Bank sort code created successfully.",
        ///         "data": {
        ///             "sortCodeId": 1,
        ///             "bankId": 1,
        ///             "sortCode": "123456",
        ///             "createdBy": "32ea339b-75f2-4f57-8153-915f127a9612"
        ///         }
        ///     }
        /// 
        /// </remarks>
        [HttpPost]
        [Route("CreateBankSortCodes")]
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(SuccessResponseDto))]
        [ProducesResponseType(StatusCodes.Status204NoContent, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
        public async Task<ActionResult> AddBankSortCodes([FromBody] BankSortCodesCreateDto values, [FromServices] IBankSortCodesService _bankSortCodesService)
        {
            try
            {
                var response = await _bankSortCodesService.CreateBankSortCodesAsync(values);
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

        // PUT: api/UpdateBankSortCodes
        /// <summary>
        /// Updates an existing bank sort code record in the system
        /// </summary>
        /// <remarks>
        /// Updates the details of an existing bank sort code record
        ///
        /// **Sample Request:**
        ///
        ///     PUT /UpdateBankSortCodes
        ///
        /// **Sample Request Body:**
        /// 
        ///     {
        ///         "sortCodeId": 1,
        ///         "bankId": 1,
        ///         "sortCode": "654321",
        ///         "modifiedBy": "32ea339b-75f2-4f57-8153-915f127a9612"
        ///     }
        ///
        /// **Sample Response 200:**
        /// 
        ///     {
        ///         "code": 200,
        ///         "message": "Bank sort code updated successfully.",
        ///         "data": {
        ///             "sortCodeId": 1,
        ///             "bankId": 1,
        ///             "sortCode": "654321",
        ///             "modifiedBy": "32ea339b-75f2-4f57-8153-915f127a9612"
        ///         }
        ///     }
        /// 
        /// </remarks>
        [HttpPut]
        [Route("UpdateBankSortCodes")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SuccessResponseDto))]
        [ProducesResponseType(StatusCodes.Status204NoContent, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
        public async Task<ActionResult> UpdateBankSortCodes([FromBody] BankSortCodesUpdateDto values, [FromServices] IBankSortCodesService _bankSortCodesService)
        {
            var response = await _bankSortCodesService.UpdateBankSortCodesAsync(values);

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
        /// Deletes an existing bank sort code record by its ID
        /// </summary>
        /// <param name="sortCodeId">The ID of the bank sort code to delete</param>
        /// <returns>Success or error response</returns>
        [HttpDelete("DeleteBankSortCode/{sortCodeId}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SuccessResponseDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
        public async Task<ActionResult> DeleteBankSortCode(int sortCodeId, [FromServices] IBankSortCodesService _bankSortCodesService)
        {
            try
            {
                var response = await _bankSortCodesService.DeleteBankSortCodesAsync(sortCodeId);

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
