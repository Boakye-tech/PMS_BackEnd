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

namespace Modules.Finance.Presentation.Controllers.v2
{
    [ApiController]
    [ApiVersion("2.0")]
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
        [HttpGet]
        [Route("Setup/GetBanks")]
        public async Task<ActionResult<IEnumerable<BankReadDto>>> GetBanks()
        {
            return Ok(await _bankService.GetBankAsync());
        }

        [HttpGet]
        [Route("Setup/GetBanks/{Banks}")]
        public async Task<ActionResult<BankReadDto>> GetBanks(string Banks)
        {
            return Ok(await _bankService.GetBankAsync(Banks));
        }

        [HttpGet]
        [Route("Setup/GetBankById/{bankId}")]
        public async Task<ActionResult<BankReadDto>> GetBanksById(string bankId)
        {
            return Ok(await _bankService.GetBankAsync(bankId));
        }

        [HttpPost]
        [Route("AddBank")]
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

        [HttpPut]
        [Route("UpdateBank")]
        public async Task<ActionResult<BankReadDto>> UpdateBanks([FromBody] BankUpdateDto values)
        {
            return Ok(await _bankService.UpdateBankAsync(values));
        }

        [HttpDelete("DeleteBank/{bankId}")]
        public void DeleteBanks(int BanksId)
        {
        }


        //-----BANK BRANCHES------
        [HttpGet]
        [Route("Setup/GetBankBranches")]
        public async Task<ActionResult<IEnumerable<BankBranchReadDto>>> GetBankBranches()
        {
            return Ok(await _bankBranchService.GetBankBranchAsync());
        }

        [HttpPost]
        [Route("AddBankBranch")]
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

        //----BANK SORT CODE-----
        [HttpGet]
        [Route("Setup/GetBankSortCodes")]
        public async Task<ActionResult<IEnumerable<BankSortCodesReadDto>>> GetBankSortCodes()
        {
            return Ok(await _bankSortCodesService.GetBankSortCodesAsync());
        }

        [HttpPost]
        [Route("CreateBankSortCodes")]
        public async Task<ActionResult<BankSortCodesReadDto>> CreateBankSortCodes([FromBody] BankSortCodesCreateDto values)
        {
            try
            {
                return Ok(await _bankSortCodesService.CreateBankSortCodesAsync(values));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.InnerException!.Message);
            }
        }

        //---CHART OF ACCOUNTS-------
        [HttpGet]
        [Route("Setup/GetChartOfAccounts")]
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

        [HttpPost]
        [Route("CreateChartOfAccount")]
        public async Task<ActionResult<ChartOfAccountsReadDto>> CreateChartOfAccount([FromBody] ChartOfAccountsCreateDto values)
        {
            try
            {
                return Ok(await _chartOfAccountsService.CreateChartOfAccountsAsync(values));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.InnerException!.Message);
            }
        }

        //[HttpPut]
        //[Route("UpdateBank")]
        //public async Task<ActionResult<BankReadDto>> UpdateBanks([FromBody] BankUpdateDto values)
        //{
        //    return Ok(await _bankService.UpdateBankAsync(values));
        //}

        //[HttpDelete("DeleteBank/{bankId}")]
        //public void DeleteBanks(int BanksId)
        //{
        //}

        //----CURRENCIES & EXCHANGE RATES-----
        [HttpGet]
        [Route("Setup/CurrencyAndExchangeRates")]
        public async Task<ActionResult<IEnumerable<CurrencyExchangeRateReadDto>>> GetCurrencyAndExchangeRates()
        {
            return Ok(await _currencyAndExchangeRateService.GetCurrencyExchangeRateAsync());
        }

        [HttpPost]
        [Route("AddCurrencyAndExchangeRate")]
        public async Task<ActionResult<CurrencyExchangeRateReadDto>> AddCurrencyAndExchangeRate([FromBody] CurrencyExchangeRateCreateDto values)
        {
            try
            {
                return Ok(await _currencyAndExchangeRateService.CreateCurrencyExchangeRateAsync(values));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.InnerException!.Message);
            }
        }

        //----INVOICE TYPES-----
        [HttpGet]
        [Route("Setup/GetInvoiceTypes")]
        public async Task<ActionResult<IEnumerable<InvoiceTypesReadDto>>> GetInvoiceTypes()
        {
            return Ok(await _invoiceTypesService.GetInvoiceTypesAsync());
        }

        [HttpPost]
        [Route("CreateInvoiceTypes")]
        public async Task<ActionResult<InvoiceTypesReadDto>> CreateInvoiceTypes([FromBody] InvoiceTypesCreateDto values)
        {
            try
            {
                return Ok(await _invoiceTypesService.CreateInvoiceTypesAsync(values));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.InnerException!.Message);
            }
        }

        //----FORMS-----
        [HttpGet]
        [Route("Setup/GetForms")]
        public async Task<ActionResult<IEnumerable<FormsReadDto>>> GetForms()
        {
            return Ok(await _formsService.GetFormsAsync());
        }

        [HttpPost]
        [Route("CreateForm")]
        public async Task<ActionResult<FormsReadDto>> CreateForm([FromBody] FormsCreateDto values)
        {
            try
            {
                return Ok(await _formsService.CreateFormsAsync(values));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.InnerException!.Message);
            }
        }

        //----PAYMENT MODE-----
        [HttpGet]
        [Route("Setup/GetPaymentModes")]
        public async Task<ActionResult<IEnumerable<PaymentModeReadDto>>> GetPaymentModes()
        {
            return Ok(await _paymentModeService.GetPaymentModeAsync());
        }

        [HttpPost]
        [Route("CreatePaymentMode")]
        public async Task<ActionResult<PaymentModeReadDto>> CreatePaymentMode([FromBody] PaymentModeCreateDto values)
        {
            try
            {
                return Ok(await _paymentModeService.CreatePaymentModeAsync(values));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.InnerException!.Message);
            }
        }

        //----PAYMENT TYPES-----
        [HttpGet]
        [Route("Setup/GetPaymentTypes")]
        public async Task<ActionResult<IEnumerable<PaymentTypeReadDto>>> GetPaymentTypes()
        {
            return Ok(await _paymentTypeService.GetPaymentTypeAsync());
        }

        [HttpPost]
        [Route("CreatePaymentType")]
        public async Task<ActionResult<PaymentTypeReadDto>> CreatePaymentType([FromBody] PaymentTypeCreateDto values)
        {
            try
            {
                return Ok(await _paymentTypeService.CreatePaymentTypeAsync(values));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.InnerException!.Message);
            }
        }


        //----PAYPOINTS-----
        [HttpGet]
        [Route("Setup/GetPaypoints")]
        public async Task<ActionResult<IEnumerable<PaypointsReadDto>>> GetPaypoints()
        {
            return Ok(await _payPointsService.GetPaypointsAsync());
        }

        [HttpPost]
        [Route("CreatePaypoint")]
        public async Task<ActionResult<PaypointsReadDto>> CreatePaypoint([FromBody] PaypointsCreateDto values)
        {
            try
            {
                return Ok(await _payPointsService.CreatePaypointsAsync(values));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.InnerException!.Message);
            }
        }


    }
}
