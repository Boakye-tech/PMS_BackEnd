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
using Modules.Customers.Application.Dtos;
using Modules.Customers.Application.Dtos.Complaints;
using Modules.Customers.Application.Interfaces.ModuleServices;
using Modules.Customers.Domain.Events;
using System.Text;

namespace Modules.Customers.Application.EventHandlers
{
    public class ComplaintSubmittedEventHandler
    {
        private readonly INotificationModuleService _notificationService;
        private readonly ICustomerModuleCommunicationServices _moduleComms;
        private readonly ILogger<ComplaintSubmittedEventHandler> _logger;
        private readonly IComplaintTypeService _complaintTypeService;

        public ComplaintSubmittedEventHandler(INotificationModuleService notificationService, ICustomerModuleCommunicationServices moduleComms, ILogger<ComplaintSubmittedEventHandler> logger, IComplaintTypeService complaintTypeService)
        {
            _notificationService = notificationService;
            _moduleComms = moduleComms;
            _logger = logger;
            _complaintTypeService = complaintTypeService;
        }

        private async Task<string> BuildEmailBody(string staffName, string customerName, int complaintTypeId, string location)
        {
            var complaintTypes = await _complaintTypeService.GetComplaintTypes();
            var complaintType = complaintTypes.FirstOrDefault(ct => ct.complaintTypeId == complaintTypeId);
            var complaintTypeName = complaintType?.complaintTypes ?? "Unknown Complaint Type";

            var sb = new StringBuilder();
            sb.AppendLine($"Hi {staffName},");
            sb.AppendLine();
            sb.AppendLine($"A new complaint has been submitted by {customerName} regarding {complaintTypeName} at {location}.");
            sb.AppendLine();
            sb.AppendLine("Please log in to the system to:");
            sb.AppendLine();
            sb.AppendLine("- Review the complaint details");
            sb.AppendLine("- Acknowledge receipt");
            sb.AppendLine("- Dispatch and assign the case as appropriate");
            sb.AppendLine();
            sb.AppendLine("Thank you,");
            sb.AppendLine("Property Management System");

            return sb.ToString();
        }

        private async Task<string> BuildShortNotificationMessage(string customerName, int complaintTypeId, string location)
        {
            var complaintTypes = await _complaintTypeService.GetComplaintTypes();
            var complaintType = complaintTypes.FirstOrDefault(ct => ct.complaintTypeId == complaintTypeId)?.complaintTypes ?? "Unknown Complaint Type";
            return $"New complaint submitted by {customerName} regarding {complaintType} at {location}. Please review, acknowledge, and assign appropriately.";
        }

