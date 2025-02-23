using System.Web;
using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;

namespace Modules.Customers.Presntation.Controllers.v1;

[ApiController]
[ApiVersion("1.0")]
[Route("api/v{version:apiVersion}/[controller]")]
[Produces("application/json")]
public class OnlineCustomerController : ControllerBase
{
    private readonly ILogger<OnlineCustomerController> _logger;
    private readonly IPropertyDetailsService _propertyDetailsService;
    private readonly ICustomerDetailsService _customerDetailsService;
    private readonly ICustomerTransactionsService _transactionsService;
    private readonly ICustomerInvoiceService _invoiceService;
    private readonly ICustomerPaymentsService _paymentsService;

    public OnlineCustomerController(ILogger<OnlineCustomerController> logger, IPropertyDetailsService propertyDetailsService, ICustomerDetailsService customerDetailsService, ICustomerTransactionsService transactionsService, ICustomerInvoiceService invoiceService, ICustomerPaymentsService paymentsService)
    {
        _logger = logger;
        _propertyDetailsService = propertyDetailsService;
        _customerDetailsService = customerDetailsService;
        _transactionsService = transactionsService;
        _invoiceService = invoiceService;
        _paymentsService = paymentsService;
    }

    [HttpGet("AvailableProperties")]
    public async Task<IEnumerable<AvailablePropertySummaryViewDto>> AvailableProperties()
    {
        return await _propertyDetailsService.AvailablePropertiesSummary();
    }


    [HttpGet("PropertySummary/MobileView/{customerCode}", Name = "PropertyDetailsSummaryMobileView")]
    public async Task<IEnumerable<PropertySummaryMobileViewDto>> MobileView(string customerCode)
    {
         return await _propertyDetailsService.GetPropertySummaryMobile(customerCode);
    }

    [HttpGet("PropertySummary/WebView/{customerCode}", Name = "PropertyDetailsSummaryWebView")]
    public async Task<IEnumerable<PropertySummaryWebViewDto>> WebView(string customerCode)
    {
        return await _propertyDetailsService.GetPropertySummaryWeb(customerCode);
    }

    [HttpGet("PropertyDetails/{propertyNumber}")]
    public async Task<PropertyDetailsReadDto> PropertyDetails(string propertyNumber)
    {
        string propertynumber = HttpUtility.UrlDecode(propertyNumber);
        return await _propertyDetailsService.GetPropertyDetails(propertynumber);
    }

    [HttpGet("CustomerTransactions/{customerCode}")]
    public async Task<IEnumerable<CustomerTransactionsReadDto>> CustomerTransactions(string customerCode)
    {
        return await _transactionsService.CustomerTransactionDetails(customerCode);
    }


    [HttpGet("CustomerTransactions/{customerCode}/{propertyNumber}")]
    public async Task<IEnumerable<CustomerTransactionsReadDto>> CustomerTransactions(string customerCode, string propertyNumber)
    {
        string propertynumber = HttpUtility.UrlDecode(propertyNumber);
        return await _transactionsService.CustomerTransactionDetails(customerCode, propertynumber);
    }

    [HttpGet("CustomerStatementVoucherSearch/{receipt_or_invoiceNumber}")]
    public async Task<IEnumerable<CustomerTransactionsReadDto>> CustomerStatementVoucherSearch(string receipt_or_invoiceNumber)
    {
        return await _transactionsService.CustomerStatementVoucherSearchDetails(receipt_or_invoiceNumber);
    }


    [HttpGet("CustomerStatementDetails/{customerCode}")]
    public async Task<IEnumerable<CustomerTransactionsReadDto>> CustomerStatementDetails(string customerCode)
    {
        return await _transactionsService.CustomerStatementDetails(customerCode);
    }

    [HttpGet("CustomerStatementDetails/{customerCode}/{propertyNumber}")]
    public async Task<IEnumerable<CustomerTransactionsReadDto>> CustomerStatementDetails(string customerCode, string propertyNumber)
    {
        string propertynumber = HttpUtility.UrlDecode(propertyNumber);
        return await _transactionsService.CustomerStatementDetails(customerCode, propertynumber);
    }

