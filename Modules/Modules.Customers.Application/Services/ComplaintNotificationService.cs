// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Customers.Application
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/06/2025
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

using Microsoft.Extensions.Logging;


namespace Modules.Customers.Application.Services
{
    public interface IComplaintNotificationService
    {
        Task NotifyStaffAboutNewComplaint(ComplaintCreateDto complaint, string complaintNumber);
    }

    public class ComplaintNotificationService : IComplaintNotificationService
    {
        private readonly INotificationModuleService _notificationService;
        private readonly ICustomerModuleCommunicationServices _moduleComms;
        private readonly ILogger<ComplaintNotificationService> _logger;

        public ComplaintNotificationService(
            INotificationModuleService notificationService,
            ICustomerModuleCommunicationServices moduleComms,
            ILogger<ComplaintNotificationService> logger)
        {
            _notificationService = notificationService;
            _moduleComms = moduleComms;
            _logger = logger;
        }

        public async Task NotifyStaffAboutNewComplaint(ComplaintCreateDto complaint, string complaintNumber)
        {
            try
            {
                // Send to staff module
                complaint.ComplaintNumber = complaintNumber;
                var response = await _moduleComms.SendSubmittedComplaintDetailsAsync(complaint);

                var complaintRole_Users = await _notificationService.GetComplaintStaffAsync("complaint");

                foreach (var user in complaintRole_Users!)
                {
                    var payload = new SendNotificationRequestDto(
                        RecipientContact: user.emailAddress!,
                        DisplayName: user.fullName!,
                        Subject: $"New Complaint Submitted - {complaintNumber}",
                        Message: $"A new complaint has been submitted by {complaint.CustomerName} regarding property {complaint.PropertyNumber}",
                        NotificationType: 3,
                        UserId: user.userId!
                    );

                    await _notificationService.SendNotificationDetailsAsync(payload);
                }

                if (!response)
                {
                    _logger.LogCritical("Modular communication for complaint {ComplaintNumber} was unsuccessful", complaintNumber);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error notifying staff about new complaint {ComplaintNumber}", complaintNumber);
                throw;
            }
        }
    }
}