        public async Task HandleAsync(ComplaintSubmittedEvent @event)
        {
            try
            {
                if (@event.Complaint.Source == ComplaintSource.CUSTOMER)
                {
                    var complaintDto = new ComplaintCreateDto
                    {
                        ComplaintId = 0,
                        ComplaintNumber = @event.Complaint.ComplaintNumber,
                        ComplaintTypeId = @event.Complaint.ComplaintTypeId,
                        NatureOfComplaintId = @event.Complaint.NatureOfComplaintId!.Split(',').Select(int.Parse).ToArray(),
                        PropertyNumber = @event.Complaint.PropertyNumber,
                        PropertyLocation = @event.Complaint.PropertyLocation,
                        CustomerCode = @event.Complaint.CustomerCode,
                        CustomerName = @event.Complaint.CustomerName,
                        PhoneNumber = @event.Complaint.PhoneNumber,
                        EmailAddress = @event.Complaint.EmailAddress,
                        IsTheMatterInCourt = @event.Complaint.IsTheMatterInCourt,
                        DetailsOfComplaint = @event.Complaint.DetailsOfComplaint,
                        AvailabilityDate = @event.Complaint.AvailabilityDate,
                        ComplaintDate = @event.Complaint.ComplaintDate,
                        SubmittedBy = @event.Complaint.SubmittedBy,
                        SubmittedBy_PhoneNumber = @event.Complaint.SubmittedBy_PhoneNumber,
                        DocumentImages = @event.Complaint.DocumentList,
                        ComplaintStatus = @event.Complaint.ComplaintStatus,
                        Source = @event.Complaint.Source
                    };

                    // Send to staff module
                    var response = await _moduleComms.SendSubmittedComplaintDetailsAsync(complaintDto);

                    var complaintRole_Users = await _notificationService.GetComplaintStaffAsync("complaint");

                    foreach (var user in complaintRole_Users!)
                    {
                        // In-app notification
                        var inAppPayload = new SendNotificationRequestDto(
                            RecipientContact: user.userId!,
                            DisplayName: user.fullName!,
                            Subject: $"New Complaint Submitted - {@event.ComplaintNumber}",
                            Message: await BuildShortNotificationMessage(
                                @event.Complaint.CustomerName!,
                                @event.Complaint.ComplaintTypeId,
                                @event.Complaint.PropertyLocation!
                            ),
                            NotificationType: 3, // In-app notification
                            UserId: user.userId!
                        );
                        await _notificationService.SendNotificationDetailsAsync(inAppPayload);

                        // Email notification
                        if (!string.IsNullOrEmpty(user.emailAddress))
                        {
                            var emailPayload = new SendNotificationRequestDto(
                                RecipientContact: user.emailAddress,
                                DisplayName: user.fullName!,
                                Subject: $"New Complaint Submitted - {@event.ComplaintNumber}",
                                Message: await BuildEmailBody(user.fullName!, @event.Complaint.CustomerName!, @event.Complaint.ComplaintTypeId, @event.Complaint.PropertyLocation!),
                                NotificationType: 0, // Email notification
                                UserId: user.userId!
                            );
                            await _notificationService.SendNotificationDetailsAsync(emailPayload);
                        }

                        // SMS notification
                        if (!string.IsNullOrEmpty(user.phoneNumber))
                        {
                            var smsPayload = new SendNotificationRequestDto(
                                RecipientContact: user.phoneNumber,
                                DisplayName: user.fullName!,
                                Subject: $"New Complaint - {@event.ComplaintNumber}",
                                Message: await BuildShortNotificationMessage(
                                    @event.Complaint.CustomerName!,
                                    @event.Complaint.ComplaintTypeId,
                                    @event.Complaint.PropertyLocation!
                                ),
                                NotificationType: 1, // SMS notification
                                UserId: user.userId!
                            );
                            await _notificationService.SendNotificationDetailsAsync(smsPayload);
                        }
                    }

                    if (!response)
                    {
                        _logger.LogCritical("Modular communication for complaint {ComplaintNumber} was unsuccessful", @event.ComplaintNumber);
                    }
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error handling complaint submitted event for {ComplaintNumber}", @event.ComplaintNumber);
                throw;
            }
        }


    }

    public class ComplaintStatusChangedEventHandler
    {
        private readonly INotificationModuleService _notificationService;
        private readonly ILogger<ComplaintStatusChangedEventHandler> _logger;

        public ComplaintStatusChangedEventHandler(
            INotificationModuleService notificationService,
            ILogger<ComplaintStatusChangedEventHandler> logger)
        {
            _notificationService = notificationService;
            _logger = logger;
        }

        public async Task HandleAsync(ComplaintStatusChangedEvent @event)
        {
            try
            {
                var complaintRole_Users = await _notificationService.GetComplaintStaffAsync("complaint");

                foreach (var user in complaintRole_Users!)
                {
                    var payload = new SendNotificationRequestDto(
                        RecipientContact: user.emailAddress,
                        DisplayName: user.fullName,
                        Subject: $"Complaint Status Changed - {@event.ComplaintNumber}",
                        Message: $"Complaint {@event.ComplaintNumber} status has been changed from {@event.OldStatus} to {@event.NewStatus} by {@event.ChangedBy}",
                        NotificationType: 3,
                        UserId: user.userId
                    );

                    await _notificationService.SendNotificationDetailsAsync(payload);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error handling complaint status changed event for {ComplaintNumber}", @event.ComplaintNumber);
                throw;
            }
        }
    }

    public class ComplaintCancelledEventHandler
    {
        private readonly INotificationModuleService _notificationService;
        private readonly ICustomerModuleCommunicationServices _moduleComms;
        private readonly ILogger<ComplaintCancelledEventHandler> _logger;

        public ComplaintCancelledEventHandler(
            INotificationModuleService notificationService,
            ICustomerModuleCommunicationServices moduleComms,
            ILogger<ComplaintCancelledEventHandler> logger)
        {
            _notificationService = notificationService;
            _moduleComms = moduleComms;
            _logger = logger;
        }

