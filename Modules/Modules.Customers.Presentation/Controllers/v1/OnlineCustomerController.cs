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

    public OnlineCustomerController(ILogger<OnlineCustomerController> logger, IPropertyDetailsService propertyDetailsService, ICustomerDetailsService customerDetailsService, ICustomerTransactionsService transactionsService)
    {
        _logger = logger;
        _propertyDetailsService = propertyDetailsService;
        _customerDetailsService = customerDetailsService;
        _transactionsService = transactionsService;
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
    public  Task<GenericResponseDto> AddCustomerInvoices(CustomerInvoiceDto values)
    {
        //return await _propertyDetailsService.AddNewPropertyDetails(values);
        return null!;
    }

    [HttpPost("AddCustomerPayments")]
    public Task<GenericResponseDto> AddCustomerPayments(CustomerPaymentsDto values)
    {
        //return await _propertyDetailsService.AddNewPropertyDetails(values);
        return null!;
    }

}

