using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;

namespace Modules.Legal.Presentation.Controllers;

[ApiController]
[ApiVersion("1.0")]
[Route("api/v{version:apiVersion}/[controller]")]
[Produces("application/json")]

public partial class LegalController : ControllerBase
{
    private readonly ILogger<LegalController> _logger;

    public LegalController(ILogger<LegalController> logger)
    {
        _logger = logger;
    }



}

