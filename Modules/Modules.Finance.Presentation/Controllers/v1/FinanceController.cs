// /**************************************************
// * Company: MindSprings Company Limited
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
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [Produces("application/json")]
    public class FinanceController : ControllerBase
    {

        public readonly IBankBranchService _bankBranchService;
        public readonly IBankService _bankService;
        public readonly IBankSortCodesService _bankSortCodesService;
        public readonly IChartOfAccountsService _chartOfAccountsService;
        public readonly ICurrencyExchangeRateService _currencyAndExchangeRateService;
        public readonly IFormsService _formsService;
        public readonly IPaymentModeService _paymentModeService;
        public readonly IPaymentTypeService _paymentTypeService;
        public readonly IPayPointsService _payPointsService;
        public readonly IInvoiceTypesService _invoiceTypesService;

        public FinanceController(IBankBranchService bankBranchService, IBankService bankService, IBankSortCodesService bankSortCodesService, IChartOfAccountsService chartOfAccountsService,
                                 ICurrencyExchangeRateService currencyAndExchangeRateService, IFormsService formsService, IPaymentModeService paymentModeService, IPaymentTypeService paymentTypeService,
                                 IPayPointsService payPointsService, IInvoiceTypesService invoiceTypesService)
        {
            _bankService = bankService;
            _bankBranchService = bankBranchService;
            _bankSortCodesService = bankSortCodesService;
            _chartOfAccountsService = chartOfAccountsService;
            _currencyAndExchangeRateService = currencyAndExchangeRateService;
            _formsService = formsService;
            _paymentModeService = paymentModeService;
            _paymentTypeService = paymentTypeService;
            _payPointsService = payPointsService;
            _invoiceTypesService = invoiceTypesService;
        }

        //---------BANKS-----------
        /// <summary>
        /// Returns a list of all banks in the system
        /// </summary>
        [HttpGet]
        [Route("GetBanks")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<BankReadDto>))]
        public async Task<ActionResult<IEnumerable<BankReadDto>>> GetBanks()
        {
            return Ok(await _bankService.GetBankAsync());
        }

        /// <summary>
        /// Returns a bank record by its name
        /// </summary>
        [HttpGet]
        [Route("GetBanks/{Banks}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(BankReadDto))]
        public async Task<ActionResult<BankReadDto>> GetBanks(string Banks)
        {
            return Ok(await _bankService.GetBankAsync(Banks));
        }

        /// <summary>
        /// Returns a bank record by its ID
        /// </summary>
        [HttpGet]
        [Route("GetBankById/{bankId}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(BankReadDto))]
        public async Task<ActionResult<BankReadDto>> GetBanksById(string bankId)
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
        public async Task<ActionResult<BankReadDto>> AddBank([FromBody] BankCreateDto values)
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
        public async Task<ActionResult<BankReadDto>> UpdateBanks([FromBody] BankUpdateDto values)
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
        public async Task<ActionResult> DeleteBank(string bankId)
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
        public async Task<ActionResult<IEnumerable<BankBranchReadDto>>> GetBankBranches()
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
        public async Task<ActionResult<BankBranchReadDto>> AddBankBranch([FromBody] BankBranchCreateDto values)
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
        public async Task<ActionResult> UpdateBankBranch([FromBody] BankBranchUpdateDto values)
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
        public ActionResult DeleteBankBranch(int branchId)
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
        public async Task<ActionResult<IEnumerable<BankSortCodesReadDto>>> GetBankSortCodes()
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
        public async Task<ActionResult> AddBankSortCodes([FromBody] BankSortCodesCreateDto values)
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
        public async Task<ActionResult> UpdateBankSortCodes([FromBody] BankSortCodesUpdateDto values)
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
        public async Task<ActionResult> DeleteBankSortCode(int sortCodeId)
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

        //---CHART OF ACCOUNTS-------
        /// <summary>
        /// Returns a list of all chart of accounts in the system
        /// </summary>
        [HttpGet]
        [Route("Setup/GetChartOfAccounts")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<ChartOfAccountsReadDto>))]
        public async Task<ActionResult<IEnumerable<ChartOfAccountsReadDto>>> GetChartOfAccounts()
        {
            return Ok(await _chartOfAccountsService.GetChartOfAccountsAsync());
        }

        //[HttpGet]
        //[Route("Setup/GetBanks/{Banks}")]
        //public async Task<ActionResult<BankReadDto>> GetBanks(string Banks)
        //{
        //    return Ok(await _bankService.GetBankAsync(Banks));
        //}

        //[HttpGet]
        //[Route("Setup/GetBankById/{bankId}")]
        //public async Task<ActionResult<BankReadDto>> GetBanksById(string bankId)
        //{
        //    return Ok(await _bankService.GetBankAsync(bankId));
        //}

        // POST: api/CreateChartOfAccount
        /// <summary>
        /// Creates a new chart of account record in the system
        /// </summary>
        /// <remarks>
        /// Addition of new chart of account records for financial management
        ///
        /// **Sample Request:**
        ///
        ///     POST /CreateChartOfAccount
        ///
        /// **Sample Request Body:**
        /// 
        ///     {
        ///         "accountCode": "1001",
        ///         "accountName": "Cash Account",
        ///         "accountType": "Asset",
        ///         "createdBy": "32ea339b-75f2-4f57-8153-915f127a9612"
        ///     }
        ///
        /// **Sample Response 201:**
        /// 
        ///     {
        ///         "code": 201,
        ///         "message": "Chart of account created successfully.",
        ///         "data": {
        ///             "accountId": 1,
        ///             "accountCode": "1001",
        ///             "accountName": "Cash Account",
        ///             "accountType": "Asset",
        ///             "createdBy": "32ea339b-75f2-4f57-8153-915f127a9612"
        ///         }
        ///     }
        /// 
        /// </remarks>
        [HttpPost]
        [Route("CreateChartOfAccount")]
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(SuccessResponseDto))]
        [ProducesResponseType(StatusCodes.Status204NoContent, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
        public async Task<ActionResult> CreateChartOfAccount([FromBody] ChartOfAccountsCreateDto values)
        {
            try
            {
                var response = await _chartOfAccountsService.CreateChartOfAccountsAsync(values);
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

        // PUT: api/UpdateChartOfAccount
        /// <summary>
        /// Updates an existing chart of account record in the system
        /// </summary>
        /// <remarks>
        /// Updates the details of an existing chart of account record
        ///
        /// **Sample Request:**
        ///
        ///     PUT /UpdateChartOfAccount
        ///
        /// **Sample Request Body:**
        /// 
        ///     {
        ///         "accountId": 1,
        ///         "accountCode": "2001",
        ///         "accountName": "Updated Account Name",
        ///         "accountType": "Liability",
        ///         "modifiedBy": "32ea339b-75f2-4f57-8153-915f127a9612"
        ///     }
        ///
        /// **Sample Response 200:**
        /// 
        ///     {
        ///         "code": 200,
        ///         "message": "Chart of account updated successfully.",
        ///         "data": {
        ///             "accountId": 1,
        ///             "accountCode": "2001",
        ///             "accountName": "Updated Account Name",
        ///             "accountType": "Liability",
        ///             "modifiedBy": "32ea339b-75f2-4f57-8153-915f127a9612"
        ///         }
        ///     }
        /// 
        /// </remarks>
        [HttpPut]
        [Route("UpdateChartOfAccount")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SuccessResponseDto))]
        [ProducesResponseType(StatusCodes.Status204NoContent, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
        public async Task<ActionResult> UpdateChartOfAccount([FromBody] ChartOfAccountsUpdateDto values)
        {
            var response = await _chartOfAccountsService.UpdateChartOfAccountsAsync(values);

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
        /// Deletes an existing chart of account record by its ID
        /// </summary>
        /// <param name="accountId">The ID of the chart of account to delete</param>
        /// <returns>Success or error response</returns>
        [HttpDelete("DeleteChartOfAccount/{accountId}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SuccessResponseDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
        public async Task<ActionResult> DeleteChartOfAccount(int accountId)
        {
            try
            {
                var response = await _chartOfAccountsService.DeleteChartOfAccountsAsync(accountId);

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

        //----CURRENCIES & EXCHANGE RATES-----
        /// <summary>
        /// Returns a list of trading currencies and their respective exchange rates
        /// </summary>
        [HttpGet]
        [Route("CurrencyAndExchangeRates")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<CurrencyExchangeRateReadDto>))]
        public async Task<ActionResult<IEnumerable<CurrencyExchangeRateReadDto>>> GetCurrencyAndExchangeRates()
        {
            return Ok(await _currencyAndExchangeRateService.GetCurrencyExchangeRateAsync());
        }

        // POST: api/CreateCurrencyAndExchangeRate
        /// <summary>
        ///  Creates a new trading currency with corresponding exchange rates for the day
        /// </summary>
        ///     
        /// <remarks>
        /// Addition/Creation of new trading currencies and exchanges rates for various conversion purposes
        ///
        /// **Sample Request:**
        ///
        ///     POST /CreateCurrencyAndExchangeRate
        ///
        /// **Sample Request Body:**
        /// 
        ///     {
        ///         "currencyId": 0,
        ///         "currencyInitial": "GHC",
        ///         "currencyName": "GHANA CEDIS",
        ///         "buyingRate": 1,
        ///         "sellingRate": 1,
        ///         "baseCurrency": true,
        ///         "applicableDate": "2025-01-01T07:15:05.306Z",
        ///         "createdBy": "32ea339b-75f2-4f57-8153-915f127a9612"
        ///     }
        ///
        /// **Sample Response 201:**
        /// 
        ///     {
        ///         "code": 201,
        ///         "message": "Currency and exchange rate created successfully.",
        ///         "data": {
        ///             "currencyId": 1,
        ///             "currencyInitial": "GHC",
        ///             "currencyName": "GHANA CEDIS",
        ///             "buyingRate": 1,
        ///             "sellingRate": 1,
        ///             "baseCurrency": true,
        ///             "applicableDate": "2025-01-01T07:15:05.306Z",
        ///             "createdBy": "32ea339b-75f2-4f57-8153-915f127a9612"
        ///         }
        ///     }
        /// 
        /// </remarks>
        [HttpPost]
        [Route("CreateCurrencyAndExchangeRate")]
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(SuccessResponseDto))]
        [ProducesResponseType(StatusCodes.Status204NoContent, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
        public async Task<ActionResult> CreateCurrencyAndExchangeRate([FromBody] CurrencyExchangeRateCreateDto values)
        {
            try
            {
                var response = await _currencyAndExchangeRateService.CreateCurrencyExchangeRateAsync(values);

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

        // PUT: api/UpdateCurrencyExchangeRate
        /// <summary>
        /// Updates the exchange rates for an existing currency
        /// </summary>
        /// <remarks>
        /// Updates the buying and selling exchange rates of the major trading currencies 
        ///
        /// **Sample Request:**
        ///
        ///     PUT /UpdateCurrencyExchangeRate
        ///
        /// **Sample Request Body:**
        /// 
        ///     {
        ///         "currencyId": 2,
        ///         "buyingRate": 12.54,
        ///         "sellingRate": 12.89,
        ///         "applicableDate": "2025-01-01T07:15:05.306Z",
        ///         "modifiedBy": "32ea339b-75f2-4f57-8153-915f127a9612"
        ///     }
        ///
        /// **Sample Response 200:**
        /// 
        ///     {
        ///         "code": 200,
        ///         "message": "Currency and exchange rate updated successfully.",
        ///         "data": {
        ///             "currencyId": 2,
        ///             "currencyInitial": "USD",
        ///             "currencyName": "U.S. DOLLARS",
        ///             "buyingRate": 12.54,
        ///             "sellingRate": 12.89,
        ///             "baseCurrency": false,
        ///             "applicableDate": "2025-01-01T07:15:05.306Z",
        ///             "modifiedBy": "32ea339b-75f2-4f57-8153-915f127a9612"
        ///         }
        ///     }
        /// 
        /// </remarks>
        [HttpPut]
        [Route("UpdateCurrencyExchangeRate")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SuccessResponseDto))]
        [ProducesResponseType(StatusCodes.Status204NoContent, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
        public async Task<ActionResult> UpdateCurrencyExchangeRate([FromBody] CurrencyExchangeRateUpdateDto values)
        {
            var response = await _currencyAndExchangeRateService.UpdateCurrencyExchangeRateAsync(values);

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

        // PUT: api/UpdateCurrencyDetails
        /// <summary>
        /// Updates the details of an existing currency
        /// </summary>
        /// <remarks>
        /// Updates the basic information of an existing currency
        ///
        /// **Sample Request:**
        ///
        ///     PUT /UpdateCurrencyDetails
        ///
        /// **Sample Request Body:**
        /// 
        ///     {
        ///         "currencyId": 2,
        ///         "currencyInitial": "USD",
        ///         "currencyName": "UNITED STATES DOLLAR",
        ///         "baseCurrency": false,
        ///         "modifiedBy": "32ea339b-75f2-4f57-8153-915f127a9612"
        ///     }
        ///
        /// **Sample Response 200:**
        /// 
        ///     {
        ///         "code": 200,
        ///         "message": "Currency details updated successfully.",
        ///         "data": {
        ///             "currencyId": 2,
        ///             "currencyInitial": "USD",
        ///             "currencyName": "UNITED STATES DOLLAR",
        ///             "buyingRate": 12.54,
        ///             "sellingRate": 12.89,
        ///             "baseCurrency": false,
        ///             "applicableDate": "2025-01-01T07:15:05.306Z",
        ///             "modifiedBy": "32ea339b-75f2-4f57-8153-915f127a9612"
        ///         }
        ///     }
        /// 
        /// </remarks>
        [HttpPut]
        [Route("UpdateCurrencyDetails")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SuccessResponseDto))]
        [ProducesResponseType(StatusCodes.Status204NoContent, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
        public async Task<ActionResult> UpdateCurrencyDetails([FromBody] CurrencyDetailsUpdateDto values)
        {
            var response = await _currencyAndExchangeRateService.UpdateCurrencyDetailsAsync(values);

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
        /// Deletes an exsiting currency and exhange rate by the currency ID
        /// </summary>
        /// <param name="currencyId">The ID of the currency to delete</param>
        /// <returns>Success or error response</returns>
        [HttpDelete("DeleteCurrencyExchangeRate/{currencyId}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SuccessResponseDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
        public async Task<ActionResult> DeleteCurrencyExchangeRate(int currencyId)
        {
            try
            {
                var response = await _currencyAndExchangeRateService.DeleteCurrencyExchangeRateAsync(currencyId);

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

        //----INVOICE TYPES-----
        /// <summary>
        /// Returns a list of all invoice types in the system
        /// </summary>
        [HttpGet]
        [Route("GetInvoiceTypes")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<InvoiceTypesReadDto>))]
        public async Task<ActionResult<IEnumerable<InvoiceTypesReadDto>>> GetInvoiceTypes()
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
        public async Task<ActionResult> CreateInvoiceTypes([FromBody] InvoiceTypesCreateDto values)
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
        public async Task<ActionResult> UpdateInvoiceTypes([FromBody] InvoiceTypesUpdateDto values)
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
        public async Task<ActionResult> DeleteInvoiceType(int invoiceTypeId)
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

        //----FORMS-----
        /// <summary>
        /// Returns a list of all forms in the system
        /// </summary>
        [HttpGet]
        [Route("GetForms")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<FormsReadDto>))]
        public async Task<ActionResult<IEnumerable<FormsReadDto>>> GetForms()
        {
            return Ok(await _formsService.GetFormsAsync());
        }

        // POST: api/CreateForm
        /// <summary>
        /// Creates a new form record in the system
        /// </summary>
        /// <remarks>
        /// Addition of new form records for financial management
        ///
        /// **Sample Request:**
        ///
        ///     POST /CreateForm
        ///
        /// **Sample Request Body:**
        /// 
        ///     {
        ///         "formName": "Payment Form",
        ///         "formCode": "PAY001",
        ///         "createdBy": "32ea339b-75f2-4f57-8153-915f127a9612"
        ///     }
        ///
        /// **Sample Response 201:**
        /// 
        ///     {
        ///         "code": 201,
        ///         "message": "Form created successfully.",
        ///         "data": {
        ///             "formId": 1,
        ///             "formName": "Payment Form",
        ///             "formCode": "PAY001",
        ///             "createdBy": "32ea339b-75f2-4f57-8153-915f127a9612"
        ///         }
        ///     }
        /// 
        /// </remarks>
        [HttpPost]
        [Route("CreateForm")]
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(SuccessResponseDto))]
        [ProducesResponseType(StatusCodes.Status204NoContent, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
        public async Task<ActionResult> CreateForm([FromBody] FormsCreateDto values)
        {
            try
            {
                var response = await _formsService.CreateFormsAsync(values);
                return Ok(response);
                //if (response.IsSuccess)
                //{
                //    return StatusCode(StatusCodes.Status201Created, response.SuccessResponse);
                //}
                //var status = response.ErrorResponse!.Code;
                //return status switch
                //{
                //    204 => StatusCode(StatusCodes.Status204NoContent, response.ErrorResponse),
                //    400 => BadRequest(response.ErrorResponse),
                //    404 => NotFound(response.ErrorResponse),
                //    _ => StatusCode(StatusCodes.Status500InternalServerError, response.ErrorResponse),
                //};
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        // PUT: api/UpdateForm
        /// <summary>
        /// Updates an existing form record in the system
        /// </summary>
        /// <remarks>
        /// Updates the details of an existing form record
        ///
        /// **Sample Request:**
        ///
        ///     PUT /UpdateForm
        ///
        /// **Sample Request Body:**
        /// 
        ///     {
        ///         "formId": 1,
        ///         "formName": "Updated Form Name",
        ///         "formCode": "UPD001",
        ///         "modifiedBy": "32ea339b-75f2-4f57-8153-915f127a9612"
        ///     }
        ///
        /// **Sample Response 200:**
        /// 
        ///     {
        ///         "code": 200,
        ///         "message": "Form updated successfully.",
        ///         "data": {
        ///             "formId": 1,
        ///             "formName": "Updated Form Name",
        ///             "formCode": "UPD001",
        ///             "modifiedBy": "32ea339b-75f2-4f57-8153-915f127a9612"
        ///         }
        ///     }
        /// 
        /// </remarks>
        [HttpPut]
        [Route("UpdateForm")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SuccessResponseDto))]
        [ProducesResponseType(StatusCodes.Status204NoContent, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
        public async Task<ActionResult> UpdateForm([FromBody] FormsUpdateDto values)
        {
            var response = await _formsService.UpdateFormsAsync(values);
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
        /// Deletes an existing form record by its ID
        /// </summary>
        /// <param name="formId">The ID of the form to delete</param>
        /// <returns>Success or error response</returns>
        [HttpDelete("DeleteForm/{formId}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SuccessResponseDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
        public ActionResult DeleteForm(int formId)
        {
            return Ok();
            // try
            // {
            //     var response = await _formsService.DeleteFormsAsync(formId);

            //     if (response.IsSuccess)
            //     {
            //         return Ok(response.SuccessResponse);
            //     }

            //     var status = response.ErrorResponse!.Code;
            //     return status switch
            //     {
            //         404 => NotFound(response.ErrorResponse),
            //         _ => StatusCode(StatusCodes.Status500InternalServerError, response.ErrorResponse),
            //     };
            // }
            // catch (Exception ex)
            // {
            //     return StatusCode(StatusCodes.Status500InternalServerError, ex.InnerException!.Message);
            // }
        }

        //----PAYMENT MODE-----
        /// <summary>
        /// Returns a list of all payment modes in the system
        /// </summary>
        [HttpGet]
        [Route("Setup/GetPaymentModes")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<PaymentModeReadDto>))]
        public async Task<ActionResult<IEnumerable<PaymentModeReadDto>>> GetPaymentModes()
        {
            return Ok(await _paymentModeService.GetPaymentModeAsync());
        }

        // POST: api/CreatePaymentMode
        /// <summary>
        /// Creates a new payment mode record in the system
        /// </summary>
        /// <remarks>
        /// Addition of new payment mode records for financial transactions
        ///
        /// **Sample Request:**
        ///
        ///     POST /CreatePaymentMode
        ///
        /// **Sample Request Body:**
        /// 
        ///     {
        ///         "paymentModeName": "Cash",
        ///         "paymentModeCode": "CASH",
        ///         "createdBy": "32ea339b-75f2-4f57-8153-915f127a9612"
        ///     }
        ///
        /// **Sample Response 201:**
        /// 
        ///     {
        ///         "code": 201,
        ///         "message": "Payment mode created successfully.",
        ///         "data": {
        ///             "paymentModeId": 1,
        ///             "paymentModeName": "Cash",
        ///             "paymentModeCode": "CASH",
        ///             "createdBy": "32ea339b-75f2-4f57-8153-915f127a9612"
        ///         }
        ///     }
        /// 
        /// </remarks>
        [HttpPost]
        [Route("CreatePaymentMode")]
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(SuccessResponseDto))]
        [ProducesResponseType(StatusCodes.Status204NoContent, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
        public async Task<ActionResult> CreatePaymentMode([FromBody] PaymentModeCreateDto values)
        {
            try
            {
                var response = await _paymentModeService.CreatePaymentModeAsync(values);
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

        // PUT: api/UpdatePaymentMode
        /// <summary>
        /// Updates an existing payment mode record in the system
        /// </summary>
        /// <remarks>
        /// Updates the details of an existing payment mode record
        ///
        /// **Sample Request:**
        ///
        ///     PUT /UpdatePaymentMode
        ///
        /// **Sample Request Body:**
        /// 
        ///     {
        ///         "paymentModeId": 1,
        ///         "paymentModeName": "Updated Payment Mode",
        ///         "paymentModeCode": "UPD",
        ///         "modifiedBy": "32ea339b-75f2-4f57-8153-915f127a9612"
        ///     }
        ///
        /// **Sample Response 200:**
        /// 
        ///     {
        ///         "code": 200,
        ///         "message": "Payment mode updated successfully.",
        ///         "data": {
        ///             "paymentModeId": 1,
        ///             "paymentModeName": "Updated Payment Mode",
        ///             "paymentModeCode": "UPD",
        ///             "modifiedBy": "32ea339b-75f2-4f57-8153-915f127a9612"
        ///         }
        ///     }
        /// 
        /// </remarks>
        [HttpPut]
        [Route("UpdatePaymentMode")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SuccessResponseDto))]
        [ProducesResponseType(StatusCodes.Status204NoContent, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
        public async Task<ActionResult> UpdatePaymentMode([FromBody] PaymentModeUpdateDto values)
        {
            var response = await _paymentModeService.UpdatePaymentModeAsync(values);

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
        /// Deletes an existing payment mode record by its ID
        /// </summary>
        /// <param name="paymentModeId">The ID of the payment mode to delete</param>
        /// <returns>Success or error response</returns>
        [HttpDelete("DeletePaymentMode/{paymentModeId}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SuccessResponseDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
        public async Task<ActionResult> DeletePaymentMode(int paymentModeId)
        {
            try
            {
                var response = await _paymentModeService.DeletePaymentModeAsync(paymentModeId);

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

        //----PAYMENT TYPES-----
        /// <summary>
        /// Returns a list of all payment types in the system
        /// </summary>
        [HttpGet]
        [Route("Setup/GetPaymentTypes")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<PaymentTypeReadDto>))]
        public async Task<ActionResult<IEnumerable<PaymentTypeReadDto>>> GetPaymentTypes()
        {
            return Ok(await _paymentTypeService.GetPaymentTypeAsync());
        }

        // POST: api/CreatePaymentType
        /// <summary>
        /// Creates a new payment type record in the system
        /// </summary>
        /// <remarks>
        /// Addition of new payment type records for financial transactions
        ///
        /// **Sample Request:**
        ///
        ///     POST /CreatePaymentType
        ///
        /// **Sample Request Body:**
        /// 
        ///     {
        ///         "paymentTypeName": "Rent Payment",
        ///         "paymentTypeCode": "RENT",
        ///         "createdBy": "32ea339b-75f2-4f57-8153-915f127a9612"
        ///     }
        ///
        /// **Sample Response 201:**
        /// 
        ///     {
        ///         "code": 201,
        ///         "message": "Payment type created successfully.",
        ///         "data": {
        ///             "paymentTypeId": 1,
        ///             "paymentTypeName": "Rent Payment",
        ///             "paymentTypeCode": "RENT",
        ///             "createdBy": "32ea339b-75f2-4f57-8153-915f127a9612"
        ///         }
        ///     }
        /// 
        /// </remarks>
        [HttpPost]
        [Route("CreatePaymentType")]
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(SuccessResponseDto))]
        [ProducesResponseType(StatusCodes.Status204NoContent, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
        public async Task<ActionResult> CreatePaymentType([FromBody] PaymentTypeCreateDto values)
        {
            try
            {
                var response = await _paymentTypeService.CreatePaymentTypeAsync(values);
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

        // PUT: api/UpdatePaymentType
        /// <summary>
        /// Updates an existing payment type record in the system
        /// </summary>
        /// <remarks>
        /// Updates the details of an existing payment type record
        ///
        /// **Sample Request:**
        ///
        ///     PUT /UpdatePaymentType
        ///
        /// **Sample Request Body:**
        /// 
        ///     {
        ///         "paymentTypeId": 1,
        ///         "paymentTypeName": "Updated Payment Type",
        ///         "paymentTypeCode": "UPD",
        ///         "modifiedBy": "32ea339b-75f2-4f57-8153-915f127a9612"
        ///     }
        ///
        /// **Sample Response 200:**
        /// 
        ///     {
        ///         "code": 200,
        ///         "message": "Payment type updated successfully.",
        ///         "data": {
        ///             "paymentTypeId": 1,
        ///             "paymentTypeName": "Updated Payment Type",
        ///             "paymentTypeCode": "UPD",
        ///             "modifiedBy": "32ea339b-75f2-4f57-8153-915f127a9612"
        ///         }
        ///     }
        /// 
        /// </remarks>
        [HttpPut]
        [Route("UpdatePaymentType")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SuccessResponseDto))]
        [ProducesResponseType(StatusCodes.Status204NoContent, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
        public async Task<ActionResult> UpdatePaymentType([FromBody] PaymentTypeUpdateDto values)
        {
            var response = await _paymentTypeService.UpdatePaymentTypeAsync(values);

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
        /// Deletes an existing payment type record by its ID
        /// </summary>
        /// <param name="paymentTypeId">The ID of the payment type to delete</param>
        /// <returns>Success or error response</returns>
        [HttpDelete("DeletePaymentType/{paymentTypeId}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SuccessResponseDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
        public async Task<ActionResult> DeletePaymentType(int paymentTypeId)
        {
            try
            {
                var response = await _paymentTypeService.DeletePaymentTypeAsync(paymentTypeId);

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

        //----PAYPOINTS-----
        /// <summary>
        /// Returns a list of all paypoints in the system
        /// </summary>
        [HttpGet]
        [Route("GetPaypoints")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<PaypointsReadDto>))]
        public async Task<ActionResult<IEnumerable<PaypointsReadDto>>> GetPaypoints()
        {
            return Ok(await _payPointsService.GetPaypointsAsync());
        }

        // POST: api/CreatePaypoint
        /// <summary>
        /// Creates a new paypoint record in the system
        /// </summary>
        /// <remarks>
        /// Addition of new paypoint records for financial transactions
        ///
        /// **Sample Request:**
        ///
        ///     POST /CreatePaypoint
        ///
        /// **Sample Request Body:**
        /// 
        ///     {
        ///         "paypointName": "Main Office",
        ///         "paypointCode": "MO001",
        ///         "createdBy": "32ea339b-75f2-4f57-8153-915f127a9612"
        ///     }
        ///
        /// **Sample Response 201:**
        /// 
        ///     {
        ///         "code": 201,
        ///         "message": "Paypoint created successfully.",
        ///         "data": {
        ///             "paypointId": 1,
        ///             "paypointName": "Main Office",
        ///             "paypointCode": "MO001",
        ///             "createdBy": "32ea339b-75f2-4f57-8153-915f127a9612"
        ///         }
        ///     }
        /// 
        /// </remarks>
        [HttpPost]
        [Route("CreatePaypoint")]
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(SuccessResponseDto))]
        [ProducesResponseType(StatusCodes.Status204NoContent, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
        public async Task<ActionResult> CreatePaypoint([FromBody] PaypointsCreateDto values)
        {
            try
            {
                var response = await _payPointsService.CreatePaypointsAsync(values);
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

        // PUT: api/UpdatePaypoint
        /// <summary>
        /// Updates an existing paypoint record in the system
        /// </summary>
        /// <remarks>
        /// Updates the details of an existing paypoint record
        ///
        /// **Sample Request:**
        ///
        ///     PUT /UpdatePaypoint
        ///
        /// **Sample Request Body:**
        /// 
        ///     {
        ///         "paypointId": 1,
        ///         "paypointName": "Updated Paypoint Name",
        ///         "paypointCode": "UPD001",
        ///         "modifiedBy": "32ea339b-75f2-4f57-8153-915f127a9612"
        ///     }
        ///
        /// **Sample Response 200:**
        /// 
        ///     {
        ///         "code": 200,
        ///         "message": "Paypoint updated successfully.",
        ///         "data": {
        ///             "paypointId": 1,
        ///             "paypointName": "Updated Paypoint Name",
        ///             "paypointCode": "UPD001",
        ///             "modifiedBy": "32ea339b-75f2-4f57-8153-915f127a9612"
        ///         }
        ///     }
        /// 
        /// </remarks>
        [HttpPut]
        [Route("UpdatePaypoint")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SuccessResponseDto))]
        [ProducesResponseType(StatusCodes.Status204NoContent, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
        public async Task<ActionResult> UpdatePaypoint([FromBody] PaypointsUpdateDto values)
        {
            var response = await _payPointsService.UpdatePaypointsAsync(values);

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
        /// Deletes an existing paypoint record by its ID
        /// </summary>
        /// <param name="paypointId">The ID of the paypoint to delete</param>
        /// <returns>Success or error response</returns>
        [HttpDelete("DeletePaypoint/{paypointId}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SuccessResponseDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
        public async Task<ActionResult> DeletePaypoint(int paypointId)
        {
            try
            {
                var response = await _payPointsService.DeletePaypointsAsync(paypointId);

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
