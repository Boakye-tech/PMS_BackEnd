// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Notification.Presentation
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Notification.Presentation/Controllers/v1/NotificationController.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.SignalR;
using Modules.Notification.Domain.Enums;
using Modules.Notification.Domain.Entities;
using System.ComponentModel;
using System.Reflection;
using Newtonsoft.Json.Linq;

namespace Modules.Notification.Presentation.Controllers.v1;

[ApiController]
[ApiVersion("1.0")]
[Route("api/v{version:apiVersion}/[controller]")]
[Produces("application/json")]
public class NotificationController : ControllerBase
{
    private readonly ILogger<NotificationController> _logger;
    private readonly IMediator _mediator;
    private readonly ISignalRNotificationService _signalRNotificationService;
    private readonly INotificationRepository _repo;

    public NotificationController(ILogger<NotificationController> logger, IMediator mediator, ISignalRNotificationService signalRNotificationService, INotificationRepository repo)
    {
        _logger = logger;
        _repo = repo;
        _mediator = mediator;
        _signalRNotificationService = signalRNotificationService;
    }



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


    [HttpGet]
    [Route("GetUserNotifications")]
    public IActionResult GetUserNotifications([FromQuery] NotificationQueryParametersDto query)
    {
        return Ok(_repo.GetUserNotifications(query.UserId, query.PageNumber, query.PageSize, query.IsRead, query.IsArchive));
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
            SendNotificationRequest request = new SendNotificationRequest(values.RecipientContact, values.DisplayName, values.Subject, values.Message, values.Type, values.UserId);

            var notificationId = await _mediator.Send(new SendNotificationCommand(request));
            return Ok(notificationId);

        }
        catch (Exception ex)
        {
            return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
        }

    }

    /// <summary>
    /// Sends a real-time notification to a specific user
    /// </summary>
    [HttpPost]
    [Route("SendRealTimeNotification")]
    public async Task<IActionResult> SendRealTimeNotification([FromBody] SendNotificationRequestDto values)
    {
        try
        {
            var notification = new Notifications(
                recipientContact: values.RecipientContact,
                subject: values.Subject,
                message: values.Message,
                type: NotificationType.InApp,
                userId: values.UserId
            );

            await _signalRNotificationService.SendNotificationToUserAsync(values.UserId, notification);
            return Ok(new { message = "Real-time notification sent successfully" });
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error sending real-time notification");
            return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
        }
    }

    /// <summary>
    /// Sends a real-time notification to a group of users
    /// </summary>
    [HttpPost]
    [Route("SendGroupNotification")]
    public async Task<IActionResult> SendGroupNotification([FromBody] SendGroupNotificationRequestDto values)
    {
        try
        {
            var results = new List<Guid>();

            // Create and send individual notifications for each recipient
            foreach (var recipient in values.Recipients)
            {
                var notification = new Notifications(
                    recipientContact: recipient.RecipientContact,
                    subject: values.Subject,
                    message: values.Message,
                    type: NotificationType.InApp,
                    userId: recipient.UserId
                );

                // Send to individual user
                await _signalRNotificationService.SendNotificationToUserAsync(recipient.UserId, notification);

                // Also add to group for group-based notifications
                await _signalRNotificationService.SendNotificationToGroupAsync(values.GroupName, notification);

                // Store the notification
                var notificationId = await _mediator.Send(new SendNotificationCommand(
                    new SendNotificationRequest(
                        recipient.RecipientContact,
                        string.Empty,
                        values.Subject,
                        values.Message,
                        NotificationType.InApp,
                        recipient.UserId
                    )
                ));

                results.Add(notificationId);
            }

            return Ok(new
            {
                message = "Group notification sent successfully",
                notificationIds = results
            });
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error sending group notification");
            return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
        }
    }

    /// <summary>
    /// Broadcasts a real-time notification to all connected clients
    /// </summary>
    [HttpPost]
    [Route("BroadcastNotification")]
    // Only admins can broadcast to all users
    public async Task<IActionResult> BroadcastNotification([FromBody] SendNotificationRequestDto values)
    {
        try
        {
            var notification = new Notifications(
                recipientContact: values.RecipientContact,
                subject: values.Subject,
                message: values.Message,
                type: NotificationType.InApp,
                userId: "broadcast" // Using "broadcast" as userId for broadcast notifications
            );

            await _signalRNotificationService.SendNotificationAsync(notification);
            return Ok(new { message = "Broadcast notification sent successfully" });
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error broadcasting notification");
            return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
        }
    }

    /// <summary>
    /// update notification read option
    /// </summary>
    [HttpPut]
    [Route("SetNotificationReadStatus")]
    public async Task<IActionResult> UpdateNotificationReadStatus([FromBody] NotificationIdDto value)
    {
        try
        {
            await _repo.UpdateIsRead(value.notificationId);
            return Ok();
        }
        catch (Exception ex)
        {
            return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
        }

    }


    /// <summary>
    /// update notification archive option
    /// </summary>
    [HttpPut]
    [Route("SetNotificationArchiveStatus")]
    public async Task<IActionResult> UpdateNotificationArchiveStatus([FromBody] NotificationIdDto value)
    {
        try
        {
            await _repo.UpdateIsArchive(value.notificationId);
            return Ok();
        }
        catch (Exception ex)
        {
            return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
        }

    }


}

