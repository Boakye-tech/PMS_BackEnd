using Microsoft.AspNetCore.Mvc;
using MediatR;
using Modules.Notification.Application.Dtos;
using Modules.Notification.Application.UseCases;
using Asp.Versioning;

namespace Modules.Notification.Presentation.Controllers.v2;

[ApiController]
[ApiVersion("2.0")]
[Route("api/v{version:apiVersion}/[controller]")]
[Produces("application/json")]
public class NotificationController : ControllerBase
{
    private readonly ILogger<NotificationController> _logger;
    private readonly IMediator _mediator;

    public NotificationController(ILogger <NotificationController> logger, IMediator mediator)
    {
        _logger = logger;
        _mediator = mediator;
    }

    [HttpPost]
    public async Task<IActionResult> SendNotification([FromBody] SendNotificationRequest request)
    {
        var notificationId = await _mediator.Send(new SendNotificationCommand(request));
        return Ok(notificationId);
    }
}

