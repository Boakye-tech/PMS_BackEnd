using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;
using Modules.Finance.Application.Dtos.Setup;
using Modules.Finance.Application.Interfaces.Setup;

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
        public readonly ICurrencyAndExchangeRateService _currencyAndExchangeRateService;
        public readonly IFormsService _formsService;
        public readonly IPaymentModeService _paymentModeService;
        public readonly IPaymentTypeService _paymentTypeService;
        public readonly IPayPointsService _payPointsService;
        public readonly IInvoiceTypesService _invoiceTypesService;

        public FinanceController(IBankBranchService bankBranchService, IBankService bankService, IBankSortCodesService bankSortCodesService, IChartOfAccountsService chartOfAccountsService,
                                 ICurrencyAndExchangeRateService currencyAndExchangeRateService, IFormsService formsService, IPaymentModeService paymentModeService, IPaymentTypeService paymentTypeService,
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
                return Ok(await _bankService.AddBankAsync(values));
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
        [Route("AddBankSortCodes")]
        public async Task<ActionResult<BankSortCodesReadDto>> AddBankSortCodes([FromBody] BankSortCodesCreateDto values)
        {
            try
            {
                return Ok(await _bankSortCodesService.AddBankSortCodesAsync(values));
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
        [Route("AddChartOfAccount")]
        public async Task<ActionResult<ChartOfAccountsReadDto>> AddChartOfAccount([FromBody] ChartOfAccountsCreateDto values)
        {
            try
            {
                return Ok(await _chartOfAccountsService.AddChartOfAccountsAsync(values));
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
        public async Task<ActionResult<IEnumerable<CurrencyAndExchangeRateReadDto>>> GetCurrencyAndExchangeRates()
        {
            return Ok(await _currencyAndExchangeRateService.GetCurrencyAndExchangeRateAsync());
        }

        [HttpPost]
        [Route("AddCurrencyAndExchangeRate")]
        public async Task<ActionResult<CurrencyAndExchangeRateReadDto>> AddCurrencyAndExchangeRate([FromBody] CurrencyAndExchangeRateCreateDto values)
        {
            try
            {
                return Ok(await _currencyAndExchangeRateService.AddCurrencyAndExchangeRateAsync(values));
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
        [Route("AddInvoiceTypes")]
        public async Task<ActionResult<InvoiceTypesReadDto>> AddInvoiceTypes([FromBody] InvoiceTypesCreateDto values)
        {
            try
            {
                return Ok(await _invoiceTypesService.AddInvoiceTypesAsync(values));
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
        [Route("AddForm")]
        public async Task<ActionResult<FormsReadDto>> AddForm([FromBody] FormsCreateDto values)
        {
            try
            {
                return Ok(await _formsService.AddFormsAsync(values));
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
        [Route("AddPaymentMode")]
        public async Task<ActionResult<PaymentModeReadDto>> AddPaymentMode([FromBody] PaymentModeCreateDto values)
        {
            try
            {
                return Ok(await _paymentModeService.AddPaymentModeAsync(values));
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
        [Route("AddPaymentType")]
        public async Task<ActionResult<PaymentTypeReadDto>> AddPaymentType([FromBody] PaymentTypeCreateDto values)
        {
            try
            {
                return Ok(await _paymentTypeService.AddPaymentTypeAsync(values));
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
        [Route("AddPaypoint")]
        public async Task<ActionResult<PaypointsReadDto>> AddPaypoint([FromBody] PaypointsCreateDto values)
        {
            try
            {
                return Ok(await _payPointsService.AddPaypointsAsync(values));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.InnerException!.Message);
            }
        }


    }
}
