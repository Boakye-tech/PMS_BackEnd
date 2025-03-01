using System.Net.NetworkInformation;
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

    [HttpGet("PropertyDetails")]
    public async Task<PropertyDetailsReadDto> PropertyDetails([FromQuery] string propertyNumber)
    {
        string propertynumber = HttpUtility.UrlDecode(propertyNumber);
        return await _propertyDetailsService.GetPropertyDetails(propertynumber);
    }

    [HttpGet("CustomerTransactions")]
    public async Task<IEnumerable<CustomerTransactionsReadDto>> CustomerTransactions([FromQuery] string customerCode, [FromQuery] string propertyNumber)
    {
        if (propertyNumber == null && customerCode == null)
        {
            return null!;
        }

        string propertynumber = HttpUtility.UrlDecode(propertyNumber!);
        return await _transactionsService.CustomerTransactionDetails( customerCode, propertynumber);

    }

   
    [HttpGet("CustomerStatement")] 
    public async Task<IEnumerable<CustomerTransactionsReadDto>> CustomerStatement([FromQuery] string? customerCode, [FromQuery] string? propertyNumber, [FromQuery] string? receipt_or_invoiceNumber, [FromQuery] string? transactionType, [FromQuery] int year)
    {
        if (customerCode == null && propertyNumber == null && receipt_or_invoiceNumber == null && transactionType == null && year.ToString().Length != 4)
        {
            return null!;
        }

        string propertynumber = HttpUtility.UrlDecode(propertyNumber!);
        return await _transactionsService.CustomerStatement(customerCode!, propertynumber, receipt_or_invoiceNumber!, transactionType!,year);
    }

    [HttpGet("CustomerPaymentSummary")]
    public async Task<IEnumerable<CustomerPaymentsSummaryDto>> CustomerPaymentSummary([FromQuery] string? customerCode, [FromQuery] string? propertyNumber, [FromQuery] string? receiptNumber, [FromQuery] string? paymentMode, [FromQuery] int year)
    {
        if (propertyNumber == null && receiptNumber == null && paymentMode == null && customerCode == null && year.ToString().Length != 4)
        {
            return null!;
        }

        string propertynumber = HttpUtility.UrlDecode(propertyNumber!);
        return await _paymentsService.CustomerPaymentSummary(customerCode, propertynumber, receiptNumber, paymentMode!, year);
    }


    [HttpGet("CustomerPaymentDetails")]
    public async Task<IEnumerable<CustomerPaymentsDto>> CustomerPaymentDetails([FromQuery] string? customerCode, [FromQuery] string? propertyNumber, [FromQuery] string? receiptNumber, [FromQuery] string? paymentMode, [FromQuery] int year)
    {
        if (propertyNumber == null && receiptNumber == null && paymentMode == null && customerCode == null && year.ToString().Length != 4)
        {
            return null!;
        }

        string propertynumber = HttpUtility.UrlDecode(propertyNumber!);
        return await _paymentsService.CustomerPaymentDetails(customerCode, propertynumber, receiptNumber, paymentMode!, year);
    }


    [HttpGet("CustomerInvoiceSummary")]
    public async Task<IEnumerable<CustomerInvoiceSummaryReadDto>> CustomerInvoiceSummary([FromQuery] string? invoiceNumber, [FromQuery] string? customerCode, [FromQuery] string? propertyNumber, [FromQuery] string? status, [FromQuery] int year)
    {
        if ( invoiceNumber == null && propertyNumber == null && customerCode == null && status == null && year.ToString()!.Length != 4)
        {
            return null!;
        }

        string propertynumber = HttpUtility.UrlDecode(propertyNumber!);
        return await _invoiceService.CustomerInvoiceSummary(invoiceNumber!, customerCode!, propertynumber, status!, year);
    }

    [HttpGet("CustomerInvoiceDetails")]
    public async Task<IEnumerable<CustomerInvoiceDto>> CustomerInvoiceDetails([FromQuery] string? invoiceNumber, [FromQuery] string? customerCode, [FromQuery] string? propertyNumber, [FromQuery] string? status, [FromQuery] int year)
    {
        if (invoiceNumber == null && propertyNumber == null && customerCode == null && status == null && year.ToString()!.Length != 4)
        {
            return null!;
        }

        string propertynumber = HttpUtility.UrlDecode(propertyNumber!);
        return await _invoiceService.CustomerInvoiceDetails(invoiceNumber!, customerCode!, propertynumber, status!, year);
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