    [HttpGet("CustomerStatementDetails/{customerCode}/{propertyNumber}/{transactionType}/{startDate}/{endDate}")]
    public async Task<IEnumerable<CustomerTransactionsReadDto>> CustomerStatementDetails(string customerCode, string propertyNumber, string transactionType, DateTime startDate, DateTime endDate)
    {
        string propertynumber = HttpUtility.UrlDecode(propertyNumber);
        return await _transactionsService.CustomerStatementSearchDetails(customerCode, propertynumber, transactionType, startDate, endDate);
    }

    [HttpGet("CustomerPaymentsSummary/{customerCode}")]
    public async Task<IEnumerable<CustomerPaymentsSummaryDto>> CustomerPaymentsSummary(string customerCode)
    {
        return await _paymentsService.CustomerPaymentSummary(customerCode);
    }

    [HttpGet("CustomerPaymentDetails/{customerCode}")]
    public async Task<IEnumerable<CustomerPaymentsDto>> CustomerPaymentDetails(string customerCode)
    {
        return await _paymentsService.CustomerPaymentDetails(customerCode);
    }

    [HttpGet("CustomerPropertyPaymentSummary/{propertyNumber}")]
    public async Task<IEnumerable<CustomerPaymentsSummaryDto>> CustomerPropertyPaymentSummary(string propertyNumber)
    {
        return await _paymentsService.CustomerPropertyPaymentSummary(propertyNumber);
    }

    [HttpGet("CustomerPropertyPaymentDetails/{propertyNumber}")]
    public async Task<IEnumerable<CustomerPaymentsDto>> CustomerPropertyPaymentDetails(string propertyNumber)
    {
        return await _paymentsService.CustomerPropertyPaymentDetails(propertyNumber);
    }


    [HttpGet("CustomerPaymentSearchByReceiptNumber/{receiptNumber}")]
    public async Task<CustomerPaymentsSummaryDto> CustomerPaymentSearchByReceiptNumber(string receiptNumber)
    {
        return await _paymentsService.CustomerPaymentSearchByReceiptNumber(receiptNumber);
    }

    [HttpGet("CustomerPaymentDetailsSearchByReceiptNumber/{receiptNumber}")]
    public async Task<CustomerPaymentsDto> CustomerPaymentDetailsSearchByReceiptNumber(string receiptNumber)
    {
        return await _paymentsService.CustomerPaymentDetailsSearchByReceiptNumber(receiptNumber);
    }

    [HttpGet("CustomerPaymentSummarySearch/{propertyNumber}/{paymentMode}/{startDate}/{endDate}")]
    public async Task<IEnumerable<CustomerPaymentsSummaryDto>> CustomerPaymentSummarySearch(string propertyNumber, string paymentMode, DateTime startDate, DateTime endDate)
    {
        return await _paymentsService.CustomerPaymentSummarySearch(propertyNumber, paymentMode,startDate, endDate);
    }


    [HttpGet("CustomerPaymentDetailsSearch/{propertyNumber}/{paymentMode}/{startDate}/{endDate}")]
    public async Task<IEnumerable<CustomerPaymentsDto>> CustomerPaymentDetailsSearch(string propertyNumber, string paymentMode, DateTime startDate, DateTime endDate)
    {
        return await _paymentsService.CustomerPaymentDetailsSearch(propertyNumber, paymentMode, startDate, endDate);
    }




    [HttpPost("AddCustomerDetails", Name = "AddApprovedCustomerDetails")]
    public async Task<GenericResponseDto> CustomerDetails(CustomerDetailsDto values)
    {
        return await _customerDetailsService.AddNewCustomerDetails(values);
    }

    [HttpPost("AddPropertyDetails")]
    public async Task<GenericResponseDto> PropertyDetails(PropertyDetailsDto values)
    {
        return await _propertyDetailsService.AddNewPropertyDetails(values);
    }

    [HttpPost("AddCustomerTransactions")]
    public async Task<GenericResponseDto> AddCustomerTransactions(CustomerTransactionsDto values)
    {
        return await _transactionsService.AddNewCustomerTransactionDetails(values);
        //null!;
    }

    [HttpPost("AddCustomerInvoices")]
    public async  Task<GenericResponseDto> AddCustomerInvoices(CustomerInvoiceDto values)
    {
        return await _invoiceService.AddCustomerInvoiceDetails(values);
    }

    [HttpPost("AddCustomerPayments")]
    public async Task<GenericResponseDto> AddCustomerPayments(CustomerPaymentsDto values)
    {
        return await _paymentsService.AddNewCustomerPaymentDetails(values);
    }

}

