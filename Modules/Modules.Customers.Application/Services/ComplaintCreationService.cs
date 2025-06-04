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
    public interface IComplaintCreationService
    {
        Task<(Complaint Complaint, string ComplaintNumber)> CreateComplaint(ComplaintCreateDto values);
    }

    public class ComplaintCreationService : IComplaintCreationService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<ComplaintCreationService> _logger;

        public ComplaintCreationService(IUnitOfWork unitOfWork, ILogger<ComplaintCreationService> logger)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
        }

        public async Task<(Complaint Complaint, string ComplaintNumber)> CreateComplaint(ComplaintCreateDto values)
        {
            string natureofComplaint = string.Join(',', values.NatureOfComplaintId!);

            var complaint = Complaint.CreateNewComplaint(
                complaintId: 0,
                complaintNumber: values.ComplaintNumber!,
                complaintTypeId: values.ComplaintTypeId,
                natureOfComplaintId: natureofComplaint,
                propertyNumber: values.PropertyNumber!,
                propertyLocation: values.PropertyLocation!,
                customerCode: values.CustomerCode!,
                customerName: values.CustomerName!,
                phoneNumber: values.PhoneNumber!,
                emailAddress: values.EmailAddress!,
                isTheMatterInCourt: values.IsTheMatterInCourt!,
                detailsOfComplaint: values.DetailsOfComplaint!,
                availabilityDate: values.AvailabilityDate,
                complaintDate: DateTime.UtcNow,
                submittedBy: values.SubmittedBy!,
                submittedBy_PhoneNumber: values.SubmittedBy_PhoneNumber!,
                documentList: values.DocumentImages!,
                complaintStatus: ComplaintStatus.SUBMITTED,
                source: values.Source
            );

            _unitOfWork.Complaint.Insert(complaint);

            var complaintHistory = ComplaintHistory.ProcessComplaint(0,complaint.ComplaintNumber, ComplaintStatus.SUBMITTED, values.SubmittedBy, DateTime.UtcNow);

            _unitOfWork.ComplaintHistory.Insert(complaintHistory);
            await _unitOfWork.Complete();

            _logger.LogInformation("Complaint {ComplaintNumber} submitted successfully by {SubmittedBy}",complaint.ComplaintNumber,values.SubmittedBy);

            return (complaint, complaint.ComplaintNumber!);
        }
    }
}