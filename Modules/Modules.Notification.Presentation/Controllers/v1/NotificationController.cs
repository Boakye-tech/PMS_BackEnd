
namespace Modules.Notification.Presentation.Controllers.v1;

[ApiController]
[ApiVersion("1.0")]
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
    public async Task<IActionResult> SendNotification([FromBody] SendNotificationRequestDto values)
    {
        SendNotificationRequest request = new SendNotificationRequest(values.UserId,$"{values.Subject}-{values.DisplayName}",values.Message,values.Type);

        var notificationId = await _mediator.Send(new SendNotificationCommand(request));
        return Ok(notificationId);
    }
}

