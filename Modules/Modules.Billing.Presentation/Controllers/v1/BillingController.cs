using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;

namespace Modules.Billing.Presentation.Controllers.v1;

[ApiController]
[ApiVersion("1.0")]
[Route("api/v{version:apiVersion}/[controller]")]
[Produces("application/json")]
public class BillingController : ControllerBase
{
    
}

