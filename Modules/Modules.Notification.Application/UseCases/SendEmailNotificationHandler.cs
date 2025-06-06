// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Notification.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Notification.Application/UseCases/SendEmailNotificationHandler.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 06/06/2025 3:41 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

using Microsoft.AspNetCore.Identity.UI.Services;

namespace Modules.Notification.Application.UseCases
{
	public class SendEmailNotificationHandler : IRequestHandler<SendEmailNotificationCommand, string>
	{
        private readonly INotificationRepository _repository;
        //private readonly INotificationSender _sender;
        private readonly IEmailSender _emailSender;


        public SendEmailNotificationHandler(INotificationRepository repository, IEmailSender sender)
        {
            _repository = repository;
            _emailSender = sender;
        }

        public async Task<string> Handle(SendEmailNotificationCommand command, CancellationToken cancellationToken)
        {
            try
            {
                var emailNotification = new Notifications(command.Request.RecipientContact, $"{command.Request.Subject}-{command.Request.DisplayName}", command.Request.Message, NotificationType.Email, command.Request.UserId);
                //await _repository.AddAsync(emailNotification);

                //var result = _emailSender.SendEmailAsync(emailNotification);
                await _emailSender.SendEmailAsync(command.Request.RecipientContact, $"{command.Request.Subject}-{command.Request.DisplayName}", command.Request.Message);
                var result = "success";


                if (result == "success")
                    emailNotification.MarkAsSent();
                else
                    emailNotification.Status = NotificationStatus.Failed;

                //await _repository.UpdateStatusAsync(emailNotification.Id, emailNotification.Status);

                return result;

            }
            catch (Exception ex)
            {
                return ex.ToString();
            }

        }
    }
}

