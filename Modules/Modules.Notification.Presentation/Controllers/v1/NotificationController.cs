// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

using Microsoft.AspNetCore.Authorization;
using Modules.Notification.Domain.Enums;
using System.ComponentModel;
using System.Reflection;

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

    //[HttpPost]
    //[Route("SendEmailNotification")]
    //public async Task<IActionResult> SendEmailNotification([FromBody] SendNotificationRequestDto values)
    //{
    //    SendNotificationRequest request = new SendNotificationRequest(values.UserId,$"{values.Subject}-{values.DisplayName}",values.Message,values.Type);

    //    var notificationId = await _mediator.Send(new SendNotificationCommand(request));
    //    return Ok(notificationId);
    //}

    ///// <summary>
    ///// sends sms to recipient mobile phone
    ///// </summary>
    //[HttpPost]
    //[Route("SendSmsNotification")]
    //public async Task<IActionResult> SendSMSNotification([FromBody] SendNotificationRequestDto values)
    //{
    //    SendNotificationRequest request = new SendNotificationRequest(values.UserId,string.Empty, values.Message, values.Type);

    //    var notificationId = await _mediator.Send(new SendNotificationCommand(request));
    //    return Ok(notificationId);

    //}


    [HttpGet]
    [Route("NotificationType")]
    [AllowAnonymous]
    public IActionResult GetNotificationType()
    {
        var types = Enum.GetValues(typeof(NotificationType))
                               .Cast<NotificationType>()
                               .Select(e => new
                               {
                                   Id = (int)e,
                                   Name = e.ToString(),
                                   DisplayName = e.GetType()
                                                 .GetField(e.ToString())!
                                                 .GetCustomAttribute<DescriptionAttribute>()?
                                                 .Description

                               });
        return Ok(types);
    }


    [HttpGet]
    [Route("NotificationStatus")]
    [AllowAnonymous]
    public IActionResult GetNotificationStatus()
    {
        var types = Enum.GetValues(typeof(NotificationStatus))
                               .Cast<NotificationStatus>()
                               .Select(e => new
                               {
                                   Id = (int)e,
                                   Name = e.ToString(),
                                   DisplayName = e.GetType()
                                                 .GetField(e.ToString())!
                                                 .GetCustomAttribute<DescriptionAttribute>()?
                                                 .Description

                               });
        return Ok(types);
    }

    /// <summary>
    /// sends notification to recipient mobile phone or email address via email,sms,push,InApp
    /// </summary>
    [HttpPost]
    [Route("SendNotification")]
    public async Task<IActionResult> SendNotification([FromBody] SendNotificationRequestDto values)
    {
        try
        {
            SendNotificationRequest request = new SendNotificationRequest(values.UserId, $"{values.Subject}-{values.DisplayName}", values.Message, values.Type);

            var notificationId = await _mediator.Send(new SendNotificationCommand(request));
            return Ok(notificationId);

        }
        catch (Exception ex)
        {
            return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
        }

    }
}