        public async Task HandleAsync(ComplaintCancelledEvent @event)
        {
            try
            {
                var complaintRole_Users = await _notificationService.GetComplaintStaffAsync("complaint");

                foreach (var user in complaintRole_Users!)
                {
                    var payload = new SendNotificationRequestDto(
                        RecipientContact: user.emailAddress,
                        DisplayName: user.fullName,
                        Subject: $"Complaint Cancelled - {@event.ComplaintNumber}",
                        Message: $"Complaint {@event.ComplaintNumber} has been cancelled by {@event.CancelledBy}. Notes: {@event.CancelNotes}",
                        NotificationType: 3,
                        UserId: user.userId
                    );

                    await _notificationService.SendNotificationDetailsAsync(payload);
                }

                // Send to staff module
                var response = await _moduleComms.SendComplaintCancelledAsync(new ComplaintCancellationDto
                {
                    ComplaintNumber = @event.ComplaintNumber,
                    CancelNotes = @event.CancelNotes,
                    CancelledBy = @event.CancelledBy
                });

                if (!response)
                {
                    _logger.LogCritical("Modular communication for cancelled complaint {ComplaintNumber} was unsuccessful", @event.ComplaintNumber);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error handling complaint cancelled event for {ComplaintNumber}", @event.ComplaintNumber);
                throw;
            }
        }
    }

    public class ComplaintReopenedEventHandler
    {
        private readonly INotificationModuleService _notificationService;
        private readonly ICustomerModuleCommunicationServices _moduleComms;
        private readonly ILogger<ComplaintReopenedEventHandler> _logger;

        public ComplaintReopenedEventHandler(
            INotificationModuleService notificationService,
            ICustomerModuleCommunicationServices moduleComms,
            ILogger<ComplaintReopenedEventHandler> logger)
        {
            _notificationService = notificationService;
            _moduleComms = moduleComms;
            _logger = logger;
        }

        public async Task HandleAsync(ComplaintReopenedEvent @event)
        {
            try
            {
                var complaintRole_Users = await _notificationService.GetComplaintStaffAsync("complaint");

                foreach (var user in complaintRole_Users!)
                {
                    var payload = new SendNotificationRequestDto(
                        RecipientContact: user.emailAddress,
                        DisplayName: user.fullName,
                        Subject: $"Complaint Reopened - {@event.ComplaintNumber}",
                        Message: $"Complaint {@event.ComplaintNumber} has been reopened by {@event.ReopenedBy}. Notes: {@event.ReopenNotes}",
                        NotificationType: 3,
                        UserId: user.userId
                    );

                    await _notificationService.SendNotificationDetailsAsync(payload);
                }

                // Send to staff module
                var response = await _moduleComms.SendComplaintReopenAsync(new ComplaintReopenedDto
                {
                    ComplaintNumber = @event.ComplaintNumber,
                    ReopenNotes = @event.ReopenNotes,
                    ReopenedBy = @event.ReopenedBy
                });

                if (!response)
                {
                    _logger.LogCritical("Modular communication for reopened complaint {ComplaintNumber} was unsuccessful", @event.ComplaintNumber);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error handling complaint reopened event for {ComplaintNumber}", @event.ComplaintNumber);
                throw;
            }
        }
    }

    public class ComplaintClosedEventHandler
    {
        private readonly INotificationModuleService _notificationService;
        private readonly ICustomerModuleCommunicationServices _moduleComms;
        private readonly ILogger<ComplaintClosedEventHandler> _logger;

        public ComplaintClosedEventHandler(
            INotificationModuleService notificationService,
            ICustomerModuleCommunicationServices moduleComms,
            ILogger<ComplaintClosedEventHandler> logger)
        {
            _notificationService = notificationService;
            _moduleComms = moduleComms;
            _logger = logger;
        }

        public async Task HandleAsync(ComplaintClosedEvent @event)
        {
            try
            {
                var complaintRole_Users = await _notificationService.GetComplaintStaffAsync("complaint");

                foreach (var user in complaintRole_Users!)
                {
                    var payload = new SendNotificationRequestDto(
                        RecipientContact: user.emailAddress,
                        DisplayName: user.fullName,
                        Subject: $"Complaint Closed - {@event.ComplaintNumber}",
                        Message: $"Complaint {@event.ComplaintNumber} has been closed by {@event.ClosedBy}. Notes: {@event.CloseNotes}",
                        NotificationType: 3,
                        UserId: user.userId
                    );

                    await _notificationService.SendNotificationDetailsAsync(payload);
                }

                // Send to staff module
                var response = await _moduleComms.SendComplaintClosedAsync(new ComplaintClosedDto
                {
                    ComplaintNumber = @event.ComplaintNumber,
                    CloseNotes = @event.CloseNotes,
                    ClosedBy = @event.ClosedBy
                });

                if (!response)
                {
                    _logger.LogCritical("Modular communication for closed complaint {ComplaintNumber} was unsuccessful", @event.ComplaintNumber);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error handling complaint closed event for {ComplaintNumber}", @event.ComplaintNumber);
                throw;
            }
        }
    }

