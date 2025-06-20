// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Notification.Presentation
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Notification.Presentation/Filters/GlobalExceptionHandler.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

using System.Net;
using System.Text.Json;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Modules.Notification.Domain.Exceptions;

namespace Modules.Notification.Presentation.Filters
{
    public class GlobalExceptionHandler
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<GlobalExceptionHandler> _logger;

        public GlobalExceptionHandler(RequestDelegate next, ILogger<GlobalExceptionHandler> logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An unhandled exception occurred");
                await HandleExceptionAsync(context, ex);
            }
        }

        private static async Task HandleExceptionAsync(HttpContext context, Exception exception)
        {
            context.Response.ContentType = "application/json";
            context.Response.StatusCode = (int)GetStatusCode(exception);

            var response = new
            {
                StatusCode = context.Response.StatusCode,
                Message = GetUserFriendlyMessage(exception),
                DetailedMessage = exception.Message,
                Timestamp = DateTime.UtcNow
            };

            var options = new JsonSerializerOptions { PropertyNamingPolicy = JsonNamingPolicy.CamelCase };
            var json = JsonSerializer.Serialize(response, options);
            await context.Response.WriteAsync(json);
        }

        private static HttpStatusCode GetStatusCode(Exception exception)
        {
            return exception switch
            {
                UnauthorizedAccessException => HttpStatusCode.Unauthorized,
                ArgumentException => HttpStatusCode.BadRequest,
                InvalidOperationException => HttpStatusCode.BadRequest,
                KeyNotFoundException => HttpStatusCode.NotFound,
                NotificationConfigurationException => HttpStatusCode.InternalServerError,
                NotificationDeliveryException => HttpStatusCode.ServiceUnavailable,
                NotificationTemplateException => HttpStatusCode.BadRequest,
                NotificationException => HttpStatusCode.InternalServerError,
                _ => HttpStatusCode.InternalServerError
            };
        }

        private static string GetUserFriendlyMessage(Exception exception)
        {
            return exception switch
            {
                UnauthorizedAccessException => "You are not authorized to perform this action.",
                ArgumentException => "Invalid input provided.",
                InvalidOperationException => "The operation cannot be performed at this time.",
                KeyNotFoundException => "The requested resource was not found.",
                NotificationConfigurationException => "There was a problem with the notification system configuration.",
                NotificationDeliveryException => "Unable to deliver the notification at this time.",
                NotificationTemplateException => "There was a problem with the notification template.",
                NotificationException => "An error occurred while processing the notification.",
                _ => "An unexpected error occurred. Please try again later."
            };
        }
    }
}