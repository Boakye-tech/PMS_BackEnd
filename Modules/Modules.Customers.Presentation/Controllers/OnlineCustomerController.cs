using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace Modules.Customers.Presntation.Controllers;

[ApiController]
[Route("api/[controller]")]
public class OnlineCustomerController : ControllerBase
{
    private readonly ILogger<OnlineCustomerController> _logger;
    private readonly IPropertyDetailsService _propertyDetailsService;

    public OnlineCustomerController(ILogger<OnlineCustomerController> logger, IPropertyDetailsService propertyDetailsService)
    {
        _logger = logger;
        _propertyDetailsService = propertyDetailsService;
    }

    //[HttpGet(Name = "GetCustomerSetupWeatherForecast")]
    //public IEnumerable<WeatherForecast> Get()
    //{
    //    return Enumerable.Range(1, 5).Select(index => new WeatherForecast
    //    {
    //        Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
    //        TemperatureC = Random.Shared.Next(-20, 55),
    //        Summary = Summaries[Random.Shared.Next(Summaries.Length)]
    //    })
    //    .ToArray();
    //}

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

    [HttpPost("AddCustomerDetails", Name = "AddApprovedCustomerDetails")]
    public Task<IActionResult> CustomerDetails(CustomerDetailsDto values)
    {
        return null!;
    }

    [HttpPost("AddPropertyDetails")]
    public async Task<GenericResponseDto> PropertyDetails(PropertyDetailsDto values)
    {
        return await _propertyDetailsService.AddNewPropertyDetails(values);
         //null!;
    }

}