    public class ComplaintAcknowledgedEventHandler
    {
        private readonly INotificationModuleService _notificationService;
        private readonly ILogger<ComplaintAcknowledgedEventHandler> _logger;

        public ComplaintAcknowledgedEventHandler(
            INotificationModuleService notificationService,
            ILogger<ComplaintAcknowledgedEventHandler> logger)
        {
            _notificationService = notificationService;
            _logger = logger;
        }

        public async Task HandleAsync(ComplaintAcknowledgedEvent @event)
        {
            try
            {
                var complaintRole_Users = await _notificationService.GetComplaintStaffAsync("complaint");

                foreach (var user in complaintRole_Users!)
                {
                    var payload = new SendNotificationRequestDto(
                        RecipientContact: user.emailAddress,
                        DisplayName: user.fullName,
                        Subject: $"Complaint Acknowledged - {@event.ComplaintNumber}",
                        Message: $"Complaint {@event.ComplaintNumber} has been acknowledged by {@event.AcknowledgedBy}",
                        NotificationType: 3,
                        UserId: user.userId
                    );

                    await _notificationService.SendNotificationDetailsAsync(payload);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error handling complaint acknowledged event for {ComplaintNumber}", @event.ComplaintNumber);
                throw;
            }
        }
    }

    public class ComplaintDispatchedEventHandler
    {
        private readonly INotificationModuleService _notificationService;
        private readonly ILogger<ComplaintDispatchedEventHandler> _logger;

        public ComplaintDispatchedEventHandler(
            INotificationModuleService notificationService,
            ILogger<ComplaintDispatchedEventHandler> logger)
        {
            _notificationService = notificationService;
            _logger = logger;
        }

        public async Task HandleAsync(ComplaintDispatchedEvent @event)
        {
            try
            {
                var complaintRole_Users = await _notificationService.GetComplaintStaffAsync("complaint");

                foreach (var user in complaintRole_Users!)
                {
                    var payload = new SendNotificationRequestDto(
                        RecipientContact: user.emailAddress,
                        DisplayName: user.fullName,
                        Subject: $"Complaint Dispatched - {@event.ComplaintNumber}",
                        Message: $"Complaint {@event.ComplaintNumber} has been dispatched by {@event.DispatchedBy} to Department {@event.DepartmentId}, Unit {@event.DepartmentUnitId}",
                        NotificationType: 3,
                        UserId: user.userId
                    );

                    await _notificationService.SendNotificationDetailsAsync(payload);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error handling complaint dispatched event for {ComplaintNumber}", @event.ComplaintNumber);
                throw;
            }
        }
    }

    public class ComplaintAssignedEventHandler
    {
        private readonly INotificationModuleService _notificationService;
        private readonly ICustomerModuleCommunicationServices _moduleComms;
        private readonly ILogger<ComplaintAssignedEventHandler> _logger;

        public ComplaintAssignedEventHandler(
            INotificationModuleService notificationService,
            ICustomerModuleCommunicationServices moduleComms,
            ILogger<ComplaintAssignedEventHandler> logger)
        {
            _notificationService = notificationService;
            _moduleComms = moduleComms;
            _logger = logger;
        }

        public async Task HandleAsync(ComplaintAssignedEvent @event)
        {
            try
            {
                var complaintRole_Users = await _notificationService.GetComplaintStaffAsync("complaint");

                foreach (var user in complaintRole_Users!)
                {
                    var payload = new SendNotificationRequestDto(
                        RecipientContact: user.emailAddress,
                        DisplayName: user.fullName,
                        Subject: $"Complaint Assigned - {@event.ComplaintNumber}",
                        Message: $"Complaint {@event.ComplaintNumber} has been assigned to {@event.AssignedTo} by {@event.AssignedBy}",
                        NotificationType: 3,
                        UserId: user.userId
                    );

                    await _notificationService.SendNotificationDetailsAsync(payload);
                }

                // Send to staff module
                var response = await _moduleComms.SendComplaintAssignedAsync(new ComplaintAssignedDto
                {
                    ComplaintNumber = @event.ComplaintNumber,
                    AssignedTo = @event.AssignedTo,
                    AssignedBy = @event.AssignedBy
                });

                if (!response)
                {
                    _logger.LogCritical("Modular communication for assigned complaint {ComplaintNumber} was unsuccessful", @event.ComplaintNumber);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error handling complaint assigned event for {ComplaintNumber}", @event.ComplaintNumber);
                throw;
            }
        }
    }
}